using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.File_handling
{
    public class FileCreate_Read
    {
        public static void CreateandRead()
        {
            string WriteTxt = "Hello world 3";
            File.WriteAllText("newfile.txt", WriteTxt);
            
            Console.Write(WriteTxt+ " in text file ");

            string readText= File.ReadAllText("newfile.txt");
            Console.WriteLine(readText);
           
        }


    }
}
