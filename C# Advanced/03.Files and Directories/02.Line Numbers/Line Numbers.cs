using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace _02.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] readFile = File.ReadAllLines("text.txt");
            List<string> resultList = new List<string>();

            for (int i = 0; i < readFile.Length; i++)
            {
                resultList.Add($"{i + 1}. {readFile[i]}");
            }

            File.AppendAllLines("result.txt", resultList);

        }
    }
}
