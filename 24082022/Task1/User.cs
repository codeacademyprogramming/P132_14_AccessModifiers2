using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class User
    {
        private string _userName;
        private string _password;

        public string UserName
        {
            get { return _userName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && (value.Length >= 6 && value.Length <= 25))
                    _userName = value;
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (_checkPassword(value))
                    _password = value;
            }
        }

        private bool _checkPassword(string pass)
        {

            if (!string.IsNullOrWhiteSpace(pass) && (pass.Length >= 8 && pass.Length <= 25))
            {
                bool hasDigit = false;
                bool hasUpper = false;
                bool hasLower = false;

                for (int i = 0; i < pass.Length; i++)
                {
                    if ( !hasDigit &&  char.IsDigit(pass[i]))
                        hasDigit = true;

                    else if ( !hasUpper && char.IsUpper(pass[i]))
                        hasUpper = true;

                    else if (!hasLower && char.IsLower(pass[i]))
                        hasLower = true;

                    if (hasDigit && hasUpper && hasLower)
                        return true;

                }

            }
            return false;
        }



    }
}
