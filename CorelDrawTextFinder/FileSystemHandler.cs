using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorelDrawTextFinder
{
    internal class FileSystemHandler
    {
        public static void SearchDirectory(string directory, string find)
        {
            foreach (var subdir in Directory.GetDirectories(directory))
            {
                SearchDirectory(subdir, find);
                foreach (var file in Directory.GetFiles(directory, "*.cdr"))
                {
                    if (new CdrFileHandler(file).GetText().ToUpper().Contains(find.ToUpper()))
                    {
                        Console.WriteLine(file);
                    }
                }
            }
        }

    }
}
