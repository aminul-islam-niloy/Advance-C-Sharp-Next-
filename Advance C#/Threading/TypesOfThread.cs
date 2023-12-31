using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Advance_C_.Threading
{
    public class TypesOfThread
    {
        public static void Foreground()
        {
            Thread thread = new Thread(Worker);
            thread.Start();

            Console.WriteLine("Main thread is start");
        }
        public static void Worker()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("worker is running");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Worker is end");
        }


        // Main method
       public static void MainBackground()
        {
            // Creating and initializing thread
            Thread thr = new Thread(mythread);

            // Name of the thread is Mythread
            thr.Name = "Mythread";
            thr.Start();

            // IsBackground is the property of Thread
            // which allows thread to run in the background
            thr.IsBackground = true;

            Console.WriteLine("Main Thread Ends!!");
        }

        // Static method
        static void mythread()
        {

            // Display the name of the 
            // current working thread
            Console.WriteLine("In progress thread is: {0}",
                                Thread.CurrentThread.Name);

            Thread.Sleep(2000);

            Console.WriteLine("Completed thread is: {0}",
                              Thread.CurrentThread.Name);
        }
    }
}
