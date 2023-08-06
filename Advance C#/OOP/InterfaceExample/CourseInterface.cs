using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.OOP.InterfaceExample
{
     public class CourseInterface:IInfornation
    {
        public string CourseName { get; set; }  
        public string CourseDescription { get; set; }
        public double CourseCredit { get; set; }

        public string GetBasicInformaion()
        {
            return CourseName + " " + CourseCredit + " " + CourseDescription;
        }





        //public List<string> Unknown()
        //{
        //    List<string> list = new List<string>();
        //    list.Add(CourseName);
        //    list.Add(CourseDescription);

        //    return list;
        //}


    }
}
