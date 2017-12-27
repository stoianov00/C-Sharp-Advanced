using System;
using System.Collections.Generic;
using System.Linq;
using _01.Students_by_Group;
namespace _03.Students_by_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == string.Empty)
            {
                throw new ArgumentException("Command cannot be Empty!");
            }

            List<Students> students = new List<Students>
            {
                new Students
                {
                    FirstName = "Sara",
                    LastName = "Mills",
                    Age = 24
                },
                new Students
                {
                    FirstName = "Andrew",
                    LastName = "Gibson",
                    Age = 21
                },
                new Students
                {
                    FirstName = "Craig",
                    LastName = "Ellis",
                    Age = 19
                },
                new Students
                {
                    FirstName = "Steven",
                    LastName = "Cole",
                    Age = 35
                },
                new Students
                {
                    FirstName = "Andrew",
                    LastName = "Carter",
                    Age = 15
                },
            };

            var sortByFirstName = students
                .Where(st => st.Age >= 18 && st.Age <= 24)
                .Select(st => new
                {
                    FullName = $"{st.FirstName} {st.LastName} {st.Age}"
                })
                .ToList();

            if (input == "END")
            {
                foreach (var student in sortByFirstName)
                {
                    Console.WriteLine(student.FullName);
                }
            }
            else
            {
                Console.WriteLine("To see result type \"END\"");
            }


        }
    }
}
