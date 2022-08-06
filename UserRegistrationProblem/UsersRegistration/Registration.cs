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
        // Method for Validation First & Last Name
        public static string Name(string name)
        {
            string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";

            Console.Write("\nEnter {0} Name :- ", name);
            string EnteredName = Console.ReadLine();

            //if Name Enter By User is match with Expression  then Valid if not Then Inva;id 
            return Regex.IsMatch(EnteredName, REGEX_FIRSTNAME) ? (name + "Name is Valid") : (name + " Name is Invalid");
        }
        // Method for Validation of Email Address
        public static string EmailAddress(string Email)
        {
            string REGEX_Email = "^([A-Za-z]){3,}([_.+-]{1}[0-9A-Za-z]{1,}){0,}@[a-z0-9]+[.](com|net|co){0,1}([.]((com )|([a-z]{2}){0,1})){0,1}$";
            Console.Write("\nEnter {0} :- ",Email);
            string EnteredEmail=Console.ReadLine();
            return Regex.IsMatch(EnteredEmail, REGEX_Email) ? (Email + " is Valid") : (Email + " is Invalid");
        }
        // Method for Validation Of Mobile Format
        public static void MobileFormat()
        {
            Console.Write("\nEnter Mobile number with country code: ");
            var MobileNo = Console.ReadLine();
            string PhoneNo = "^[91]{2}[\\s][6-9][0-9]{9}$";
            Regex regex4 = new Regex(PhoneNo);
            if (regex4.IsMatch(MobileNo))
            {
                Console.WriteLine("Mobile number is valid");
            }
            else
            {
                Console.WriteLine("Mobile number is Invalid!!");
            }
        }
    }
}
