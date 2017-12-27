using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Stack_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> result = new Stack<int>();

            int a = 0;
            int b = 1;
            int c;

            for (int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                result.Push(b);
            }
            Console.WriteLine(result.Pop());
            
        }
    }
}
