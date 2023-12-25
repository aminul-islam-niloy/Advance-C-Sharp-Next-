using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.OOP.Abstract
{
    class Square : Shape
    {
        private int side;

        public Square(int x=0)
        {
            side = x;
        }

        public override int area()
        {
            Console.WriteLine("Area of square: ");
            return (side * side);
        }
    }
}
