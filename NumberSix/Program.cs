// See https://aka.ms/new-console-template for more information


string appName = "Library Management System";
string appVersion = "1.0.0";
string appAuthor = "Chuka Victor Ogbodo";

//Change the text color
Console.ForegroundColor = ConsoleColor.Yellow;

//write out app function
Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

//Reset Text color
Console.ResetColor();

while (true)
{

    Console.WriteLine("Welcome kindly input your name");
    string user = Console.ReadLine();
    Console.WriteLine($"Hey {user}");

    Console.WriteLine("We have a selection of books, kindly type 'continue' to carry on");
    string nextStep = Console.ReadLine().ToLower();
    if (nextStep == "continue" || nextStep == "Continue")
    {
        Console.WriteLine("List of books available");
    }
    else
    {
        Console.WriteLine("Wrong input please try again");
        break;
    }
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" C: for C# books,  o: for .NET core books, d: for clean codng books, e: for EFcore");
    Console.ResetColor();
    Console.WriteLine("Kindly put in your selection");
    string option;
    option = Console.ReadLine();

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
            break;
    }
    break;
}

