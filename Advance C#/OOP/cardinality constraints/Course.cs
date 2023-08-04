using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.OOP.cardinality_constraints
{
    internal class Course
    {
        public string  Courseecode { get; set; }  
        public string Coursetitle { get; set; }
        public double Coursecredit { get; set; }

        public  string GetCourseInfo()
        {
            return "Course Code: " + Courseecode + " " + Coursetitle + " " + Coursecredit;
        }

    }
}
