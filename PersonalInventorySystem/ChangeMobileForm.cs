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
    public partial class ChangeMobileForm : Form
    {
        public ChangeMobileForm()
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

                //Mobile format validation
                string mobile_reg = newMobileTXT.Text;
                Regex rMobile = new Regex("^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");
                Match MobileMatch = rMobile.Match(mobile_reg);

                if (MobileMatch.Success)
                {
                    //Execute Query
                    SqlCommand cmd = new SqlCommand("UPDATE usertbl SET mobile ='" + newMobileTXT.Text + "' WHERE id='" + currentUser + "'", conn);
                    cmd.ExecuteNonQuery();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your Mobile does not meet the format requirements...");
                }

            }
            
        }
    }
}

