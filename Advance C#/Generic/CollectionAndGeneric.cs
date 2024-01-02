using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.Generic
{
    public class CollectionAndGeneric
    {
        public static void ListImplementation()
        {
            List<string> st1= new List<string> { "aral", "gazipur","Dhaka"};

            foreach (string s in st1)
            {
                Console.WriteLine(s);
            }
        }

        public static void ArrayListOperations() {
            List<int> myList = new List<int>();
            myList.Add(9);

            myList.Add(5);
            myList.Add(6);

            myList.Add(1);
            myList.Add(2);
            myList.Add(4);
                
            myList.Add(3);
                
          

           foreach (int i in myList)
            {
                Console.WriteLine($"{i}");
            }

            // Initial count
            Console.WriteLine("Initial count:{0}", myList.Count);

            // After using Remove() method
            myList.Remove(10);
            Console.WriteLine("2nd count:{0}", myList.Count);

            // After using RemoveAt() method
            myList.RemoveAt(4);
            Console.WriteLine("3rd count:{0}", myList.Count);

            // After using RemoveRange() method
            myList.RemoveRange(0, 2);
            Console.WriteLine("4th count:{0}", myList.Count);

            Console.WriteLine("Before Sorting", myList.Count);

            foreach(int i in myList)
            {
                Console.WriteLine(i);
            }

            myList.Sort();
            Console.WriteLine("After Sorting", myList.Count);

            foreach (int i in myList)
            {
                Console.WriteLine(i);
            } 
           

            // After using Clear() method
            myList.Clear();
            Console.WriteLine("5th count:{0}", myList.Count);
        }

        public static void SortListImp()
        {
            SortedList my_slist1 = new SortedList();

            // Adding key/value pairs in 
            // SortedList using Add() method
            my_slist1.Add(1.02, "This");
            my_slist1.Add(1.07, "Is");
            my_slist1.Add(1.04, "SortedList");
            my_slist1.Add(1.01, "Tuto");

            foreach (DictionaryEntry pair in my_slist1)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
            Console.WriteLine();

            // Creating another SortedList
            // using Object Initializer Syntax
            // to initialize sortedlist
            SortedList my_slist2 = new SortedList() {
                                  { "b.09", 234 },
                                  { "b.11", 395 },
                                  { "b.01", 405 },
                                  { "b.67", 100 }};

            foreach (DictionaryEntry pair in my_slist2)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }

        }

        static public void Main()
        {

            // Creating HashSet
            // Using HashSet class
            HashSet<string> myhash1 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");

            // Creating another HashSet
            // Using HashSet class
            HashSet<string> myhash2 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash2.Add("PHP");
            myhash2.Add("C++");
            myhash2.Add("Perl");
            myhash2.Add("Java");

            //  myhash1.UnionWith(myhash2);
            // Using IntersectWith method
            myhash1.IntersectWith(myhash2);
            foreach (var ele in myhash1)
            {
                Console.WriteLine(ele);
            }
        }

       
        // Creating SortedSet
        // Using SortedSet class
       // SortedSet<int> my_Set = new SortedSet<int>();



    }
}

//Contains: This method is used to check whether a SortedList object
//contains a specific key.
//ContainsKey: This method is used to check whether a SortedList object
//contains a specific key.
//ContainsValue: This method is used to check whether a SortedList object
//contains a specific value.
//How to remove elements from the SortedList?
//Clear: This method is used to removes all elements from a SortedList object.
//Remove: This method is used to removes the element with the specified
//key from a SortedList object.
//RemoveAt: This method is used to removes the element at the specified
//index of a SortedList object.