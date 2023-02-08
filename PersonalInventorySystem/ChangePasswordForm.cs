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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        usersBLL ubl = new usersBLL();
        UserProfileForm upf = new UserProfileForm();
        private string currentUser = LoginForm.currentUserID;


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ubl.isPasswordValid(newpasstxt.Text).Success)
                {
                    ubl.updatePasswordInput(newpasstxt.Text, currentUser);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your password does not meet the format requirements...");
                }
            }
            catch
            {
                MessageBox.Show("Error updating password...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
