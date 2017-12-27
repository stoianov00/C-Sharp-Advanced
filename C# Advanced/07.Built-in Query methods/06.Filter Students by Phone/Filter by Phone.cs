using System;
using System.Collections.Generic;
using System.Linq;
using _01.Students_by_Group;
namespace _06.Filter_Students_by_Phone
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
                    Phone = "02435521"
                },
                new Students
                {
                    FirstName = "Andrew",
                    LastName = "Gibson",
                    Age = 21,
                    Phone = "0895223344"
                },
                new Students
                {
                    FirstName = "Craig",
                    LastName = "Ellis",
                    Age = 19,
                    Phone = "+3592667710"
                },
                new Students
                {
                    FirstName = "Steven",
                    LastName = "Cole",
                    Age = 35,
                    Phone = "3242133312"
                },
                new Students
                {
                    FirstName = "Andrew",
                    LastName = "Carter",
                    Age = 15,
                    Phone = "+001234532"
                }
            };

            var sortByFirstName = students
                .Where(st => st.Phone.StartsWith("02") || st.Phone.StartsWith("+3592"))
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
