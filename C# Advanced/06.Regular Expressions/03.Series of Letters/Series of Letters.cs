using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.Series_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "aaaaabbbbbcdddeeeedssaa";
            List<char> result = new List<char>();

            foreach (var ch in text)
            {
                result.Add(ch);
            }
            Console.WriteLine(string.Join("", result.Distinct()));

        }
    }
}
