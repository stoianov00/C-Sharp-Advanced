using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            BigInteger num2 = BigInteger.Parse(Console.ReadLine());
            BigInteger total = num1 + num2;

            Console.WriteLine("{0}", total);
        }
    }
}
