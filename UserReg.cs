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
        public string validateLastNameusingLambda(string LastName) => Regex.IsMatch(LastName, RegexLastName) ? "valid" : "Ivalid";


    }
}