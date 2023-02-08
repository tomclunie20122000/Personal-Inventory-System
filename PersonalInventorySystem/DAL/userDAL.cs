using System;
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
using System.Security.Policy;
using System.Data;

namespace PersonalInventorySystem.DAL
{
    internal class userDAL
    {
        private string connString = "Data Source=TOMDSKTP;Initial Catalog=HomeInventorySystem;Integrated Security=True";

        public Array loadUserInfo(string currentUser)
        {
            try
            {
                List<string> list = new List<string>();

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (ConnectionState.Closed == conn.State)
                    {
                        conn.Open();
                    }

                    SqlCommand cmd = new SqlCommand("SELECT * FROM usertbl WHERE id='" + currentUser + "' ", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {                         
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
            catch
            {
                throw;
            }                      
        }

        public void updateEmail(string email, string currentUser)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (ConnectionState.Closed == conn.State)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE usertbl SET email ='" + email + "' WHERE id='" + currentUser + "'", conn);
                cmd.ExecuteNonQuery();
            }              
        }

        public void updateMobile(string mobile, string currentUser)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (ConnectionState.Closed == conn.State)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE usertbl SET mobile ='" + mobile + "' WHERE id='" + currentUser + "'", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void updatePassword(string password, string currentUser)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (ConnectionState.Closed == conn.State)
                {
                    conn.Open();
                }
                byte[] pass = Encoding.UTF8.GetBytes(password);
                byte[] salt = Encoding.UTF8.GetBytes(getSalt());
                string password_hashed = Convert.ToBase64String(GenerateSaltedHash(pass, salt));

                SqlCommand cmd = new SqlCommand("UPDATE usertbl SET password_hash='" + password_hashed + "', password_salt='"+ Convert.ToBase64String(salt) + "' WHERE id='" + currentUser + "'", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void registerUsers(string u, string p, string e, string m, string d, DateTime date)
        {
            try 
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (ConnectionState.Closed == conn.State)
                    {
                        conn.Open();
                    }

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
            try
            {
                bool doesUserExist = false;
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (ConnectionState.Closed == conn.State)
                    {
                        conn.Open();
                    }

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
            try
            {
                bool doesUserExist = false;
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (ConnectionState.Closed == conn.State)
                    {
                        conn.Open();
                    }

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

        public byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)
        {
            try
            {
                HashAlgorithm algorithm = new SHA256Managed();

                byte[] plainTextWithSaltBytes =
                 new byte[plainText.Length + salt.Length];

                for (int i = 0; i < plainText.Length; i++)
                {
                    plainTextWithSaltBytes[i] = plainText[i];
                }
                for (int i = 0; i < salt.Length; i++)
                {
                    plainTextWithSaltBytes[plainText.Length + i] = salt[i];
                }
                return algorithm.ComputeHash(plainTextWithSaltBytes);
            }
            catch
            {
                throw;
            }            
        }

        public string getSalt()
        {
            try
            {
                var random = new RNGCryptoServiceProvider();
                int max_length = 64;
                byte[] salt = new byte[max_length];
                random.GetNonZeroBytes(salt);
                return Convert.ToBase64String(salt);
            }
            catch
            {
                throw;
            }            
        }
    }
}
