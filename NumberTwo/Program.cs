// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;


Console.WriteLine("Kindly write a word or a phrase");
string source = Console.ReadLine();
string result = string.Concat(Regex
   .Matches(source, "[A-Z]")
   .OfType<Match>()
   .Select(match => match.Value));
List<int> list = new List<int>();
foreach ( char c in result)
{
    list.Add(source.IndexOf(c));
}
Console.WriteLine(result); 
Console.WriteLine(String.Join("\n", list));
