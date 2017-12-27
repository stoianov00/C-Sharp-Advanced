using System;
using System.Text.RegularExpressions;
namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\+\d+(\s|-)\d\1\d{3}\1\d{4}\b";
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
