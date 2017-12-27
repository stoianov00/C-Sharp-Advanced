using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.Reverse_and_exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            // 20 10 40 30 60 50
            // 3

            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int divisible = int.Parse(Console.ReadLine());

            var res = new List<int>();
            
            foreach (var item in input)
            {
                if (item % divisible == 1)
                {
                   res.Add(item);
                }
            }

            for (int i = res.Count - 1; i >= 0; i--)
            {
                Console.Write(res[i]);
            }
        
        }
    }
}
