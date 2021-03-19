using System;

namespace UC1_USERREGT
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateUserDetail regexValidation = new ValidateUserDetail();
            Console.WriteLine("Enter Your First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine(regexValidation.validateFirstName(FirstName));
        }
    }
}
