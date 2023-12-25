using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.File_handling
{
    internal class EditText
    {
        public static void EditTextInFile(string filePath, string searchText, string replaceText)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string content = File.ReadAllText(filePath);
                    content = content.Replace(searchText, replaceText);
                    File.WriteAllText(filePath, content);
                    Console.WriteLine("Text replaced successfully.");
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
