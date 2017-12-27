using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder word = new StringBuilder();
            SortedSet<string> palindromes = new SortedSet<string>();
            
            for (int i = 0; i < text.Length; i++)
            {
                while (char.IsLetter(text[i]))
                {
                    word.Append(text[i]);
                    i++; 
                    if (i >= text.Length)
                    {
                        break;
                    }
                }

                if (word.ToString() == Reverse(word) && word.ToString() != string.Empty)
                {
                    palindromes.Add(word.ToString()); 
                }
                word.Clear(); 
            }
            
            Console.WriteLine($"[{string.Join(", ", palindromes)}]");

        }

        private static string Reverse(StringBuilder word)
        {
            StringBuilder reversedWord = new StringBuilder();
            for (int j = word.Length - 1; j >= 0; j--)
            {
                reversedWord.Append(word[j]);
            }
            return reversedWord.ToString();
        }

    }
}
