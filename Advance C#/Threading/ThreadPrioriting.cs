using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Advance_C_.Threading
{
    public  class ThreadPrioriting

    {
        // Main Method 
        static public void MainPriorityMethod()
        {

            // Creating and initializing threads 
            Thread T1 = new Thread(work);
            Thread T2 = new Thread(work);
            Thread T3 = new Thread(work);

            // Set the priority of threads 
            T2.Priority = ThreadPriority.Highest;
            T3.Priority = ThreadPriority.BelowNormal;
            T1.Start();
            T2.Start();
            T3.Start();

            // Display the priority of threads 
            Console.WriteLine("The priority of T1 is: {0}",
                                              T1.Priority);

            Console.WriteLine("The priority of T2 is: {0}",
                                              T2.Priority);

            Console.WriteLine("The priority of T3 is: {0}",
                                              T3.Priority);
        }

        public static void work()
        {

            // Sleep for 1 second 
            Thread.Sleep(1000);
        }
    }

}



//Highest: The value of this priority is 4.
//AboveNormal: The value of this priority is 3.
//Normal: The value of this priority is 2.
//BelowNormal: The value of this priority is 1.
//Lowest: The value of this priority is 0.
