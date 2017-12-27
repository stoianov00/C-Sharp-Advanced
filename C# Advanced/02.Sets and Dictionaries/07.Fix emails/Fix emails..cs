using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fix_emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> dict = new Dictionary<string, string>();

            while(input != "stop")
            {
                string email = Console.ReadLine();
                if (!dict.ContainsKey(input)){
                    dict[input] = string.Empty;
                }
                dict[input] = email;

                input = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}
