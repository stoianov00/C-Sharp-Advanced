using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];

            Queue<int> result = new Queue<int>();

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            foreach (var number in numbers)
            {
                result.Enqueue(number);
            }

            for (int i = 0; i < s; i++)
            {
                result.Dequeue();
            }

            if (result.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (result.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(result.Min()); // print Min value from queue
                }
            }


        }
    }
}
