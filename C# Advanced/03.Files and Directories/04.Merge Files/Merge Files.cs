using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] readFirstNumberFile = File.ReadAllLines("numbers1.txt");
            string[] readSecondNumberFile = File.ReadAllLines("numbers2.txt");
            List<string> result = new List<string>();

            for (int i = 0; i < readFirstNumberFile.Length; i++)
            {
                string currentFirstNumbers = readFirstNumberFile[i];
                string currentSecondNumbers = readSecondNumberFile[i];

                result.Add(currentFirstNumbers);
                result.Add(currentSecondNumbers);
            }

            File.WriteAllLines("result.txt", result);

        }
    }
}
