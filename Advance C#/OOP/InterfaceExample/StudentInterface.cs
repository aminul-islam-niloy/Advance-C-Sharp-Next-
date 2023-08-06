using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.OOP.InterfaceExample
{
    internal class StudentInterface:IInfornation,IPrintere
    {
        public string Registration { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }  
        public string RollNumber { get; set; }

        public string GetBasicInformaion()
        {
            return Registration + " " + StudentName+ " " + RollNumber;
        }

        public void PrintInformation()
        {
            throw new NotImplementedException();
        }

        public string SetIpAddress(string ipAddress)
        {
            throw new NotImplementedException();
        }
    }
}
