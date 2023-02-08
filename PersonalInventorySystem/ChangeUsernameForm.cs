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
    public partial class ChangeUsernameForm : Form
    {
        public ChangeUsernameForm()
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

                //Username format validation
                string username_reg = newUsernametxt.Text;
                Regex rUsername = new Regex("^[A-Za-z][A-Za-z0-9_]{7,29}$");
                Match UsernameMatch = rUsername.Match(username_reg);

                if (UsernameMatch.Success)
                {
                    //Execute Query
                    SqlCommand cmd = new SqlCommand("UPDATE usertbl SET username ='" + newUsernametxt.Text + "' WHERE id='" + currentUser + "'", conn);
                    cmd.ExecuteNonQuery();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your Username does not meet the format requirements...");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

