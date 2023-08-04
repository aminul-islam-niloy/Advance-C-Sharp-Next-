using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.OOP.Class_and_Object
{
     class StudentConstructor
    {

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        // one to one assiociation relation
        public Address PresentAddress { get; set; }

       

        public StudentConstructor(string firstName, string middleName,string lastName):this(firstName,lastName) 
        
        { 
        
        MiddleName = middleName;

        
        }

        // here :this used for constructor chaining 
        public StudentConstructor(string firstName, string lastName):this()

        {

            FirstName = firstName;
            LastName = lastName;

        }

        public StudentConstructor()

        {
          //  Console.WriteLine("Default constructor is called");

        }

        public void PrintStudentDetails()
        {
          //  Console.WriteLine("Constructor name : "+ FirstName+ " " + MiddleName+ " "+ LastName); 
        }

    }
}
