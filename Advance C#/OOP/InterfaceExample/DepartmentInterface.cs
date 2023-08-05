using Advance_C_.OOP.cardinality_constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.OOP.InterfaceExample
{
    internal class DepartmentInterface
    {

        public DepartmentInterface() 
        
        {
            StudentsList = new List<StudentInterface>();
            CoursesList= new List<CourseInterface>();
        }    

        public string DepartmentName { get; set; }
        public string DeptCode { get; set; }

        public List<CourseInterface> CoursesList { get; set; }
        public List<StudentInterface> StudentsList { get; set;} 

    }
}
