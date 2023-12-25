using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.File_handling
{
    internal class Search_file_Text
    {
        public static void SearchTextInFile(string filePath, string searchText)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string content = File.ReadAllText(filePath);
                    if (content.Contains(searchText))
                    {
                        Console.WriteLine("Text found in the file.");
                    }
                    else
                    {
                        Console.WriteLine("Text not found in the file.");
                    }
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
