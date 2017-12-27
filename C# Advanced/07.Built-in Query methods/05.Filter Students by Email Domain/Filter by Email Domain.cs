using System;
using System.Collections.Generic;
using System.Linq;
using _01.Students_by_Group;
namespace _05.Filter_Students_by_Email_Domain
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
                    Email = "smills@gmail.com"
                },
                new Students
                {
                    FirstName = "Andrew",
                    LastName = "Gibson",
                    Age = 21,
                    Email = "agibson@abv.bg"
                },
                new Students
                {
                    FirstName = "Craig",
                    LastName = "Ellis",
                    Age = 19,
                    Email = "cellis@cs.edu.gov"
                },
                new Students
                {
                    FirstName = "Steven",
                    LastName = "Cole",
                    Age = 35,
                    Email = "themachine@abv.bg"
                },
                new Students
                {
                    FirstName = "Andrew",
                    LastName = "Carter",
                    Age = 15,
                    Email = "ac147@gmail.com"
                }
            };

            var sortByFirstName = students
                .Where(st => st.Email.Contains("@gmail.com"))
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
