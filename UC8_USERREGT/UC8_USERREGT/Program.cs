using System;

namespace UC8_USERREGT
{
    class Program
    {
        static void Main(string[] args)
        {
         
          
                ValidateUserDetail regexValidation = new ValidateUserDetail();
                Console.WriteLine("Enter Your First Name");
                string FirstName = Console.ReadLine();
                Console.WriteLine(regexValidation.validateFirstName(FirstName));
                Console.WriteLine("Enter Your Last Name");
                string LastName = Console.ReadLine();
                Console.WriteLine(regexValidation.validateLastName(LastName));
                Console.WriteLine("Enter Your Email Address");
                string email = Console.ReadLine();
                Console.WriteLine(regexValidation.ValidateEmail(email));
                Console.WriteLine("Enter Your Mobile Number");
                string mobileNumber = Console.ReadLine();
                Console.WriteLine(regexValidation.ValidateMobile(mobileNumber));
                Console.WriteLine("Enter Your Password");
                string password = Console.ReadLine();
                Console.WriteLine(regexValidation.ValidatePassword(password));
            }
        }
    }

