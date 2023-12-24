using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.Fundamentals
{
    public class Params
    //in params, parameter is not spacified
    {
        public static int add(params int [] list)
        {
            int total = 0;
            foreach (int i in list)
            {
                total += i;
            }

            return total;
        }

    }
}
