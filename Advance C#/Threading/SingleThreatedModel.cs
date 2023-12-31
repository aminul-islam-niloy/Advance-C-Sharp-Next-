using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Advance_C_.Threading
{
    public  class SingleThreatedModel
    {
       public static void Method1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method1 is : {0}", i);

                if(i == 5)
                {
                    Thread.Sleep(6000);
                }
            }


        }

        public static void method2()
        {

         
            for (int J = 0; J <= 10; J++)
            {
                Console.WriteLine("Method2 is : {0}", J);
            }
        }

        
    }

    public class SingleThread
    {
        public static void MainSingleThread() 
        {
            SingleThreatedModel.Method1();
            SingleThreatedModel.method2();  

            //Thread thr1 = new Thread(method1);
            //Thread thr2 = new Thread(method2);
            //thr1.Start();
            //thr2.Start();
        }

        
    }

}
