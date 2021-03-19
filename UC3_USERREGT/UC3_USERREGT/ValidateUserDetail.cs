using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC3_USERREGT
{
    public class ValidateUserDetail
    {

       
            public const string regexFirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
            public const string regexLastName = "^[A-Z]{1}[A-Za-z]{2,}$";
            public const string Regex_Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
            public bool validateFirstName(string FirstName)
            {
                return Regex.IsMatch(FirstName, regexFirstName);

            }
            public bool validateLastName(string LastName)
            {
                return Regex.IsMatch(LastName, regexLastName);
            }
            public bool ValidateEmail(string email)
            {
                return Regex.IsMatch(email, Regex_Email);
            }
        }
    }

   

