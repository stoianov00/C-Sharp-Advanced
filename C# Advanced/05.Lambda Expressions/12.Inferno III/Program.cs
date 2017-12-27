using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Inferno_III
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(new []{' ', '\t', '\n', '\r'}).Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "Forge")
            {

                command = Console.ReadLine().Split(' ');
            }

        }
    }
}
