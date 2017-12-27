using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.A_Miner_s_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, double> dictinary = new Dictionary<string, double>();
            string input = Console.ReadLine();

            while (input != "stop")
            {
                string resource = input;
                double quantity = double.Parse(Console.ReadLine());

                if (!dictinary.ContainsKey(resource))
                {
                    dictinary[resource] = 0;
                }

                dictinary[resource] += quantity;
                input = Console.ReadLine();
            }

            foreach (var resources in dictinary)
            {
                Console.WriteLine($"{resources.Key} -> {resources.Value}");
            }
        }
    }
}
