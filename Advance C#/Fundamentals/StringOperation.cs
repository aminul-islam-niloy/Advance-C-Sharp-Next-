using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Advance_C_.Fundamentals
{
    public class StringOperation
    {
        public static void StringInit()
        {
            String[] s1 = { "this ", "is", "new", "string" };

            foreach (string s in s1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine(s1[0]);

            Console.WriteLine();

            ArrayList s2 = new ArrayList();
            s2.Add("this");
            s2.Add("is");
            s2.Add("another");
            s2.Add("stiring");

            foreach (string s in s2)
            {
                Console.WriteLine(s);
            }
        }

        public static void CharactureInt() 
        {
            Char[] ch1 = { 'a', 'b', 'c', };

            String str1= new string(ch1);

            for (int i = 0; i < str1.Length; i++)
            {
                Console.WriteLine(str1[i]);
            }

            string s2 = new string('a', 40);
            Console.WriteLine(s2);
        }

        public static void StringFinding()
        {
            string messege = "this is me";

            int  start = messege.IndexOf(" ") + 1;
            int end = messege.IndexOf(" ",start)-start;
            string wd= messege.Substring(start,end);

            Console.WriteLine(wd);
        }

        public static void Verbatim_String()
        {
            string[] @for = { "C#", "PHP", "Java", "Python" };

            // as and for keywords is 
            // as an identifier
            // using @ symbol
            foreach (string @as in @for)
            {
                Console.WriteLine("Element of Array: {0}", @as);
            }
        }

        public static void StringOperations()
        {
            string s1 = "WelcomeTo";
            string s2 = "WelcomeT";
            bool result1, result2;

            // Equality operator return true 
            // as both string are equal 
            result1 = s1 == s2;

            // Inequality operator return false 
            // as both string are equal 
            result2 = s1 != s2;

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            //Char.IsDigit(str[i])

            // "20" is capacity 
            StringBuilder s = new StringBuilder("HELLO ", 20);

            s.Append("ghgfh");

            // after printing "GbfvExfbcEcbKS" 
            // a new line append 
            s.AppendLine("djkgbjhdfg");

            s.Append("dfdghfdkjgg");
            Console.WriteLine(s);

            // "vbfdgd" insert after 6th index 
            s.Insert(6, "gjhxgjv");

            StringBuilder sff = new StringBuilder("this is ", 20);

            // Replace "this" with "Geeks For" 
            sff.Replace("this", "this For");

        }
    }
}
