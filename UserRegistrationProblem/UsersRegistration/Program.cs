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
    Console.WriteLine("6.Enter a Valid Password Rules at Least One uppercase");
    Console.WriteLine("7.Enter a Valid Password Rules at Least one numeric Number");
    Console.WriteLine("8.Enter a Valid Password Rules at Least One Special Character");
    Console.WriteLine("9.Check Email Sample Provided Separately");
    
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
        case 6:
            Registration.Password2();
            break;
        case 7:
            Registration.Password3();
            break;
        case 8:
            Registration.Password4();
            break;
        case 9:
            Registration.TestEmail();
            break;
        default:
            Console.WriteLine("Please Enter Correct Question Number");
            break;
    }

}
while (Choice != 0);
Console.ReadKey();