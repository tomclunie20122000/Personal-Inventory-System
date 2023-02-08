using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInventorySystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string currentUserID;
        private string connString = "Data Source=TOMDSKTP;Initial Catalog=HomeInventorySystem;Integrated Security=True";
        //        private string connString = ConfigurationManager.ConnectionStrings["PersonalInventorySystem.Properties.Settings.HomeInventorySystemConnectionString"].ConnectionString;

        public static bool CompareByteArrays(byte[] array1, byte[] array2) // compares two hashes (byte arrays)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }

        static byte[] GenerateSaltedHash(byte[] plainText, byte[] salt) // gemerate hashed password using plain text and salt
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

        private void loginbtn_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connString))
            {
                //Open Connection
                conn.Open();

                // prep for query
                string user = "";
                string pass = "";
                string salt = "";

                //Execute Query
                SqlCommand cmd = new SqlCommand("SELECT * FROM usertbl WHERE username ='" + usertxt.Text.ToString() + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())//Open Connection
                {
                    user = reader.GetString(1);
                    pass = reader.GetString(2); //string hashed password
                    salt = reader.GetString(7); //string salt
                    currentUserID = reader.GetValue(0).ToString();
                }

                byte[] passb = Encoding.UTF8.GetBytes(passtxt.Text.ToString()); // converts user input to byte array
                byte[] saltb = Convert.FromBase64String(salt); // converts salt from string to byte array

                string inputPass = Convert.ToBase64String(GenerateSaltedHash(passb, saltb)); // gets hashed version of user input using passb and saltb (both byte inputs for function)

                bool match = CompareByteArrays(Convert.FromBase64String(inputPass), Convert.FromBase64String(pass)); // compares the database hash to the hash from user input.

                //if password and username match, let them in
                if (usertxt.Text == user && match == true)
                {
                    this.Hide();
                    InventoryForm f3 = new InventoryForm();
                    f3.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password....");
                }
            }
                

            
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            RegisterFrom f2 = new RegisterFrom();
            f2.Show();
        }
        
    }
}
