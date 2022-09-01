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
        [DataRow("Ganesh", "Valid First Name...")]
        [DataRow("Ra", "Invalid First Name!!")]
        [DataRow(null, "First Name Can not be Null!!")]
        [DataRow("", "First Name can not be Empty!!")]
        public void ValidateFirstname(string input, string expected)
        {
            try
            {
                var actual = UserValidation.Validate_FirstName(input);
            }
            catch (CustomException_For_UserValidation e)
            {
                Assert.AreEqual(expected, e.Message);
            }

        }

        //validation for Last Name
        [TestMethod]
        [DataRow("Potdar", "Valid Last Name...")]
        [DataRow("dr", "Invalid Last Name!!")]
        [DataRow(null, "Last Name Can not be Null!!")]
        [DataRow("", "Last Name can not be Empty!!")]
        public void Validate_LastName(string input, string expected)
        {
            try
            {
                var actual = UserValidation.Validate_LastName(input);
            }
            catch (CustomException_For_UserValidation e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        //validation for Mobile No
        [TestMethod]
        [DataRow("91 9511949586", "Invalid Mobile Number !!")]
        [DataRow("919511949586", "Invalid Mobile Number !!")]
        [DataRow("", "Mobile Number can not be Empty!!")]
        [DataRow(null, "Mobile Number Can not be Null!!")]
        public void Validate_MobileNo(string input, string expected)
        {
            try
            {
                var actual = UserValidation.Validate_MobileNo(input);
            }
            catch (CustomException_For_UserValidation e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        //validation for Email ID
        [TestMethod]
        [DataRow(null, "Email ID Can not be Null!!")]
        [DataRow("", "Email ID can not be Empty!!")]
        [DataRow("abcXyz324@Gmail.com.in", "Valid Email ID...")]
        [DataRow("abc.Xyz@@Gmail212.com", "Invalid Email ID!!")]
        public void Validate_EmailId(string input, string expected)
        {
            try
            {
                var actual = UserValidation.Validate_EmailId(input);
            }
            catch (CustomException_For_UserValidation e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        //validation for Password
        [TestMethod]
        [DataRow("Ganesh@1234", "Valid Password...")]
        [DataRow("", "Password can not be Empty!!")]
        [DataRow("abc@123", "Invalid Password!!")]
        [DataRow(null, "Password Can not be Null!!")]
        public void Validate_Password(string input, string expected)
        {
            try
            {
                var actual = UserValidation.Validate_Password(input);
            }
            catch (CustomException_For_UserValidation e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

    }
}