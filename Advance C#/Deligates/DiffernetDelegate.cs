using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.Deligates
{
    internal class DiffernetDelegate
    {

    }
}


        //Func<int, int>

        /// Func Delegete in c# 

        //            Func<int, int, int> FuncGenericExa = Add;
        //int FuncResult = FuncGenericExa.Invoke(10, 40);

        //     Console.WriteLine( "Func return result is : "+ FuncResult);

        //  Func<int> additionHandler = () => 10;



        //Action no return type





        // Action Delegate 
        // it has no return type so  function call time variable data is not allowed in action

        // Action using lambda expresion

        //    Action<int ,int> SumReturnValue= (int num1,  int num2) => Console.WriteLine( num1 + num2 );

        // SumReturnValue.Invoke(66, 33);



        // Predicate delegetor


        //List<string> name = new List<string>();

        //name.Add("This is phone");
        //name.Add("A macbook");
        //name.Add("Pen");
        //name.Add("This is Mobile");
        //name.Add("This is Telephone");

        //Predicate<string> alphaSearch = IsChackName;
        //var data = name.FindAll(alphaSearch);

        //foreach (var item in data)
        //{
        //    Console.WriteLine(item);




        //public static bool IsChackName(string name)
        //{
        //    if (name.StartsWith("This"))
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //  Predicate<string> alphaSearch = x=> x.StartsWith("This");


