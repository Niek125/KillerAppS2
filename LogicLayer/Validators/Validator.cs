﻿using ModelLayer.General_Interfaces;
using ModelLayer.Structural_Interfaces;
using System.Net.Mail;

namespace LogicLayer.LogInValidator
{
    internal class Validator : IUserValidator
    {
        internal Validator()
        {

        }

        public LogInResult ValidateUser(string _passWord, IUserWithPassWord _user)
        {
            if (_user.UserName == string.Empty)
            {
                return LogInResult.UserName;
            }
            if (_passWord != _user.PassWord)
            {
                return LogInResult.PassWord;
            }
            return LogInResult.Good;
        }

        public bool ValidateEMailAddress(string _email)
        {
            try
            {
                MailAddress mail = new MailAddress(_email);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
