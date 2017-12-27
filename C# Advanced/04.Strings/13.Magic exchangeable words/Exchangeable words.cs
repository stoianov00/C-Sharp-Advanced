using System;
using System.Collections.Generic;

namespace _13.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string shortestString = input[0];
            string longestString = input[1];
            Dictionary<char, char> dict = new Dictionary<char, char>();

            if (shortestString.Length > longestString.Length)
            {
                string temp = longestString;
                longestString = shortestString;
                shortestString = temp;
            }

            bool flag = true; 
            for (int i = 0; i < shortestString.Length; i++)
            {
                if (!dict.ContainsKey(longestString[i]))
                {
                    dict.Add(longestString[i], shortestString[i]);
                }
                else if(dict[longestString[i]] != shortestString[i])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                for (int i = shortestString.Length; i < longestString.Length; i++)
                {
                    if (!dict.ContainsKey(longestString[i]))
                    {
                        flag = false;
                    }
                }
            }
            Console.WriteLine(flag.ToString().ToLower());


        }
    }
}
