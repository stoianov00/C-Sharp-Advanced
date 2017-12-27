using System;
using System.Collections.Generic;
using System.Linq;
namespace _09.Group_by_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == string.Empty)
            {
                throw new ArgumentException("Command cannot be empty!");
            }

            List<Person> persons = new List<Person>
            {
                new Person
                {
                    Name = "Ivaylo Petrov",
                    Group = 10
                },
                new Person
                {
                    Name = "Stanimir Sivilianov",
                    Group = 3
                },
                new Person
                {
                    Name = "Indje Kromidov",
                    Group = 3
                },new Person
                {
                    Name = "Irina Balabanova",
                    Group = 4
                },
            };

            var groupedStudents = persons
                .GroupBy(st => st.Group)
                .ToList();

            if (input == "END")
            {
                foreach (var group in groupedStudents)
                {
                    Console.Write(group.Key);

                    foreach (var subitem in group)
                    {
                        Console.Write($" {subitem.Name}");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("To see result type \"END\"");
            }





        }
    }
}
