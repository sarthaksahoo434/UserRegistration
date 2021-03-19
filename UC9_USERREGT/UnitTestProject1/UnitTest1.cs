using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC9_USERREGT;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Arrange
        ValidateUserDetail validateUserDetails = new ValidateUserDetail();
        bool expectedResult = true;

        [TestMethod]
        public void Test_First_Name()
        {
            //Act        
            bool result = validateUserDetails.validateFirstName("Sarthak");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]

        public void Test_Last_Name()
        {
            //Act
            bool result = validateUserDetails.validateLastName("Sahoo");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]

        public void Test_Email()
        {
            //Act
            bool result = validateUserDetails.ValidateEmail("cdf.xyz@bl.co.in");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_Phone_Number()
        {
            //Act
            bool result = validateUserDetails.ValidateMobile("91 8917219415");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        public void Test_Password()
        {
            //Act
            bool result = validateUserDetails.ValidatePassword("Sarthak1");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }


    }
}
