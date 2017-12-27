using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> result = new Stack<int>();
            Stack<int> maxResult = new Stack<int>();
            int maxElement = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                string specialCommand = command[0];
                
                switch (specialCommand)
                {
                    case "1":
                        int numberToPush = int.Parse(command[1]);
                        result.Push(numberToPush);
                        if(numberToPush >= maxElement)
                        {
                            maxElement = numberToPush;
                            maxResult.Push(maxElement);
                        }
                        break;
                       
                    case "2":
                        int elementAtTop = result.Pop();
                        int currentMaxNumber = maxResult.Peek();

                        if(elementAtTop == currentMaxNumber)
                        {
                            maxResult.Pop();
                            if(maxResult.Count > 0)
                            {
                                maxElement = maxResult.Peek();
                            }
                            else
                            {
                                maxElement = int.MinValue;
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine(maxResult.Peek());
                        break;
                }
            }
        }
    }
}
