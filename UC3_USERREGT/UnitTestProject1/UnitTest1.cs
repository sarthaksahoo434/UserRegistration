using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC3_USERREGT;
namespace UnitTestProject1
{
    public class UnitTest1
    {

        ValidateUserDetail validateUserDetails = new ValidateUserDetail();
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

        [TestMethod]

        public void Test_Email()
        {
         
            bool result = validateUserDetails.ValidateEmail("cdf.xyz@bl.co.in");

            Assert.AreEqual(expectedResult, result);
        }
    }
}