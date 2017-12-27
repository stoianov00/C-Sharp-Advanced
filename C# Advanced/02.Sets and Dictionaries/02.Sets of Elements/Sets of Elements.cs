using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < n[0]; i++)
            {
                int numbers = int.Parse(Console.ReadLine());  
                firstSet.Add(numbers);
            }

            for (int k = 0; k < n[1]; k++)
            {
                int numbers = int.Parse(Console.ReadLine());
                secondSet.Add(numbers);
            }

            var both = firstSet.Intersect(secondSet);

            foreach (var item in both)
            {
                Console.WriteLine(item);
            }

        }
    }
}
