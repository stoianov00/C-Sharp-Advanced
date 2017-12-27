using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using  System.Diagnostics;
namespace _06.Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = Stopwatch.StartNew();
            
            string[] file = File.ReadAllLines("text.txt");
            foreach (var line in file)
            {
               
            }
            watch.Stop();
            var elapsed = watch.Elapsed;

            

            Stopwatch watch2 = Stopwatch.StartNew();

            string[] file2 = File.ReadAllLines("text2.txt");
            foreach (var line in file)
            {
               
            }
            watch.Stop();
            var elapsed2 = watch.Elapsed;


            if (elapsed < elapsed2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
