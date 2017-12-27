using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _14.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            double result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currentElem = input[i];
                char firstChar = currentElem[0];
                char lastChar = currentElem[currentElem.Length - 1];

                double getNumbers = double.Parse(currentElem.Substring(1, currentElem.Length - 2));
                int alphabetPosition = firstChar % 32;
                
                if (char.IsLower(firstChar))
                {
                    getNumbers *= alphabetPosition;
                }
                else
                {
                    getNumbers /= alphabetPosition;
                }
                alphabetPosition = lastChar % 32;

                if (char.IsLower(lastChar))
                {
                    getNumbers += alphabetPosition;
                }
                else
                {
                    getNumbers -= alphabetPosition;
                }
                result += getNumbers;
            }
            Console.WriteLine("{0:F2}", result);         
        }
    }
}
