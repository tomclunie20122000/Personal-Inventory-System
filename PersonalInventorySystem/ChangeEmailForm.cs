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
    public partial class ChangeEmailForm : Form
    {
        public ChangeEmailForm()
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

                //Email format validation
                string email_reg = newemailtxt.Text;
                Regex rEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match emailMatch = rEmail.Match(email_reg);

                if (emailMatch.Success)
                {
                    //Execute Query
                    SqlCommand cmd = new SqlCommand("UPDATE usertbl SET email ='" + newemailtxt.Text + "' WHERE id='" + currentUser + "'", conn);
                    cmd.ExecuteNonQuery();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your email does not meet the format requirements...");
                }
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
