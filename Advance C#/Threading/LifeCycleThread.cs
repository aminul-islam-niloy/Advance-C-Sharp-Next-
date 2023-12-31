using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Advance_C_.Threading
{
    public class LifeCycleThread
    {
        public void thread()
        {
            for(int i=0; i<2; i++)
            {

                Console.WriteLine("My theread Running ", i);
            }
        }
    }

    public class ThreadExample
    {
        [Obsolete]
        public static void ThreadCycleMain()
        {
            LifeCycleThread obj = new LifeCycleThread();

            // Creating and initializing 
            // threads Unstarted state
            
            Thread thr1 = new Thread(new ThreadStart(obj.thread));

            Console.WriteLine("ThreadState: {0}",
                              thr1.ThreadState);

            // Running state
            thr1.Start();
            Console.WriteLine("ThreadState: {0}",
                               thr1.ThreadState);

            // thr1 is in suspended state
           // thr1.Suspend();
            Console.WriteLine("ThreadState: {0}",
                               thr1.ThreadState);

            // thr1 is resume to running state
           // thr1.Resume();
            //Console.WriteLine("ThreadState: {0}",
                            //  thr1.ThreadState);





        }
    }
}
