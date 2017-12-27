using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string str1 = input[0];
            string str2 = input[1];

            int minLen = Math.Min(str1.Length, str2.Length);
            int maxLen = Math.Max(str1.Length, str2.Length);
            int sum = 0;

            for (int i = 0; i < minLen; i++)
            {
                sum += MultiplyCharsASCII(str1[i], str2[i]);
            }

            if (str1.Length != str2.Length)
            {
                string longerInput = str1.Length > str2.Length ? str1 : str2;
                for (int i = minLen; i < maxLen; i++)
                {
                    sum += longerInput[i];
                }
            }
            Console.WriteLine(sum);
        }

        private static int MultiplyCharsASCII(char let1, char let2)
        {
            int multiply = let1 * let2;
            return multiply;
        }

    }
}
