using Day_24_LambdaExp_UserRegistration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JUnit_Test
{
    [TestClass]
    public class UnitTest1
    {
        public UserValidation userValidation;

        //validation for first Name
        [TestMethod]
        [DataRow("Ganesh", "Valid")]
        [DataRow("Ra", "Invalid")]
        [DataRow("Ganesh001", "Invalid")]
        [DataRow("1234", "Invalid")]
        public void ValidateFirstname(string input, string expected)
        {
            var actual = UserValidation.Validate_FirstName(input);
            Assert.AreEqual(expected, actual);
        }

        //validation for Last Name
        [TestMethod]
        [DataRow("Potdar", "Valid")]
        [DataRow("Po", "Invalid")]
        [DataRow("potdar", "Invalid")]
        [DataRow("1234", "Invalid")]
        public void Validate_LastName(string input, string expected)
        {
            var actual = UserValidation.Validate_FirstName(input);
            Assert.AreEqual(expected, actual);
        }

        //validation for Mobile No
        [TestMethod]
        [DataRow("91 9511949586", "Valid")]
        [DataRow("919511949586", "Invalid")]
        [DataRow("92 7741891991", "Valid")]
        [DataRow("9918919919", "Invalid")]
        public void Validate_MobileNo(string input, string expected)
        {
            var actual = UserValidation.Validate_MobileNo(input);
            Assert.AreEqual(expected, actual);
        }

        //validation for Email ID
        [TestMethod]
        [DataRow("abc.Xyz@gmail.com", "Valid")]
        [DataRow("ABC.Xyz@gmail.com.co", "Valid")]
        [DataRow("abcXyz324@Gmail.com.in", "Valid")]
        [DataRow("abc.Xyz@gmail212.com", "Invalid")]
        public void Validate_EmailId(string input, string expected)
        {
            var actual = UserValidation.Validate_EmailId(input);
            Assert.AreEqual(expected, actual);
        }

        //validation for Password
        [TestMethod]
        [DataRow("Ganesh@12233", "Valid")]
        [DataRow("Ganesh@@212", "Valid")]
        [DataRow("abc@123", "Invalid")]
        [DataRow("abcXyz@1233", "Valid")]
        public void Validate_Password(string input, string expected)
        {
            var actual = UserValidation.Validate_Password(input);
            Assert.AreEqual(expected, actual);
        }

    }
}