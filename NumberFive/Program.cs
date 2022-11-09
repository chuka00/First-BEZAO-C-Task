// See https://aka.ms/new-console-template for more information


string appName = "Authentication system scope";
string appVersion = "1.0.0";
string appAuthor = "Chuka Victor Ogbodo";

//Change the text color
Console.ForegroundColor = ConsoleColor.Yellow;

//write out app function
Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

//Reset Text color
Console.ResetColor();

var userNames = new List<string> { };
var passWords = new List<string> { };

while (true)
{
    Console.WriteLine("Kindly type 'Register' to Sign Up or 'Login' to Sign In");
    string answer = Console.ReadLine();
    if (answer == "Register" || answer == "register")
    {
        Console.WriteLine("kindly put in your preferred UserName");
        string userInput = Console.ReadLine();
        userNames.Add(userInput);
        Console.WriteLine($"Hello {userInput}, Kindly set your password");
        var userPassword = Console.ReadLine();
        Console.WriteLine("Password has been set");
        passWords.Add(userPassword);
    }
    else if (answer == "Login" || answer == "login")
    {
        Console.WriteLine("Welcome Back");
        Console.WriteLine($"Hi Kindly put in your password");
        var password = Console.ReadLine();
        if (password == passWords[0])
        {
            Console.WriteLine("Password is correct");
        }
        else
        {
            Console.WriteLine("Error!");
        }
        break;
    }
}
