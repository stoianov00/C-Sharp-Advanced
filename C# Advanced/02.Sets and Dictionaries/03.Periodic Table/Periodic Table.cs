using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> chemicalCompounds = new HashSet<string>();
            
            for (int i = 0; i < n; i++)
            {
                string[] chemicals = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var chemical in chemicals)
                {
                    chemicalCompounds.Add(chemical);
                }
            }
            var sortChemicalCompounds = chemicalCompounds.OrderBy(c => c);

            foreach (var item in sortChemicalCompounds)
            {
                Console.Write(item + " ");
            }

        }
    }
}
