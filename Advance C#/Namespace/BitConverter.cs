using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.Namespace
{
    public class BitConverterSystems
    {
        public static void SystemBitConver()
        {
            long[] ele = { 0, long.MaxValue, long.MinValue, 1000000000000000, -100000000,
                0xDDDDDDDDD, -0xAAAAAAAAAAAA};

            foreach(long e in ele)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();

            Console.WriteLine("using bit conveter: ");

            foreach(long e in ele)
            {
                byte[] b = BitConverter.GetBytes(e);

               // decimal sol = Convert.ToDecimal(b);

                Console.WriteLine(BitConverter.ToString(b));   
            }
        }


    }
}
