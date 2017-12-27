using System;
namespace _02.Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> result = PrintCollection;
            result(input);
        }

        private static void PrintCollection(string[] collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine($"Sir {item}");
            }
        }
    }
}
