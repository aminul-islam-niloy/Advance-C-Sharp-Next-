using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.Fundamentals
{
    public class ArrayListImplement
    {
        public static void ArrayListInit()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(4);
            arrayList.Add(5);
            arrayList.Add(6);
            arrayList.Add(7);
            arrayList.Add(8);
            arrayList.Add(9);

            foreach(int i in arrayList)
            {
                Console.WriteLine(i);
            }

            // build in functions that use;
            // Count,Remove, RemoveAt(3), Clear, Range(1,3), Sort, Reverse.

            //myList.IndexOf to get index
            //myList.RemoveRange(0, 4);

            // add new array existing arrayList

            // taking array of String 

            //  string[] str_add = { "Collections",  "Generic",    "List" };
            // here we are adding the elements 
            // of the str_add to the end of 
            // the myList 
            // myList.AddRange(str_add);

            //Convert list to array
            //object[] obj1 = mylist.ToArray();
            //or
            //string[] str = (string[])mylist.ToArray(typeof(string));

            // copy array in arrayList
            //myList.CopyTo(arr);

              // Checking whether arrlistis 
                // equal to itself or not 
       // Console.WriteLine(arrlist.Equals(arrlist));

        }





    }
}
