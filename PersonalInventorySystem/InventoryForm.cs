using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonalInventorySystem
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private string currentUser = LoginForm.currentUserID;        

        private void total_price_on_load()//calculates total prices
        {
            try
            {
                itemBLL item = new itemBLL();
                totaltxt.Text = "£" + item.getTotalPrice(currentUser);
            }
            catch
            {
                MessageBox.Show("Error Getting Price...");
            }            
        }

        private void Form3_Load(object sender, EventArgs e) //gets user items on form load
        {
            try
            {
                //updates data grid
                itemBLL item = new itemBLL();
                this.dataGridView1.DataSource = item.GetItemsForUser(currentUser);
                total_price_on_load();
            }
            catch
            {
                MessageBox.Show("Error Loading Form...");
            }
        }

        private void Profile_Click(object sender, EventArgs e)//user profile button
        {
            try
            {
                //creates and shows a new profile form 
                UserProfileForm f4 = new UserProfileForm();
                f4.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error Loading Profile Page...");
            }
            
        }

        private void addItm_Click(object sender, EventArgs e)//add button
        {
            try
            {
                //creats and shows a new add form 
                AddItemForm aif = new AddItemForm();
                aif.ShowDialog();

                //updates data grid
                itemBLL item = new itemBLL();
                this.dataGridView1.DataSource = item.GetItemsForUser(currentUser);
                total_price_on_load();
            }
            catch
            {
                MessageBox.Show("Error Adding Item...");
            }
        }

        private void button2_Click(object sender, EventArgs e)//delete button
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    itemBLL item = new itemBLL();
                    item.deleteItem(dataGridView1.SelectedCells[1].Value.ToString());
                    this.dataGridView1.DataSource = item.GetItemsForUser(currentUser);
                    total_price_on_load();

                } else {
                    MessageBox.Show("Please select a row from the list before deleting");
                }
            }
            catch
            {
                MessageBox.Show("Error Deleting Item...");
            }
        } 

        private void textBox1_TextChanged(object sender, EventArgs e)//search box
        {            
            try
            {
                itemBLL item = new itemBLL();
                this.dataGridView1.DataSource = item.updateSearch(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Error Searching....");
            }
        }
    }
}
