using System;
using System.Linq;
using System.Text;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            StringBuilder reversedString = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedString.Append(str[i]);
            }
            Console.WriteLine(reversedString);
        }

    }
}
