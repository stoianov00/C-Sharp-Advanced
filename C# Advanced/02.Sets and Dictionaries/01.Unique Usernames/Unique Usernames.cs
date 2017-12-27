using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                names.Add(input);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
