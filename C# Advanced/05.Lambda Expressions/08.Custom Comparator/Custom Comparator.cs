using System;
using System.Collections.Generic;
using System.Linq;
namespace _08.Custom_Comparator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(numbers, new Comparator());
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
