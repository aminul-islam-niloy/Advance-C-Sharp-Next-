using Advance_C_.Object_Initializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.Object_Initializer
{
     class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Age { get; set; }
        public string Address { get; set; }
        private string PhoneNumber { get; set; }

        public  string GetStudentInformation()
        {
            return "Student id: " + Id + "Name is: " + Name;
        }
    }
}



            //Object initializer in c# 
            //Student student = new Student()
            //{
            //    Id = 1,
            //    Name = "Amin",
            //    Address = "Dhaka",
            //    Age = 10
            //};

            //string name = student.Name;
            //Console.WriteLine(name);