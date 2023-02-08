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
        itemBLL ibl =  new itemBLL();
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ibl.addItem(currentUser, nameTXT.Text, descriptionTXT.Text, priceTXT.Text, quantityTXT.Text, dobtxt.Text, retailerTxt.Text, imageUrlTxt.Text);
                this.Hide();
            }         
            catch 
            {
                MessageBox.Show("Error adding item...");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Error cancelling operation...");
            }
        }
    }
}
