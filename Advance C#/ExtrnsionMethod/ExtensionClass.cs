using Advance_C_.ExtrnsionMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.ExtrnsionMethod
{
    static class ExtensionClass
    {
        public static string GetInfo(this ExtensionMethod exObjectmethod)
        {
            return "Id  is "+ exObjectmethod.Id+ " Name is "+exObjectmethod.Name+ " Desc is "+ exObjectmethod.Description;    
        }
    }
}



// Extension method from a class without cration or writing code
// method must be static and it must be used with this
//ExtensionMethod extensionMethod = new ExtensionMethod();
//extensionMethod.Name = "Amin";
//extensionMethod.Description = "Work done";
//extensionMethod.Id = 987654;

//string info = extensionMethod.GetInfo();
//Console.WriteLine(info);