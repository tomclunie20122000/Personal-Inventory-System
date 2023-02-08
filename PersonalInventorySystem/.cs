using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInventorySystem
{
    internal class dbDAL
    {

        private string connString = "Data Source=TOMDSKTP;Initial Catalog=HomeInventorySystem;Integrated Security=True";
        DataTable dt = new DataTable();


        public DataTable load(string query)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (ConnectionState.Closed == conn.State)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    return dt;
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
