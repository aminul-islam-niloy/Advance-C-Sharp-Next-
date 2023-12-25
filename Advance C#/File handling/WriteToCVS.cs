using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.File_handling
{
    public class WriteToCVS
    {
        private static string filePath;

        public static void AddRecord(string ID, string Name, string Age, string path) 
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@path, true))
                {
                    sw.WriteLine(ID+ ","+ Name+ ","+ Age);
                }
                   
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString()+ " this program did an oopsie");
            }
        }

        public static void AddTextInaFile()
        {
            try
            {
                string FilePath = "newTextDoc.txt";

                // Appending text to a file using File.AppendText
                using (StreamWriter writer = File.AppendText(FilePath))
                {
                    // Writing text to a file
                    string content = "Hello, File Handling in C# with new text!";
                    writer.WriteLine(content);

                    // Appending more text to the file
                    string additionalContent = "Appending more text!";
                    writer.WriteLine(additionalContent);

                    // Adding a new line using StreamWriter
                    writer.WriteLine("New line using StreamWriter");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
        }



    }
}
