using System;
using System.Collections.Generic;
using System.Linq;
namespace _09
{

    class Program
    {
        static void Main(string[] args)
        {
            int upperBound = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 1; i <= upperBound; i++)
            {
                numbers.Add(i);
            }
            int[] divisors = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (var divisor in divisors)
            {
                Predicates.AddPredicate(x => x % divisor == 0);
            }
            numbers = Predicates.ApplyPredicates(numbers);
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
