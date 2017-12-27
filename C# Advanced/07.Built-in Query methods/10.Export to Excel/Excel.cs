using System;
using System.IO;
namespace _10.Export_to_Excel
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            using (StreamReader reader = new StreamReader(@"StudentData.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    using (StreamWriter writer = new StreamWriter(@"result.csv", true))
                    {
                        writer.WriteLine(line.Replace(",", ";"));
                    }
                }
            }

        }
        


    }
}
