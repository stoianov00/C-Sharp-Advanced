using System;
using System.Collections.Generic;
using System.Linq;
using _01.Students_by_Group;
namespace _08.Weak_Students
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
                    Age = 24,
                    Marks = new int[]{ 6, 6, 6, 5 }
                },
                new Students
                {
                    FirstName = "Andrew",
                    LastName = "Gibson",
                    Age = 21,
                    Marks = new int[]{ 3, 4, 5, 6 }
                },
                new Students
                {
                    FirstName = "Craig",
                    LastName = "Ellis",
                    Age = 19,
                    Marks = new int[]{ 4, 2, 3, 4 }
                },
                new Students
                {
                    FirstName = "Steven",
                    LastName = "Cole",
                    Age = 35,
                    Marks = new int[]{ 5, 6, 5, 5 }
                },
                new Students
                {
                    FirstName = "Andrew",
                    LastName = "Carter",
                    Age = 15,
                    Marks = new int[] {5, 3, 4, 2}
                }
            };

            var sortByFirstName = students
                .Select(st => new
                {
                    FullName = $"{st.FirstName} {st.LastName}"
                })
                .ToList();

            if (input == "END")
            {
                foreach (var student in students)
                {
                    if (student.Marks.Any(m => m <= 2) && student.Marks.Any(m => m <= 3))
                    {
                        Console.WriteLine($"{student.FirstName} {student.LastName}");
                    }
                }
            }
            else
            {
                Console.WriteLine("To see result type \"END\"");
            }

        }
    }
}
