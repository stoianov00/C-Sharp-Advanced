using System;
namespace _01.Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> result = PrintCollection;
            result(input);        }

        private static void PrintCollection(string[] collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

    }
}
