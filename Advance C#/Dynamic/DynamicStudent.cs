using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.Dynamic
{
     class DynamicStudent
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int city { get; set; }
    }
}




        // Dynamic type datatype in c#

        //dynamic variable1 = 1;
        //   Console.WriteLine(variable1.GetType());
        //variable1 = "This is me";
        /// Console.WriteLine(variable1.GetType());


        //here  we can assign new type as my choice without adding
        //dynamic Values = new ExpandoObject();
        //Values.id = 12345;
        //Values.name = "ajik";
        //Values.address = "khulna";
        //Values.age = 30;
        //Values.gender = "male";


        //   Console.WriteLine(variable1);