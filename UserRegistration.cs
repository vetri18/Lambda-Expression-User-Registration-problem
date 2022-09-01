using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class UserRegistration
    {
        //UC1
        string Firstname = @"[A-Z]{1}[a-z]{2}$";
        public string FirstnameCheckusingLambda(string firstName) => Regex.IsMatch(firstName, Firstname) ? "FirstName is Valid" : "FirstName is not Valid";



        //UC2
        static string RegexLastName = "^[A-Z]{1,}[a-z]{3,}$";
        public string validateLastNameusingLambda(string LastName) => Regex.IsMatch(LastName, RegexLastName) ? "Valid" : "Ivalid";


        //UC3
        static string RegexEmail = "^[0-9a-zA-Z]+([+#%&_.][a-zA-Z0-9]+)*[@]{1}[a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public string validateEmailusingLambda(string Email) => Regex.IsMatch(Email, RegexEmail) ? "valid" : "Invalid";


        //UC4
        static string RegexMobileNumber = "^[1-9]{2}[6-9]{1}[0-9]{9}$";
        public string validateMobileNumberusingLambda(string MobileNumber) => Regex.IsMatch(MobileNumber, RegexMobileNumber) ? "valid" : "Invalid";


        //UC5
        public static string RegexPassword = "^[a-zA-Z]{8,}$";
        public string validatePasswordusingLambda(string Password) => Regex.IsMatch(Password, RegexPassword) ? "valid" : "Invalid";

        //UC6
        public static string RegexPassword6 = "^[A-Z]{1,}[a-z]{7,}$";
        public string validatePassword6usingLambda(string Password6) => Regex.IsMatch(Password6, RegexPassword6) ? "valid" : "Invalid";

        //UC7
        public static string RegexPassword7 = "^[A-Z]{1,}[a-z]{5,}[0-9]{1,}$";
        public string validatePassword7usingLambda(string Password7) => Regex.IsMatch(Password7, RegexPassword7) ? "valid" : "Invalid";


        //UC8
        public static string RegexPassword8 = "^[A-Z]{1,}[a-z]{5,}[0-9]{1,}[@#&*]{1}$";
        public string validatePassword8usinglambda(string Password8) => Regex.IsMatch(Password8, RegexPassword8) ? "valid" : "Invalid";

        //UC9
        public static string RegexEmail9 = "^[0-9a-zA-Z]+([+#%&_.-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{3}([.][a-zA-Z]{2,3})?$";
        public string validateEmail9usingLambda(string Email9) => Regex.IsMatch(Email9, RegexEmail9) ? "valid" : "Invalid";

    }
}