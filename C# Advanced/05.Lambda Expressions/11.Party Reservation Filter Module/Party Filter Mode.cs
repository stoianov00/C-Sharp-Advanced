using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = new List<string>(Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries));
            List<string> filters = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Print")
                {
                    break;
                }

                var commands = input.Split(new[] { '\n', '\t', ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "Add filter")
                {
                    filters.Add(commands[1] + " " + commands[2]);
                }
                else if (commands[0] == "Remove filter")
                {
                    filters.Remove(commands[1] + " " + commands[2]);
                }
            }

            foreach (var filter in filters)
            {
                string[] commands = filter.Split();

                if (commands[0] == "Starts")
                {
                    var toRemove = people.Where(p => p.StartsWith(commands[2]));
                    people = people.Except(toRemove).ToList();
                }
                else if (commands[0] == "Ends")
                {
                    var toRemove = people.Where(p => p.EndsWith(commands[2]));
                    people = people.Except(toRemove).ToList();
                }
                else if (commands[0] == "Lenght")
                {
                    var toRemove = people.Where(p => p.Length == int.Parse(commands[1]));
                    people = people.Except(toRemove).ToList();
                }
                else if (commands[0] == "Contains")
                {
                    var toRemove = people.Where(p => p.Contains(commands[1]));
                    people = people.Except(toRemove).ToList();
                }

            }
            Console.WriteLine(string.Join(" ", people));

        }
    }
}
