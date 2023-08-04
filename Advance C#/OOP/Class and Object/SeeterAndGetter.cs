using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.OOP.Class_and_Object
{
     class SeeterAndGetter 
    {
        private string firstName;
        public string lastName;
        public string middleName;


        private string password;

        public SeeterAndGetter()
        {
        }

        public string FirstName
        {
            set
            {
                if (value.Length >= 2)
                {
                    firstName = value;
                }
                else
                {
                    firstName = "Insert Big name \n";
                 
                }

            }

            get
            {
                return firstName;
            }
        }

     

        public void PrintDetails()
        {

            Console.WriteLine("Full name is: " + firstName +" "+  middleName +" " + lastName);
        }

       
    }
}
