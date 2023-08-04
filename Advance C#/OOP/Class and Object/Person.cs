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
        private string Name;
        public string Description;
        public string Address;
        public int Age;

        public void FirstName(string Name)
        {
           if(Name.Length>1) 
            { 
                this.Name= Name;
                // here instance variable and global berialble problem.
                // to avoid instance variable hiding this keyword is used
                // this.Name id field and Name is normal parameter
            }
            else
            {
                this.Name = "Not set";
                Console.WriteLine("Name should have more tha 2 langth");
            }
          
            
        }

        public void  PersonInfo()
        {
            Console.WriteLine("Person Id is:" + PersonId + " Name is : " + Name + " Age is: "+Age);
        }

    }
}
