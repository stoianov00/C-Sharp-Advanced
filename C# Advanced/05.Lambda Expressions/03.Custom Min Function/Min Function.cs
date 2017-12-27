using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Func<List<int>, int> resultAsFunc = PrintSmallestNumberFromCollection;

            var result = resultAsFunc(input);
            Console.WriteLine(result);
        }

        private static int PrintSmallestNumberFromCollection(List<int> numbers)
        {
            return numbers.Min();
        }

    }
}
