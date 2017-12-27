using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _06.Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long pumpNo = 0;
            Queue<BigInteger> pumps = new Queue<BigInteger>();

            BigInteger currentFuel = 0;
            long i = 0;
            while (i < n)
            {

                BigInteger[] current = Console.ReadLine().Split(new[] { ' ' }).Select(BigInteger.Parse).ToArray();
                pumps.Enqueue(current[1] - current[0]);
                i++;
            }
            
            while (pumpNo < n)
            {
                currentFuel += pumps.Dequeue();
                if (currentFuel <= 0 || pumps.Count() == 0)
                {
                    Console.WriteLine(pumpNo);
                    break;
                }
                pumpNo++;
            }
        }
    }
}
