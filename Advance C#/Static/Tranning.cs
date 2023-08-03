using Advance_C_.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.Static
{
     class Tranning
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string SessionName { get; set; } 
        public int TotalHour { get; set; }  
        public static int NumOfTrinneer { get; set; }

     public static string GetInfo(string name, string description)
        {
            return $"Name is {name} and {description}";
        }

    }
}



        // all member and method in static class must be static but, 
        // we can use static member in non static class


        // important note is that we can't crate instance in the object section
        // if we want to call, we have to declar or call outside of object
        // we can't use non static property in the static method

       
        //Tranning.NumOfTrinneer = 25;
        //var resultis = Tranning.GetInfo("Angular ", "10");

        //Console.Write(resultis);

        //Tranning staticTrainning = new Tranning();
        //{

        //    staticTrainning.Id = 001;
        //    staticTrainning.Name = "Alpha";
        //    staticTrainning.SessionName = "Meeting";
        //    staticTrainning.TotalHour = 40;
        //    //staticTrainning.NumOfTrinneer = 20;
        //}


        //Tranning staticTrainning1 = new Tranning();
        //{
        //    staticTrainning1.Id = 002;
        //    staticTrainning1.Name = "C++";
        //    staticTrainning1.SessionName = "Zoom";
        //    staticTrainning1.TotalHour = 60;
        //    // staticTrainning1.NumOfTrinneer = 10;
        //}

