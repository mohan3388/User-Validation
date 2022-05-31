using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Validation
    {
        public const string Name_Pattern = "^[A-Z]{1}[A-Za-z]{3,}$";
        public const string Email_Pattern = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public const string Mobile_Pattern = "^[91]{2}/s[0-9]{10}$";
        public const string Password_Min_8Char = "^[0-9a-zA-Z]{8,}$";
        public const string Password_Include_UpperCase = "^[A-Z]{1}0-9a-zA-Z]{7,}";

        public bool ValidName(string name)
        {
            if (Regex.IsMatch(name, Name_Pattern)) ;
            {
                Console.WriteLine("Valid name: " + name);
                return true;
            }
        }
        public bool ValidLastName(string lastname)
        {
            if (Regex.IsMatch(lastname, Name_Pattern)) ;
            {
                Console.WriteLine("Valid name: " + lastname);
                return true;
            }
        }
        public bool ValidEmail(string email)
        {
            if (Regex.IsMatch(email, Email_Pattern)) ;
            {
                Console.WriteLine("Valid email: " + email);
                return true;
            }
        }
        public bool ValidMobile(string mobile)
        {
            if (Regex.IsMatch(mobile, Mobile_Pattern)) ;
            {
                Console.WriteLine("Valid mobile: " + mobile);
                return true;
            }
        }
        public bool ValidPasswordMinChar(string password)
        {
            if (Regex.IsMatch(password, Password_Min_8Char)) ;
            {
                Console.WriteLine("Valid password: " + password);
                return true;
            }
        }
        public bool ValidPasswordIncludeUpperCase(string password)
        {
            if (Regex.IsMatch(password, Password_Include_UpperCase)) ;
            {
                Console.WriteLine("Valid password Include Uppercase: " + password);
                return true;
            }
        }
    }
}
