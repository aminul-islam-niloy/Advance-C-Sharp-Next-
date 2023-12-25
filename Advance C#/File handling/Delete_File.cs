using System;
using System.IO;

namespace Advance_C_.File_handling
{
    internal class Delete_File
    {
        public static void DeleteFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Console.WriteLine("File deleted successfully.");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
        }
    }
}
