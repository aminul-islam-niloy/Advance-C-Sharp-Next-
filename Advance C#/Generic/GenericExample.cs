using Advance_C_.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Advance_C_.Program;

namespace Advance_C_.Generic
{

  public class GenericExample<T>

    {
        public string Name { get; set; }
        public T Sucess { get; set; }

        

       
    }


}


        // it's an type data type.

        // boxing and unboxing 
        // premetive to reference type conversion
        // unboxing is that reference type to premetive type
        // it eleminate problem of boxing and unboxing 




        //GenericExample<string> generic_Student1 = new GenericExample<string>();
        //{
        //    generic_Student1.Name = "Ahmed Hossain";
        //    generic_Student1.Sucess = "1";

        //}

        //GenericExample<double> generic_Student2 = new GenericExample<double>();
        //{
        //    generic_Student2.Name = "Ahmed bacca";
        //    generic_Student2.Sucess = 14.477;

        //}



        //Generic_Student<string, double> DoubleGeneric = new Generic_Student<string, double>();
        //{
        //    DoubleGeneric.Name = "Ahmed bacca";
        //    DoubleGeneric.Sucess = " Passed ";
        //    DoubleGeneric.grade = 2.99;



        //}


        //PrintResult(DoubleGeneric);

        //PrintResult(generic_Student1);
        //PrintResult(generic_Student2);



        //Console.ReadKey();

             
        //        }

       

        //        public static void PrintResult<T>(GenericExample<T> Exxample)
        //{
        //    Console.WriteLine(Exxample.Name + " is  : " + Exxample.Sucess);
        //}

        //public static void PrintResult<T, U>(Generic_Student<T, U> GenericMethod)
        //{
        //    Console.WriteLine(GenericMethod.Name + " has  : " + GenericMethod.Sucess +
        //                                      "  with " + GenericMethod.grade + " Grade  ");
        //}


        //public class Generic_Student2<T>
        //{
        //    public string Name { get; set; }
        //    public T Sucess { get; set; }
        //}


        //public class Generic_Student<T, U>
        //{
        //    public string Name { get; set; }
        //    public T Sucess { get; set; }
        //    public U grade { get; set; }
        //}

