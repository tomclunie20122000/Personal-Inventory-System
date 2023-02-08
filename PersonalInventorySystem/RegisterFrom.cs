using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Threading;
using System.Security.Policy;
using PersonalInventorySystem.BLL;

namespace PersonalInventorySystem
{
    public partial class RegisterFrom : Form
    {
        public RegisterFrom()
        {
            InitializeComponent();
        }

        usersBLL ubl = new usersBLL();

        private void registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime oldEnough = DateTime.Today.AddYears(-18);

                //If conditions so it looks nicer
                bool inputMatch = ubl.isEmailValid(emailtxt.Text).Success
                    && ubl.isMobileValid(mobiletxt.Text).Success
                    && ubl.isPasswordValid(passtxt.Text).Success
                    && ubl.isUsernameValid(usertxt.Text).Success;

                bool ageOk = dobtxt.Value < DateTime.Today && dobtxt.Value < oldEnough;

                bool notNull = !String.IsNullOrEmpty(usertxt.Text)
                    && !String.IsNullOrEmpty(passtxt.Text)
                    && !String.IsNullOrEmpty(emailtxt.Text)
                    && !String.IsNullOrEmpty(mobiletxt.Text);

                if (inputMatch && ageOk && notNull)
                {
                    ubl.registerUser(usertxt.Text, passtxt.Text, emailtxt.Text, mobiletxt.Text, dobtxt.Text, DateTime.Today);
                    this.Hide();
                    MessageBox.Show("Account Created Succesfully...");
                }
                else
                {
                    MessageBox.Show("Error - data invalid!");
                }
            }
            catch
            {
                MessageBox.Show("Error registering User...");
            }
            
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
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
