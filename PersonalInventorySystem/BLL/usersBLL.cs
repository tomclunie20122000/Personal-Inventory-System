using PersonalInventorySystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonalInventorySystem.BLL
{
    internal class usersBLL
    {

        userDAL udl = new userDAL();

        public Array getUserInfo(string currentUser)
        {
            try
            {
                return udl.loadUserInfo(currentUser);
            }
            catch
            {
                throw;
            }
        }


        // email

        public void updateEmailAddress(string email, string currentUser)
        {
            udl.updateEmail(email, currentUser);
        }        

        public bool emailExists(string email)
        {
            try
            {
                return udl.doesEmailExist(email);
            }
            catch
            {
                throw;
            }
        }

        public Match isEmailValid(string email)
        {            
            try
            {
                Regex rEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match emailMatch = rEmail.Match(email);
                return emailMatch;
            }
            catch
            {
                throw;
            }
        }

        // mobile
        public void updateMobileNumber(string mobile, string currentUser)
        {
            try
            {
                udl.updateMobile(mobile, currentUser);
            }
            catch
            {
                throw;
            }
        }

        public Match isMobileValid(string mobile)
        {
            try
            {
                Regex rMobile = new Regex("^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");
                Match mobileMatch = rMobile.Match(mobile);
                return mobileMatch;
            }
            catch
            {
                throw;
            }
        }

        // password
        public void updatePasswordInput(string password, string currentUser)
        {
            try
            {
                udl.updatePassword(password, currentUser);
            }
            catch
            {
                throw;
            }
        }

        public Match isPasswordValid(string password)
        {
            try
            {
                Regex rPassword = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@£$%^&*-]).{8,}$");
                Match passwordMatch = rPassword.Match(password);
                return passwordMatch;
            }
            catch
            {
                throw;
            }
        }


        // username


        public Match isUsernameValid(string username)
        {
            try
            {
                Regex rUsername = new Regex("^[A-Za-z][A-Za-z0-9_]{7,29}$");
                Match usernameMatch = rUsername.Match(username);
                return usernameMatch;
            }
            catch
            {
                throw;
            }
        }

        public bool usernameExists(string username)
        {
            try
            {
                return udl.doesUsernameExist(username);
            }
            catch
            {
                throw;
            }
        }

        public void registerUser(string u, string p, string e, string m, string d, DateTime date)
        {
            try
            {
                udl.registerUsers(u, p, e, m, d, date);
            }
            catch
            {
                throw;
            }
        }     
    }
}
