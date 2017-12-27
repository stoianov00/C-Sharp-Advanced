using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            Dictionary<string, Dictionary<string, long>> dict = new Dictionary<string, Dictionary<string, long>>();

            //Sofia|Bulgaria|1000000

            while (input[0] != "report")
            {

                if (!dict.ContainsKey(input[1]))
                {
                    dict.Add(input[1], new Dictionary<string, long>());
                }
                dict[input[1]].Add(input[0], long.Parse(input[2]));

                input = Console.ReadLine().Split('|');
            }
            
            foreach (var country in dict.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }

        }
    }
}
