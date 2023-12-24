using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.Fundamentals
{
    public class nullable
    {
        public  static void DefineNullable()
        {
            Nullable<int> nullValue = null;

            if (nullValue.HasValue)
            {
                Console.WriteLine($" it's {nullValue}");
            }
            else
            {
                Console.WriteLine("It is null value");
            }

        }

        //shorthand notation T?
        public static void TernaryNullable()
        {
            int? nullableValue = null;
            //string ? value= null;
            //public void add(int? value);
            //nullable in method


            if (nullableValue.HasValue)
            {
                Console.WriteLine($" it's {nullableValue}");
            }
            else
            {
                Console.WriteLine("It is null value");
            }

        }

    }
}
