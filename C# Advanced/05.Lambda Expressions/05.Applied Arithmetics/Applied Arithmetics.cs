using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.Applied_Arithmetics
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(new []{ ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = Console.ReadLine();
            
            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        input = Functions.ApplyFunc(input, n => n + 1);
                        break;

                    case "multiply":
                        input = Functions.ApplyFunc(input, n => n * 2);
                        break;

                    case "subtract":
                        input = Functions.ApplyFunc(input, n => n - 1);
                        break;

                    case "print":
                        Functions.Print(input, x => Console.Write(string.Join(" ", input)));
                        break;
                        
                }

                command = Console.ReadLine();
            }

        }
        
    }
}
