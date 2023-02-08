using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInventorySystem
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private string currentUser = LoginForm.currentUserID;
        //private string connString = ConfigurationManager.ConnectionStrings["PersonalInventorySystem.Properties.Settings.HomeInventorySystemConnectionString"].ConnectionString;
        private string connString = "Data Source=TOMDSKTP;Initial Catalog=HomeInventorySystem;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connString))
            {
                //Open Connection
                conn.Open();

                //Password format validation
                string password_reg = newpasstxt.Text;
                Regex rPassword = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
                Match PasswordMatch = rPassword.Match(password_reg);

                if (PasswordMatch.Success)
                {
                    //Execute Query
                    SqlCommand cmd = new SqlCommand("UPDATE usertbl SET password ='" + newpasstxt.Text + "' WHERE id='" + currentUser + "'", conn);
                    cmd.ExecuteNonQuery();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your password does not meet the format requirements or is the same as your current password.");
                }
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
