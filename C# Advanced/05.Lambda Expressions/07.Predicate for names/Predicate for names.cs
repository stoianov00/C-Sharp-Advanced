using System;
using System.Linq;
namespace _07.Predicate_for_names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthRange = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ');

            var result = names.Where(l => l.Length <= lengthRange);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }
    }
}
