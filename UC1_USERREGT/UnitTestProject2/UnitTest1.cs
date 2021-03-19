using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC1_USERREGT;

namespace UserRegistrationUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        ValidateUserDetail validateUserDetails = new ValidateUserDetail();

        [TestMethod]
        public void validateFirstName()
        {
            bool expectedResult = true;
            bool result = validateUserDetails.validateFirstName("Sarthak");
            Assert.AreEqual(expectedResult, result);
        }
    }
}

