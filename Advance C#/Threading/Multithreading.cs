using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Advance_C_.Threading
{
    public class Multithreading
    {
        public static void method1()
        {
            for(int i = 0; i < 10; i++) 
            { 
                Console.WriteLine("Method 1",i);

                if (i == 5)
                {
                    Thread.Sleep(6000);
                }
            }
        }

        public static void method2()
        {
            for(int i=0; i<10; i++) 
            {
                Console.WriteLine("method 2", i);

            }
        }

        public static void MainMultithread()
        {
            Thread t1 = new Thread(method1);
            Thread t2 = new Thread(method2);
            t1.Start();
            t2.Start();
        }
    }
}
