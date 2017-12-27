using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace _01.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        { 
            string[] readFile = File.ReadAllLines("text.txt");
            List<string> oddLineList = new List<string>();

            for (int i = 1; i < readFile.Length; i+=2)
            {
                oddLineList.Add(readFile[i]);
            }

            File.WriteAllLines("result.txt", oddLineList);
        }
    }
}
