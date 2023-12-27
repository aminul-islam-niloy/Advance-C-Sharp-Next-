using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.Deligates
{
    //step 1 define a delegate
    public delegate void MyDelegate(string messege);

    public  class SingleDeligates
    {
        public static void SingleDelegate()
        {
            // step 2 create the instance of the delegate
            MyDelegate mydelegate;

            //step 3 Associate the delegate with a method

            mydelegate= new MyDelegate(printMessage);

            //step 4 Invoke the delegate

            mydelegate("Hello");

            //using differenct method using the same delegate

            mydelegate= new MyDelegate(ShowMessage);
            mydelegate("this is another message");


        }



        //define the method that is matched with delegate singnature

        static void printMessage(string messege)
        {
            Console.WriteLine(messege);
        }

        static void ShowMessage(string messege) 
        {
            Console.WriteLine($"Show Message: {messege}"); 
        }

    }

    
}
