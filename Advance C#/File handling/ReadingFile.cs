using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.File_handling
{
    internal class ReadingFile
    {
        public static void ReadContentOfAFile(string filePath)
        {

            // Reading all lines from a file
            string[] lines = File.ReadAllLines(filePath);

            // Reading all text from a file
            string content = File.ReadAllText(filePath);

            // Using StreamReader for more control
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }

        public static void ReadFromFile()
        {
            string readText = File.ReadAllText("newTextDoc.txt");
            Console.WriteLine("From text file: " + readText);
        }
    }
}
