using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.File_handling
{
    internal class FileExists
    {
       public static void CheckingFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("File exists!");
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }
        }
    }
}
