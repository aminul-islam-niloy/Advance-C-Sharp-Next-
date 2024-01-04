using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Advance_C_.Namespace
{
    public class ConsoleApplicationOperations
    {
        public static void DecoratorInConsole()
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello world" + Console.BackgroundColor);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World"+ Console.BackgroundColor);
        }

        public static void DecoratorBufferConsole()

        {
            Console.WriteLine("buffer height" + Console.BufferHeight);
           // Console.BufferHeight = 100;
            Console.Write("After changing"+ Console.BufferHeight);
            Console.WriteLine("CapsLock " + Console.CapsLock);
            Console.CursorLeft = 4;
            Console.WriteLine("Cursor Left " + Console.CursorLeft);
            Console.WindowHeight = 5;
            Console.WriteLine("Window Height"+Console.WindowHeight);

        }

        public static void KeyPreessedMain()
        {
            // declare a new ConsoleKeyInfo object
            ConsoleKeyInfo c = new ConsoleKeyInfo();

            // outer loop to work until 'z' is pressed
            do
            {
                Console.WriteLine("\nPress a key to display; " +
                                  "press the 'z' key to quit.");

                // inner loop to check whether a key 
                // is pressed using KeyAvailable 
                while (Console.KeyAvailable == false)

                    // Loop until input is entered.
                    Thread.Sleep(50);
                c = Console.ReadKey(true);
                Console.WriteLine("You pressed the '{0}' key.", c.Key);

            } while (c.Key != ConsoleKey.Z);
        }
    }
}
