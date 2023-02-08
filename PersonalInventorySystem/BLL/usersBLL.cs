using PersonalInventorySystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            return udl.loadUserInfo(currentUser);
        }

        public bool usernameExists(string username)
        {
            return udl.doesUsernameExist(username);
        }

        public bool emailExists(string email)
        {
            return udl.doesEmailExist(email);
        }

        public Match isEmailValid(string email)
        {            
            Regex rEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match emailMatch = rEmail.Match(email);
            return emailMatch;
        }

        public Match isMobileValid(string mobile)
        {
            Regex rMobile = new Regex("^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");
            Match mobileMatch = rMobile.Match(mobile);
            return mobileMatch;
        }
        public Match isPasswordValid(string password)
        {
            Regex rPassword = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            Match passwordMatch = rPassword.Match(password);
            return passwordMatch;
        }
        public Match isUsernameValid(string username)
        {
            Regex rUsername = new Regex("^[A-Za-z][A-Za-z0-9_]{7,29}$");
            Match usernameMatch = rUsername.Match(username);
            return usernameMatch;
        }

        public void registerUser(string u, string p, string e, string m, string d, DateTime date)
        {
            udl.registerUsers(u, p, e, m, d, date);
        }     
    }
}
