using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _07.Read_from_specified_line
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] file = File.ReadAllLines("text.txt");

            for (int i = n - 1; i < file.Length; i++)
            {
                Console.WriteLine(file[i]);
            }

        }
    }
}
