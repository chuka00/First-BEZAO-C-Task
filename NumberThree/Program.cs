// See https://aka.ms/new-console-template for more information


    string appName = "Date Converter";
    string appVersion = "1.0.0";
    string appAuthor = "Chuka Victor Ogbodo";

    //Change the text color
    Console.ForegroundColor = ConsoleColor.Yellow;

    //write out app function
    Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

    //Reset Text color
    Console.ResetColor();


    
    Console.WriteLine("Kindly input a date using 'MM/DD/YY' Format");
    string inputDate = Console.ReadLine();


    DateTime result = DateTime.Parse(inputDate).AddDays(7);
    Console.WriteLine(result);



