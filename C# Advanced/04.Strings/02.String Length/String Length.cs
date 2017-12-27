using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.String_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length < 20)
            {
                Console.Write(input.PadRight(20, '*'));
            }
            else
            {
                Console.WriteLine(input);
            }


        }
    }
}
