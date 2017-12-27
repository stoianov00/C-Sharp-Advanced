using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_Sequence_with_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Queue<long> elements = new Queue<long>();
            List<long> result = new List<long>();
            elements.Enqueue(number);
            result.Add(number);

            while (result.Count < 50)
            {
                long currentElement = elements.Dequeue();
                long firstNumber = currentElement + 1;
                long secondNumber = (currentElement * 2) + 1;
                long thirdNumber = currentElement + 2;

                elements.Enqueue(firstNumber);
                elements.Enqueue(secondNumber);
                elements.Enqueue(thirdNumber);

                result.Add(firstNumber);
                result.Add(secondNumber);
                result.Add(thirdNumber);

            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{result[i]} ");
            }

        }
    }
}
