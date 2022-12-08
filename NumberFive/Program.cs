using NumberSix;

string appName = "Authentication system scope";
string appVersion = "1.0.0";
string appAuthor = "Chuka Victor Ogbodo";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
Console.ResetColor();

RegisterOrlogin register = new RegisterOrlogin();
register.start();


/*var userNames = new List<string> { };
var passWords = new List<string> { };


void Welcome()
{
    Console.WriteLine("Kindly type 'Register' to Sign Up or 'Login' to Sign In");
    string answer = Console.ReadLine().ToLower();
    if (answer == "register")
    {
        Register();
    }
    else if (answer == "login")
    {

        Login();
    }
}


 void Register()
{

    Console.WriteLine("kindly put in your preferred UserName");
    string userInput = Console.ReadLine();
    userNames.Add(userInput);
    Console.WriteLine($"Hello {userInput}, Kindly set your password");
    var userPassword = Console.ReadLine();
    Console.WriteLine("Password has been set");
    passWords.Add(userPassword);
    Exit();
}

void Login()
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
    Exit();
}

void Exit()
{
    Console.WriteLine("Want to exit\nY or N");
    var exitOption = Console.ReadLine().ToUpper();
    if (exitOption == "Y")
    {
        Environment.Exit(10);
    }
    else if (exitOption == "N")
    {
        Welcome();
    }
}*/
