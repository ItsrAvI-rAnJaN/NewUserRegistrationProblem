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
    Console.WriteLine("1.Enter a Valid Last Name Start with upper case & Min. 3 Characters ");
    
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
        default:
            Console.WriteLine("Please Enter Correct Question Number");
            break;
    }

}
while (Choice != 0);
Console.ReadKey();