using Advance_C_.Deligates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Advance_C_.Program;

namespace Advance_C_.Deligates

        // delegate init
       // public delegate int Calculator(int num1, int num2);


{
     class SingleDelegateStudent
    {

        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Registration { get; set;}


    }

   
}



// Deligates : Declar, target method, invoke
// pass method through Method 
// even handling 
// call by method 

// we can attach more and more  same signature method in the delegate


//SingleDelegateStudent deligateExample = new SingleDelegateStudent();
//Calculator calculatorhandaler = new Calculator(Add);

// Calculator calHandaler = Add;



//  InvokeDelegate(calHandaler,30,10);

// Calculator calHandaler1 = Sub;

// InvokeDelegate(calHandaler1, 30, 10);

//int resultsDeli=  calHandaler.Invoke(19, 49);
// int resultsDeli = calHandaler(20,10);

// Console.WriteLine(resultsDeli);

//deligateExample.Name = "Thus Harold";

// Anonymus  Delegate and lembda expression 

//A delegate is a type that represents references to methods with a particular
//parameter list and return type.

//Calculator calHandaler = delegate (int firstNum, int secoundNum)
//{
//    return firstNum + secoundNum;
//};

//Lambda expression

//Calculator calHandaler = (firstNum, secoundNum) => firstNum + secoundNum;
// in lambda expression parameter list               such that           method body
// if i use second bracket then we have to use return 


//InvokeDelegate(calHandaler, 30, 10);




        //// delegates method 
        //static int Add(int firstNum, int secondNum)
        //{
        //    return firstNum + secondNum;
        //}

        //static int Sub(int firstNum, int secondNum)
        //{
        //    return firstNum - secondNum;
        //}


        //// public delegate int Calculator(int num1, int num2);

        //public static void InvokeDelegate(Calculator calHandaler, int firstNum, int secondNum)
        //{
        //    int resultInvoke = calHandaler.Invoke(firstNum, secondNum);
        //    Console.WriteLine("Result is : " + resultInvoke);
        //}
