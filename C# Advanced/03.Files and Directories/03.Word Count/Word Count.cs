using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {

            var readFirstFile = File.ReadAllText("words.txt")
                .Split(new char[] { ' ', ',', '!', '?', '-', '.', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.ToLower())
                .Distinct()
                .ToArray();

            var readSecondFile = File.ReadAllText("text.txt")
                .Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.ToLower())
                .Distinct()
                .ToArray();

            Dictionary<string, int> result = new Dictionary<string, int>();

            for (int i = 0; i < readFirstFile.Length; i++)
            {
                var currentWord = readFirstFile[i];
                int currentCounter = 0;

                for (int j = 0; j < readSecondFile.Length; j++)
                {
                    if (currentWord == readSecondFile[j])
                    {
                        currentCounter++;
                    }
                }
                result[currentWord] = currentCounter;
            }

            var sortedResult = result
                .OrderByDescending(kvp => kvp.Value)
                .Select(kvp => $"{kvp.Key} - {kvp.Value}")
                .ToArray();

            File.WriteAllLines("result.txt", sortedResult);
        }

        
    }
}
