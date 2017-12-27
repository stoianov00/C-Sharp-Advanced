using System;
using System.Text.RegularExpressions;
namespace _05.Extract_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"([\w-.]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(text);

            foreach (var match in matches)
            {
                string matchToString = match.ToString();
                if (!(matchToString.StartsWith("-") ||
                      matchToString.StartsWith("_") ||
                      matchToString.StartsWith(".") ||
                      matchToString.EndsWith("-") ||
                      matchToString.EndsWith("_") ||
                      matchToString.EndsWith(".")
                ))
                {
                    Console.WriteLine(matchToString);
                }
            }
            
        }
    }
}
