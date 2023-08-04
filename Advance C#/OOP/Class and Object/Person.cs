using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.OOP.Class_and_Object
{
     class Person
    {
        public int PersonId;
        public string Name;
        public string Description;
        public string Address;
        public int Age;

        public void  PersonInfo()
        {
            Console.WriteLine("Person Id is:" + PersonId + " Name is : " + Name + " Age is: "+Age);
        }

    }
}
