using System;
using System.Collections.Generic;
using System.Linq;
namespace _13.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(' ').ToList();
            foreach (var name in names)
            {
                int sum = name.Sum(s => s);
                Console.WriteLine(sum >= number);
            }

        }

    }
}
