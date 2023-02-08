﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using PersonalInventorySystem.BLL;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonalInventorySystem.DAL
{
    internal class userDAL
    {
        private string connString = "Data Source=TOMDSKTP;Initial Catalog=HomeInventorySystem;Integrated Security=True";

        public Array loadUserInfo(string currentUser)
        {
            List<string> list = new List<string>();
            
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //Open Connection
                conn.Open();

                //Execute Query
                SqlCommand cmd = new SqlCommand("SELECT * FROM usertbl WHERE id='" + currentUser + "' ", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read()) //opens reader
                {                    
                    //Grabs all user info and fills out text boxes on form
                    list.Add(reader.GetValue(1).ToString());
                    list.Add(reader.GetValue(2).ToString());
                    list.Add(reader.GetValue(3).ToString());
                    list.Add(reader.GetValue(4).ToString());
                    string d = reader.GetValue(5).ToString();
                    list.Add(d.Substring(0, d.Length - 9));
                    string s = reader.GetValue(6).ToString();
                    list.Add(s.Substring(0, s.Length - 9));
                }
            }
            string[] a = list.ToArray();
            return a;            
        }
        public void registerUsers(string u, string p, string e, string m, string d, DateTime date)
        {
            try 
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();


                    if (doesUsernameExist(u) == false && doesEmailExist(e) == false)
                    {
                        byte[] pass = Encoding.UTF8.GetBytes(p);// we encode as the password is a string
                        byte[] salt = Encoding.UTF8.GetBytes(getSalt());// we encode as the getSalt() returns a string
                        string password_hashed = Convert.ToBase64String(GenerateSaltedHash(pass, salt)); //we convert as a byte array is returned from function
                        string format = "yyyy-MM-dd";

                        //Execute Query
                        SqlCommand cmd = new SqlCommand("INSERT INTO usertbl (username, password_hash, email, mobile, dob, accountCreation, password_salt) VALUES " +
                        "('" + u + "', '" + password_hashed + "', '" + e + "', '" + m + "', '" + d + "', '" + date.ToString(format) + "', '" + Convert.ToBase64String(salt) + "' )", conn);

                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Username or Email already exists already exists...");
                    }
                }
            } 
            catch 
            {
                throw;
            }
            
        }

        public bool doesUsernameExist(string username)
        {
            bool doesUserExist = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM usertbl WHERE username= '" + username + "'", conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (dr.HasRows == true)
                        {
                            doesUserExist = true;
                            break;
                        }
                    }
                    dr.Close();
                    return doesUserExist;
                }
            }
            catch
            {
                throw;
            }            
        }

        public bool doesEmailExist(string email)
        {
            bool doesUserExist = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM usertbl WHERE email= '" + email + "'", conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (dr.HasRows == true)
                        {
                            doesUserExist = true;
                            break;
                        }
                    }
                    dr.Close();
                    return doesUserExist;
                }
            }
            catch
            {
                throw;
            }
            
        }

        public byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)// gemerate hashed password using plain text and salt
        {
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes =
              new byte[plainText.Length + salt.Length];

            //two for loops to add the plain text and the salt into a single byte array
            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }
            return algorithm.ComputeHash(plainTextWithSaltBytes); //returns a byte array
        }

        public string getSalt()// generates random salt
        {
            var random = new RNGCryptoServiceProvider(); //so we can use the random.GetNonZeroBytes

            // Maximum length of salt
            int max_length = 64;
            byte[] salt = new byte[max_length];
            random.GetNonZeroBytes(salt);
            return Convert.ToBase64String(salt);
        }
    }
}