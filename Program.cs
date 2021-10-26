using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            string userDirectory = "wishlist";

            string newDirectoryFullPath = @$"{rootDirectory}\{userDirectory}";
            Console.WriteLine(newDirectoryFullPath);

            Directory.CreateDirectory(newDirectoryFullPath);
        }
    }
}
