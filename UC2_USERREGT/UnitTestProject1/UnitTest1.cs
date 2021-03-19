using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC2_USERREGT;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
    
        ValidateUserDetails validateUserDetails = new ValidateUserDetails();
        bool expectedResult = true;

        [TestMethod]
        public void Test_First_Name()
        {
               
            bool result = validateUserDetails.validateFirstName("Sarthak");

        
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]

        public void Test_Last_Name()
        {
           
            bool result = validateUserDetails.validateLastName("Sahoo");
            Assert.AreEqual(expectedResult, result);
        }
    }
}

