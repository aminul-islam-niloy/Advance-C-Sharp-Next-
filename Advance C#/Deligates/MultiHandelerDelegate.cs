using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Advance_C_.Program;

namespace Advance_C_.Deligates
{
     static class MultiHandelerDelegate
    {

        public static void Hello(string message)
        {
            //  Console.WriteLine("Hello " + message);
        }

        public static void GoodBye(string message)
        {
            // Console.WriteLine("Good Bye " + message);
        }


    }
}




        // Multiple delegate example in c#

        //SMS smsExample = Hello;
        //    smsExample += GoodBye;

        //    smsExample("Niloy");

        // also we can declare as
        //  SMS smsExample2 = GoodBye;
        // smsExample1("Niloy");

        // also there are others way

        //SMS Example = Hello;
        //SMS Example1 = GoodBye;
        //SMS Example2 = Example + Example1;
        ////   Example2("Aminul Islam Niloy");
