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
                Console.WriteLine("Valid e: " + email);
                return true;
            }
        }
    }
}
