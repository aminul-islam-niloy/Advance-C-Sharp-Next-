using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.OOP.Class_and_Object
{
     class Address
    {
        public string  HouseNo { get; set; }
        public string  RoadNo { get; set; }
        public string  Area { get; set; }
        public string  PostCode { get; set; }
        public string  District { get; set; }

        public void AddressPrint()
        {
            Console.WriteLine("Rode no" + RoadNo + " in " + Area + " and city is " + District);
        }
    }
}
