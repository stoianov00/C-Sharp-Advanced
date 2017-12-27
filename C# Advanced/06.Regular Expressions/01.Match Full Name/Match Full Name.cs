using System;
using System.Text.RegularExpressions;
namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);

            while (text != "end")
            {
                foreach (Match m in Regex.Matches(text, pattern))
                {
                    Console.WriteLine(m.Groups[0]);
                }

                text = Console.ReadLine();
            }

        }
    }
}
