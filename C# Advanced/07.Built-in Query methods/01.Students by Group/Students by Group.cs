using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.Students_by_Group
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
                    Age = 1
                },
                new Students
                {
                    FirstName = "Andrew",
                    LastName = "Gibson",
                    Age = 2
                },
                new Students
                {
                    FirstName = "Craig",
                    LastName = "Ellis",
                    Age = 1
                },
                new Students
                {
                    FirstName = "Steven",
                    LastName = "Cole",
                    Age = 2
                },
                new Students
                {
                    FirstName = "Andrew",
                    LastName = "Carter",
                    Age = 2
                },
            };
            
            var sortByFirstName = students
                .Where(st => st.Age == 2)
                .OrderBy(st => st.FirstName)
                .Select(st => new
                {
                    FullName = $"{st.FirstName} {st.LastName}"
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
