using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.File_handling
{
    internal class MoveFile
    {
        public static void MoveFiles(string sourceFilePath, string destinationFilePath)
        {
            try
            {
                File.Move(sourceFilePath, destinationFilePath);
                Console.WriteLine("File moved successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
        }
    }
}
