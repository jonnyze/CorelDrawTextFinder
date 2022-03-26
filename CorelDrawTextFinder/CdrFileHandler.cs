using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorelDrawTextFinder
{
    internal class CdrFileHandler
    {
        private readonly string filepath;

        public CdrFileHandler(string filepath)
        {
            this.filepath = filepath;
        }

        public string GetText()
        {
            try
            {
                using (ZipArchive zip = ZipFile.Open(filepath, ZipArchiveMode.Read))
                {
                    var entry = zip.Entries.FirstOrDefault(z => z.FullName == "META-INF/textinfo.xml");
                    if (entry != null)
                    {
                        StreamReader sr = new StreamReader(entry.Open());
                        var text = sr.ReadToEnd();
                        return text;
                    }
                }
            }
            catch (Exception)
            {
                //Ignore exceptions for now.
            }
            return string.Empty; //No match
        }

    }
}
