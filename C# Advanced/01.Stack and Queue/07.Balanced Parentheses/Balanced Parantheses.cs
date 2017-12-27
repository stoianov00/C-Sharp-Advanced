using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            bool flag = true;

            foreach (char para in input)
            {
                switch (para)
                {
                    case '[':
                    case '(':
                    case '{':
                        stack.Push(para);
                        break;

                    case '}':
                        if (!stack.Any())
                            flag = false;

                        else if (stack.Pop() != '{')
                            flag = false;
                        break;

                    case ')':
                        if (!stack.Any())
                            flag = false;

                        else if (stack.Pop() != '(')
                            flag = false;
                        break;

                    case ']':
                        if (!stack.Any())
                            flag = false;

                        else if (stack.Pop() != '[')
                            flag = false;
                        break;
                }
                if (!flag)
                    break;
            }

            Console.WriteLine(flag ? "YES" : "NO");
        }
    }
}
