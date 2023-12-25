using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.OOP.Polymmorphsim.Compile_TIme
{
    public class calculatorPoly
    {

        //method overloading using polymorphism
        public int add(int x, int y)
        {
            return x + y;
        }

        public double add(double x, double y)
        {
            return x + y;
        }

    }
}
