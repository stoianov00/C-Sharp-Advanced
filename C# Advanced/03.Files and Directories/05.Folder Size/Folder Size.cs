using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _05.Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalFilesLength = Directory.GetFiles("TestFolder").Select(f => new FileInfo(f)).Sum(f => f.Length);
            Console.WriteLine($"Files Size in Megabyte: {totalFilesLength / 1024.0 / 1024}");
        

        }
    }
}
