using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.OOP.cardinality_constraints
{
    internal class Department

    {
        public Department() 
        
        {
            Courses = new List<Course>();
        }

        public string DeptCode { get; set; }
        public string NamesOfDept { get; set; }

        //if  one department one course   one to one

        // association relation or has a relation  one to many
        public List<Course> Courses { get; set; }


        public string GetCourseInfo()
        {
            string info = "Depart Code : "+ DeptCode+ "  Name "+ NamesOfDept+ Environment.NewLine;
            foreach (var course in Courses)
            {
                info = info + course.GetCourseInfo() + "\n";
            }
            return info;
        }


    }
}
