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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInventorySystem
{
    public partial class UserProfileForm : Form
    {
        public UserProfileForm()
        {
            InitializeComponent();
        }

        usersBLL ubl = new usersBLL();
        private string currentUser = LoginForm.currentUserID;


        private void load_data() //loads in user data
        {
            try
            {
                string[] userInfo = (string[])ubl.getUserInfo(currentUser);

                currentUsernameTxt.Text = userInfo[0];
                currentPasswordTxt.Text = userInfo[1];
                currentEmailTxt.Text = userInfo[2];
                currentMobileTxt.Text = userInfo[3];
                currentDobTxt.Text = userInfo[4];
                textBox1.Text = userInfo[5];
            }
            catch
            {
                MessageBox.Show("Error Loading in user data...");
            }                             
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            try
            {
                load_data();
            }
            catch
            {
                MessageBox.Show("Error Loading in user data...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ChangePasswordForm cpf = new ChangePasswordForm();
                cpf.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error loading password form...");
            }
        }

        private void newEmailBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeEmailForm cef = new ChangeEmailForm();
                cef.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error loading email form...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            { 
                ChangeUsernameForm cuf = new ChangeUsernameForm();
                cuf.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error loading username form...");
            }
        }

        private void changeMobileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeMobileForm cmf = new ChangeMobileForm();
                cmf.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error loading mobile form...");
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                load_data();
            }
            catch
            {
                MessageBox.Show("Error refreshing data...");            
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Error exiting application...");
            }
        }
    }
}
