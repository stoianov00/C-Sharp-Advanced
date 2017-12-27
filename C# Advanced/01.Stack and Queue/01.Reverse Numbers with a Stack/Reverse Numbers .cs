using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _01.Reverse_Numbers_with_a_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> reverseNumbers = new Stack<int>();
            foreach (var number in numbers)
            {
                reverseNumbers.Push(number);
            }
            while(reverseNumbers.Count != 0)
            {
                Console.Write($"{reverseNumbers.Pop()} ");
            }
            
        }
    }
}
