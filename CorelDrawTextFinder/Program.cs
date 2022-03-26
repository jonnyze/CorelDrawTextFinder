using System;
using System.IO;

namespace CorelDrawTextFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length!=1)
            {
                Console.WriteLine("Enter word to search for");
                return;
            }

            FileSystemHandler.SearchDirectory(Directory.GetCurrentDirectory(), args[0]);
        }

    }
}
