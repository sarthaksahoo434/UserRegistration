using System;

namespace UC2_USERREGT
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateUserDetails regexValidation = new ValidateUserDetails();
            Console.WriteLine("Enter Your First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine(regexValidation.validateFirstName(FirstName));
            Console.WriteLine("Enter Your Last Name");
            string LastName = Console.ReadLine();
            Console.WriteLine(regexValidation.validateLastName(LastName));

        }


    }
    }

