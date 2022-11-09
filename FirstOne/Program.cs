// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a word or Phrase");
var input = Console.ReadLine();
var new_string = "";


for (var i = 0; i < input.Length - 2; i++)
    new_string += "#";

new_string += input.Substring(input.Length - 4);
Console.WriteLine(new_string);