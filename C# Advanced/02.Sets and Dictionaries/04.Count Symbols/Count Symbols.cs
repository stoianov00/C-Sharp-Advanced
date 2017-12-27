using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> result = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];
                if (!result.ContainsKey(currentSymbol))
                {
                    result[currentSymbol] = 0;
                }
                result[currentSymbol]++;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
            
        }
    }
}
