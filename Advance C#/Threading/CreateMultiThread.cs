using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Advance_C_.Threading
{
    public class CreateMultiThread
    {
        public static void mainThread()
        {
            Thread t = new Thread(Worker);

            t.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("main thread doing some work");
                Thread.Sleep(100);
            }

            // wait for the worker thread to complete

            t.Join();

            Console.WriteLine("Done");
    
        }

        public static void Worker()
        {
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("Worker is running");
                Thread.Sleep(100);
            }
        }

        //Another useful feature of C# is the ThreadPool class, which manages a
        //pool of threads and can be used to execute tasks asynchronously.

        public static void MainThreadPool()
        {
            // queue a work item to the thread pool
           ThreadPool.QueueUserWorkItem(Worker2,"Hello, world");

            // do some other work in the main thread
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main thread doing some work");
                Thread.Sleep(100);
            }

            Console.WriteLine("Done");
        }

        static void Worker2(object state)
        {
            string message = (string)state;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(message);
                Thread.Sleep(100);
            }
        }


    }
}
