using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.File_handling
{
    public class CreateFile
    {
        private static string filePath;

        public static void CreteFile()
        {
            string filepath = "File handling\newfile.txt;";

            using (FileStream fs = File.Create(filePath))
            {

                string content = "This is the content of the new file.";
                byte[] contentBytes = System.Text.Encoding.UTF8.GetBytes(content);
                fs.Write(contentBytes, 0, contentBytes.Length);
            }

            Console.WriteLine($"File '{filePath}' created successfully.");
        }
    }
}
