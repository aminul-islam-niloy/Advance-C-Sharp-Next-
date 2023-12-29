using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.Tuple
{
    public class TupleCreate
    {
        public static void TupleInitCreate()
        {
            Tuple<string> myTuple = new Tuple<string>("this is new string");
           
            Tuple<int, int, int, int, int, int, int> My_Tuple = 
        new Tuple<int,int, int, int, int, int, int>
                  (22, 334, 54, 65, 76, 87, 98);

            Console.WriteLine("Element 1: " + My_Tuple.Item1);
            Console.WriteLine("Element 2: " + My_Tuple.Item2);
            Console.WriteLine("Element 3: " + My_Tuple.Item3);
            Console.WriteLine("Element 4: " + My_Tuple.Item4);
            Console.WriteLine("Element 5: " + My_Tuple.Item5);
            Console.WriteLine("Element 6: " + My_Tuple.Item6);
            Console.WriteLine("Element 7: " + My_Tuple.Item7);

            var My_Tuple3 = ("Geeks", 2323, 'g');
            Console.WriteLine(My_Tuple3.Item1);

        }

        public static void TupleConstructure()
        {
            // Creating tuple with eight elements 
            // Using Tuple<T1, T2, T3, T4, T5, T6, 
            // T7, TRest>(T1, T2, T3, T4, T5, T6, 
            // T7, TRest) constructor 
            Tuple<int, int, int, int, int, int, int, Tuple<int>> My_Tuple = 
        new Tuple<int,int, int, int, int, int, int, Tuple<int>>
                  (22, 33, 44, 545, 55,88, 66, new Tuple<int>(77));

            Console.WriteLine("Element 1: " + My_Tuple.Item1);
            Console.WriteLine("Element 2: " + My_Tuple.Item2);
            Console.WriteLine("Element 3: " + My_Tuple.Item3);
            Console.WriteLine("Element 4: " + My_Tuple.Item4);
            Console.WriteLine("Element 5: " + My_Tuple.Item5);
            Console.WriteLine("Element 6: " + My_Tuple.Item6);
            Console.WriteLine("Element 7: " + My_Tuple.Item7);
            Console.WriteLine("Element 8: " + +My_Tuple.Rest.Item1);
        }

        public static void ValueTouple()
        {
            var valueTuple = ValueTuple.Create("this ", 3, "jkhkdj");
           // accept empty
            var emtty_Value = ValueTuple.Create();

            (int age, string name, string Lang) author = (23, "jhfgj", "C#");

            var author2 = (age: 23, name: "hjgfh", Lang: "C#");

            ValueTuple<int, string, string> author3 = (20, "Siya", "Ruby");

            Console.WriteLine("Age:" + author.Item1);
            Console.WriteLine("Name:" + author.Item2);
            Console.WriteLine("Language:" + author.Item3);

            // Store the data provided by the TouristDetails method
            var (Tourist_Id, Tourist_Name, Country) = TouristDetails();

            var Mylibrary = ValueTuple.Create(3456, "The Guide");
        }

        static public void Tuple8()
        {

            // Creating a value tuple 
            // Using Create method 
            var Mylibrary = ValueTuple.Create(3456, "The Guide", "R. K. Narayan",
                                 1958, "Philosophical novel", "English", "India",
                          ValueTuple.Create("Swami and Friends", "The Dark Room","Mr. Sampath", "Grandmother's Tale"));

            // Display the element of the given value tuple 
            Console.WriteLine("Book Details: ");
            Console.WriteLine("Book Id: {0}", Mylibrary.Item1);
            Console.WriteLine("Book Name: {0}", Mylibrary.Item2);
            Console.WriteLine("Author Name: {0}", Mylibrary.Item3);
            Console.WriteLine("Publication date: {0}", Mylibrary.Item4);
            Console.WriteLine("Gener: {0}", Mylibrary.Item5);
            Console.WriteLine("Language: {0}", Mylibrary.Item6);
            Console.WriteLine("Country: {0}", Mylibrary.Item7);
            Console.WriteLine("Other Novels: {0}", Mylibrary.Rest);
        }

        private static (object Id, object Name, object Country) TouristDetails()
        {
            return (384645, "Sophite", "USA");
        }
    }
}
