using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Recursive_Fibonacci
{
    class Program
    {
        static long[] numbers;

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            numbers = new long[number + 2];
            numbers[1] = 1;
            numbers[2] = 1;
            long result = Fibonacci(number);
            Console.WriteLine(result);
        }

        private static long Fibonacci(int n)
        {
            if(0 == numbers[n])
            {
                numbers[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            return numbers[n];
        }
    }
}
