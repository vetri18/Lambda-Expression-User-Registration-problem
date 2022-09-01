using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_24_LambdaExp_UserRegistration
{
    public class UserValidation
    {   //intit Instance Variables
        public static string FirstName;
        public static string LastName;
        public static string Email_Id;
        public static string MobileNo;
        public static string Password;
        private static string pattern;

        //User Validation Method
        public static void User_Validation()
        {
            Console.Write("> Enter the First Name of User :- ");
            FirstName = Console.ReadLine();
            Validate_FirstName(FirstName);
            Console.Write("---------------------------------\n");
            Console.Write("> Enter the Last Name of User :- ");
            LastName = Console.ReadLine();
            Validate_LastName(LastName);
            Console.Write("---------------------------------\n");
            Console.Write("> Enter the Mobile Number of User :- ");
            MobileNo = Console.ReadLine();
            Validate_MobileNo(MobileNo);
            Console.Write("---------------------------------\n");
            Console.Write("> Enter the Email ID of User :- ");
            Email_Id = Console.ReadLine();
            Validate_EmailId(Email_Id);
            Console.Write("---------------------------------\n");
            Console.Write("> Enter the Password of User :- ");
            Password = Console.ReadLine();
            Validate_Password(Password);
        }

        //TO validate FirstName
        public static string Validate_FirstName(string FirstName_input)
        {
            Regex Pattern = new Regex("^[A-Z][A-Za-z]{2,20}$");
            bool res = Pattern.IsMatch(FirstName_input);
            if (res)
            {
                //Console.WriteLine("\n> First Name Valid...");
                //return FirstName_input;
                return "Valid";
            }
            else
            {
                //Console.WriteLine("\n> First Name Invalid!!");
                //return default;
                return "Invalid";
            }

        }
        //TO validate LastName
        public static string Validate_LastName(string LastName_input)
        {
            Regex Pattern = new Regex("^[A-Z][A-Za-z]{2,20}$");
            bool res = Pattern.IsMatch(LastName_input);
            if (res)
            {
                //Console.WriteLine("\n> Last Name Valid...");
                //return LastName_input;
                return "Valid";
            }
            else
            {
                //Console.WriteLine("\n> Last Name Invalid!!");
                //return default;
                return "Invalid";
            }

        }
        //TO validate Mobile Number
        public static string Validate_MobileNo(string MobileNo_input)
        {
            Regex Pattern = new Regex("^[1-9]{2} [6-9]{1}[0-9]{9}$");
            bool res = Pattern.IsMatch(MobileNo_input);
            if (res)
            {
                //Console.WriteLine("\n> Mobile Number Valid...");
                //return MobileNo_input;
                return "Valid";
            }
            else
            {
                //Console.WriteLine("\n> Mobile Number Invalid!!");
                //return default;
                return "Invalid";
            }

        }
        //TO validate Email ID
        public static string Validate_EmailId(string EmailId_input)
        {
            Regex Pattern = new Regex("^([A-Za-z0-9]{3,20})([.+-_*][A-Za-z0-9]{1,10})*([@][A-Za-z]{1,5})+[.][A-Za-z]{2,3}([.][A-Za-z]{2,3})?$");
            bool res = Pattern.IsMatch(EmailId_input);
            if (res)
            {
                //Console.WriteLine("\n> Email Id Valid...");
                //return EmailId_input;
                return "Valid";
            }
            else
            {
                //Console.WriteLine("\n> Email Id Invalid!!");
                //return default;
                return "Invalid";
            }

        }
        //TO validate Password
        public static string Validate_Password(string Password_input)
        {
            Regex Pattern = new Regex("(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$_])[a-zA-Z0-9@#$_]{8}");
            bool res = Pattern.IsMatch(Password_input);
            if (res)
            {
                //Console.WriteLine("\n> Password Valid...");
                //return Password_input;
                return "Valid";
            }
            else
            {
                //Console.WriteLine("\n> Password Invalid!!");
                //return default;
                return "Invalid";
            }

        }


    }
}