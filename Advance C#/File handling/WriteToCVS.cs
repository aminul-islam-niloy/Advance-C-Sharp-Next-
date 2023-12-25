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
    }
}
