using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC1_USERREGT
{
  public  class ValidateUserDetail
    {
        public const string regexFirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool validateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, regexFirstName);
        }
    }
}
