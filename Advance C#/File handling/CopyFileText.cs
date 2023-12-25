using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.File_handling
{
    internal class CopyFileText
    {
        public static void CopyFile(string sourceFilePath, string destinationFilePath)
        {
            try
            {
                File.Copy(sourceFilePath, destinationFilePath, true); // true for overwrite
                Console.WriteLine("File copied successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
        }
    }
}
