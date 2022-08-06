using UsersRegistration;
using System;

Console.WriteLine("\t\t\t\t######################################################");
Console.WriteLine("\t\t\t\t\tWELCOME TO USERS REGISTRATION PROBLEM");
Console.WriteLine("\t\t\t\t######################################################");
int Choice;

do
{
    Console.WriteLine("\n0.Exit");
    Console.WriteLine("1.Enter a Valid First Name Start with upper case & Min. 3 Characters ");
    Console.WriteLine("2.Enter a Valid Last Name Start with upper case & Min. 3 Characters ");
    Console.WriteLine("3.Enter a Valid Email Address E.g.- abc.xyz@bl.co.in");
    Console.WriteLine("4.Enter a valid Mobile Format E.g.-91 9989218789  ");
    Console.WriteLine("5.Enter a Valid Password Rules Minimum 8 Characters");
    
    // Taking Input From User to Execute Question
    Console.Write("\nPlease Enter Question Number :- ");
    Choice=Convert.ToInt32(Console.ReadLine());

    switch (Choice)
    {
        case 1:
            Console.WriteLine(Registration.Name("First"));
            break;
        case 2:
             Console.WriteLine(Registration.Name("Last"));
            break;
        case 3:
            Console.WriteLine(Registration.EmailAddress("Email Address"));
            break;
        case 4:
            Registration.MobileFormat();
            break;
        case 5:
            Registration.Password1();
            break;
        default:
            Console.WriteLine("Please Enter Correct Question Number");
            break;
    }

}
while (Choice != 0);
Console.ReadKey();