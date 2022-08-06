using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UsersRegistration
{
    public class Registration
    {
        public static string Name(string name)
        {
            //Regular Expression for Validation of First Name
            string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";

            Console.Write("\nEnter {0} Name :- ", name);
            string EnteredName = Console.ReadLine();

            //if Name Enter By User is match with Expression  then Valid if not Then Inva;id 
            return Regex.IsMatch(EnteredName, REGEX_FIRSTNAME) ? (name + "Name is Valid") : (name + " Name is Invalid");
        }
        public static string EmailAddress(string Email)
        {
            string REGEX_Email = "^([A-Za-z]){3,}([_.+-]{1}[0-9A-Za-z]{1,}){0,}@[a-z0-9]+[.](com|net|co){0,1}([.]((com )|([a-z]{2}){0,1})){0,1}$";
            Console.Write("\nEnter {0} :- ",Email);
            string EnteredEmail=Console.ReadLine();
            return Regex.IsMatch(EnteredEmail, REGEX_Email) ? (Email + " is Valid") : (Email + " is Invalid");
        }
    }
}
