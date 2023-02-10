using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonalInventorySystem
{
    internal class itemDAL
    {
        private DataTable dt = new DataTable();
        private string connString = System.Configuration.ConfigurationManager.ConnectionStrings["PersonalInventorySystem.Properties.Settings.MainDataSet"].ConnectionString;


        public DataTable load(string user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (ConnectionState.Closed == conn.State)
                    {
                        conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT * FROM itemtbl WHERE user_id='" + user + "'", conn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }

        public DataTable search(string search)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (ConnectionState.Closed == conn.State)
                    {
                        conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT * FROM itemtbl WHERE name LIKE '" + search + "%'", conn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    return dt;
                }
            }
            catch
            {
                throw;
            }            
        }

        public void add(string currentUser, string name, string desc, string value, string quantity, string purchaseD, string retailer, string URL)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (ConnectionState.Closed == conn.State)
                    {
                        conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("INSERT INTO itemtbl (user_id, name, description, value_per_item, quantity) VALUES ('" + currentUser + "', '" + name + "', '" + desc + "', '" + value + "', '" + quantity + "')", conn);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand("SELECT * FROM itemtbl WHERE user_id='" + currentUser + "' AND name='" + name + "' AND description= '" + desc + "' AND quantity = '" + quantity + "' ", conn);
                    SqlDataReader reader = cmd1.ExecuteReader();

                    string currentItemID = "";

                    while (reader.Read())
                    {
                        currentItemID = reader.GetValue(0).ToString();
                    }

                    reader.Close();

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO item_info (item_id, purchase_date, image_url, retailer) VALUES ('" + currentItemID + "', '" + purchaseD + "', '" + URL + "', '" + retailer + "') ", conn);
                    cmd2.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }

        public void delete( string value)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (ConnectionState.Closed == conn.State)
                    {
                        conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("DELETE FROM itemtbl WHERE id= '" + value + "' ", conn);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM item_info WHERE item_id= '" + value + "' ", conn);
                    cmd1.ExecuteNonQuery();
                }
            }            
            catch 
            {
                throw;
            }
        }

        public double calculate_price(string user)
        {
            double value = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (ConnectionState.Closed == conn.State)
                    {
                        conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT * FROM itemtbl WHERE user_id='" + user + "' ", conn);
                    SqlDataReader rd = cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        double price = Convert.ToDouble(rd.GetValue(4));
                        double q = Convert.ToDouble(rd.GetValue(5));
                        double currentprice = price * q;
                        value += currentprice;
                    }
                }
                return value;
            }
            catch
            {
                throw;
            }
            
        }
    }
}
