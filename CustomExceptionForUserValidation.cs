using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_24_LambdaExp_UserRegistration
{
    public class CustomException_For_UserValidation : Exception
    {
        private ExceptionType type;
        public enum ExceptionType
        {  //   enum for excpetion type
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            INVALID_MESSAGE
        }

        public CustomException_For_UserValidation(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}