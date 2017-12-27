using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> listSize = Console.ReadLine().Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = Console.ReadLine();

            long min = listSize.Min();
            long max = listSize.Max();

            List<long> list = new List<long>();
            
            for (long i = min; i <= max; i++)
            {
                list.Add(i);
            }
            
            Predicate<long> even = x => x % 2 == 0;
            Predicate<long> odd = x => x % 2 != 0;;

            List<long> result = new List<long>();

            if (command == "odd")
            {
                result = list.FindAll(odd);
            }
            else
            {
                result = list.FindAll(even);
            }
            
            Console.WriteLine(string.Join(" ", result));
        }


    }
}
