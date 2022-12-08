using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSix
{
    internal class LibraryApplication
    {
        public void Library()
        {
            startover:
            string appName = "Library Management System";
            string appVersion = "1.0.0";
            string appAuthor = "Chuka Victor Ogbodo";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();


            Console.WriteLine("Welcome kindly input your name");
            string user = Console.ReadLine().ToUpper();
            Console.WriteLine($"Hey {user}");

            Console.WriteLine("We have a selection of books, kindly type 'next' to carry on");
            string nextStep = Console.ReadLine().ToLower();
            if (nextStep == "next")
            {
                Console.WriteLine("List of books available");
            }
            else
            {
                Console.WriteLine("Wrong input please try again");
                goto startover;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            resume:
            Console.WriteLine(" c: for C# books,  o: for .NET core books, d: for clean codng books, e: for EFcore");
            Console.ResetColor();
            Console.WriteLine("Kindly put in your selection");
            string option;
            option = Console.ReadLine().ToLower();

            switch (option)
            {
                case "c":
                    Console.WriteLine("C# books");
                    break;
                case "o":
                    Console.WriteLine(".NET core books");
                    break;
                case "d":
                    Console.WriteLine("clean codng books");
                    break;
                case "e":
                    Console.WriteLine("EFcore");
                    break;
                default:
                    Console.WriteLine("Not Valid Try Again");
                    goto resume;
                    
                    
            }

            Console.WriteLine("Want to Exit?\nY or N?");
            var response = Console.ReadLine().ToUpper();
            if (response == "Y")
            {
                Environment.Exit(1);
            }
            else if (response == "N")
            {
                Library();
            }
        }


    }
}
