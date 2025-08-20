using System;
using System.IO;
using SortFiles;
namespace sortify
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sortify v1.0.0");
            Console.Write("Sorting files");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            FileSort sort = new FileSort();
            sort.SortingFiles();
            Console.WriteLine("Press enter to exit program");
            Console.ReadLine();
        }
    }
}