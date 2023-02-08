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
    public partial class AddItemForm : Form
    {
        public AddItemForm()
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
                string name = nameTXT.Text;
                string description = descriptionTXT.Text;
                string value = priceTXT.Text;
                string quantity = quantityTXT.Text;

                //Execute Query
                SqlCommand cmd = new SqlCommand("INSERT INTO itemtbl (user_id, name, description, value_per_item, quantity) VALUES ('" + currentUser + "', '" + name + "', '" + description + "', '" + value + "', '" + quantity + "')", conn);
                cmd.ExecuteNonQuery();

                //Execute Query
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM itemtbl WHERE user_id='" + currentUser + "' AND name='" + name + "' AND description= '" + description + "' AND quantity = '" + quantity + "' ", conn);
                SqlDataReader reader = cmd1.ExecuteReader();

                string currentItemID = "";

                while (reader.Read())
                {
                    currentItemID = reader.GetValue(0).ToString();
                }

                reader.Close();

                string purchaseD = dobtxt.Text;
                string retailer = retailerTxt.Text;
                string URL = imageUrlTxt.Text;

                //Execute Query
                SqlCommand cmd2 = new SqlCommand("INSERT INTO item_info (item_id, purchase_date, image_url, retailer) VALUES ('" + currentItemID + "', '" + purchaseD + "', '" + URL + "', '" + retailer + "') ", conn);
                cmd2.ExecuteNonQuery();

                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
