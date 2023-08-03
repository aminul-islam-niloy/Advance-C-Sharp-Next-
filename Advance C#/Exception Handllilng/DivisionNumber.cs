using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.Exception_Handllilng
{
     class DivisionNumber
    {
        int result;

      
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
    

    }
}


            //exception handling

            // DivisionNumber divisionNumber = new DivisionNumber();
            //divisionNumber.division(76686725,0);



            //  Class &Description
            //1
            //System.IO.IOException

            //Handles I / O errors.

            //2
            //System.IndexOutOfRangeException

            //Handles errors generated when a method refers to an array index out of range.

            //3
            //System.ArrayTypeMismatchException

            //Handles errors generated when type is mismatched with the array type.

            //4
            //System.NullReferenceException

            //Handles errors generated from referencing a null object.

            //5
            //System.DivideByZeroException

            //Handles errors generated from dividing a dividend with zero.

            //6
            //System.InvalidCastException

            //Handles errors generated during typecasting.

            //7
            //System.OutOfMemoryException

            //Handles errors generated from insufficient free memory.

            //8
            //System.StackOverflowException

            //Handles errors generated from stack overflow.     
