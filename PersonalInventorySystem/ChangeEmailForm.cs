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
    public partial class ChangeEmailForm : Form
    {
        public ChangeEmailForm()
        {
            InitializeComponent();
        }
        usersBLL ubl = new usersBLL();
        private string currentUser = LoginForm.currentUserID;


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ubl.isEmailValid(newemailtxt.Text).Success)
                {
                    ubl.updateEmailAddress(newemailtxt.Text, currentUser);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your email does not meet the format requirements...");
                }
            }
            catch
            {
                MessageBox.Show("Error updating email address...");
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
