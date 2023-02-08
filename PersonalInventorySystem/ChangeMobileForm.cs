using PersonalInventorySystem.BLL;
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

        usersBLL ubl = new usersBLL();
        private string currentUser = LoginForm.currentUserID;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ubl.isMobileValid(newMobileTXT.Text).Success)
                {
                    ubl.updateMobileNumber(newMobileTXT.Text, currentUser);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your mobile does not meet the format requirements...");
                }
            }
            catch
            {
                MessageBox.Show("Error updating mobile number...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error cancelling process...");
            }
        }
    }
}

