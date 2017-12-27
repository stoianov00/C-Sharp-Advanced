using System;
using System.Collections.Generic;
using System.Linq;
namespace _10.Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(new[] {' ', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = Console.ReadLine().Split(' ');
            
            while (command[0] != "Party!")
            {
                if (command[0] == "Remove" && command[1] == "StartsWith")
                {
                    names.RemoveAll(n => n.StartsWith(command[2]));
                }
                else if (command[0] == "Remove" && command[1] == "EndsWith")
                {
                    names.RemoveAll(n => n.EndsWith(command[2]));
                }
                else if (command[0] == "Double" && command[1] == "StartsWith")
                {
                    IEnumerable<string> doubleStartsWithElement = Double(names, n => command[0] == "Double").Where(n => n.StartsWith(command[2]));                   
                    names.AddRange(doubleStartsWithElement);
                }
                else if (command[0] == "Double" && command[1] == "EndsWith")
                {
                    IEnumerable<string> doubleEndsWithElement = Double(names, n => command[0] == "Double").Where(n => n.EndsWith(command[2]));
                    names.AddRange(doubleEndsWithElement);
                }
                else if (command[0] == "Double" && command[1] == "Length")
                {
                    IEnumerable<string> length = Double(names, n => command[0] == "Double").Where(n => int.Parse(n) == int.Parse(command[2]));
                    names.AddRange(length);
                }
               
                
                command = Console.ReadLine().Split(' ');
            }
           
            // TODO: Format Output           
          
            if(names.Count > 1)
            {
                Console.Write(string.Join(", ", names));
                Console.WriteLine(" are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }

        public static List<string> Criteria(List<string> collection, Func<string, bool> filter)
        {
            List<string> result = new List<string>();
            foreach (var item in collection)
            {
                if (filter(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static List<string> Double(List<string> collection, Func<string, bool> filter)
        {
            List<string> result = new List<string>();
            foreach (var item in collection)
            {
                if (filter(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        
    }
}
