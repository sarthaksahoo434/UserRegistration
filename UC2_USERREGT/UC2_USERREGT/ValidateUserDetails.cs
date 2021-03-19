using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC2_USERREGT
{
   public class ValidateUserDetails
    {
        public const string regexFirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string regexLastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        
        public bool validateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, regexFirstName);
           
        }
        public bool validateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, regexLastName);
        }
        
    }
}

