using Advance_C_.Deligates;
using Advance_C_.Enum;
using Advance_C_.ExtrnsionMethod;
using Advance_C_.Generic;
using Advance_C_.Object_Initializer;
using Advance_C_.OOP.cardinality_constraints;
using Advance_C_.OOP.Class_and_Object;
using Advance_C_.Static;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Advance_C_
{
    internal class Program
    {
        // delegate init
        public delegate int Calculator( int num1, int num2 );


        // multiple and generic delegate 
        public delegate void SMS(string name);
        public delegate void PrintHandler<T,U>(T param, U status);

        // Func delegate init
       // public delegate Tresult Func<in T, out  Tresult>(T param);

        static void Main(string[] args)
        {


// class and object 

             Person person = new Person();
            // here is and important things:
            // Person is class and person is object create
            // new Person() is and reference of Main class
            // in premetive data copy but not reference copy



            //  string Name= Console.ReadLine();
            //person.FirstName(Name);
            //// person.Name = Name;
            //person.PersonId = 1;
            //person.Age = 30;
            //person.PersonInfo();



            //Person person2 = new Person();
            //person2.Age = 55;
            //person2.FirstName(Name);
            //person2.PersonId = 22;

            //person2.PersonInfo();

            //Person person3= new Person();
            //person3 = person2;
            //person3.PersonInfo();

            // setter and getter 
            //auto properties
            //  SeeterAndGetter personInfo = new SeeterAndGetter();

            //  personInfo.FirstName = Console.ReadLine();
            //  string nameInfo = personInfo.FirstName;
            //  personInfo.middleName = "Islam";
            //  personInfo.lastName = "Niloy";
            ////  personInfo.PrintDetails();

            //  personInfo.SessionCode = 7654;
            //  int section = personInfo.SessionCode;
            //  // we can control access property by auto properties.
            //  // we have to add private before set and get

            ////  Console.WriteLine(nameInfo);


            //  SeeterAndGetter seeterAndGetter = new SeeterAndGetter();


            // constructor and it's uses
            //StudentConstructor studentConstructor = new StudentConstructor("AMINUL","ISLAM","NILOY");
            //studentConstructor.PrintStudentDetails();
            //StudentConstructor studentConstructorTest = new StudentConstructor("niloy","ft");
            //studentConstructorTest.PrintStudentDetails();

// Cardinaty Constrain
// has a relationship; one to one association
    // feild level othe class is used.
    // address class inside person class

             Address address = new Address();
                address.RoadNo = " Boikali road";
                address.Area = "Khalishpur";
                address.PostCode = "9000";
                address.District = "Khulna";
            // here one object but many reference 

            address.AddressPrint();


            StudentConstructor studentConstructor = new StudentConstructor();
            studentConstructor.PresentAddress = address;

 // data decrept
            Address personAddress = studentConstructor.PresentAddress;

            string houseNum = personAddress.HouseNo;
            string roadNum=personAddress.RoadNo;
            string area= personAddress.Area;
            string postCode = personAddress.PostCode;

            string district = studentConstructor.PresentAddress.District;

            // if we use other class address used in field lavel in other class it's assiociation one to one



// One to many relation implementation in c


            Course course1   = new Course();
            course1.Courseecode = "CSE-01";
            course1.Coursetitle = "programming C#";
            course1.Coursecredit = 3.5;

            Course course2 = new Course();
            course2.Courseecode = "CSE-02";
            course2.Coursetitle = "programming with java";
            course2.Coursecredit = 3;

            Course course3 = new Course();
            course3.Courseecode = "CSE-03";
            course3.Coursetitle = "java OOP";
            course3.Coursecredit = 2.5;

            //List<Course> coursesList = new List<Course>();
            //coursesList.Add(course1);
            //coursesList.Add(course2);
            //coursesList.Add(course3);

            Department department1 = new Department();

            department1.NamesOfDept = "Computer Science and Enginnering";
            department1.DeptCode= "CSE111";
            // department1.Courses= coursesList;


            department1.Courses.Add(course1);
            department1.Courses.Add(course2);
            department1.Courses.Add(course3);


            //foreach(var coursesListPrint in department1.Courses)
            //   {
            //       Console.WriteLine(coursesListPrint.Coursetitle +" \n");
            //   }

            //foreach (var coursesListPrint in department1.Courses)
            //{
            //    Console.WriteLine(coursesListPrint.GetCourseInfo() + " \n");
            //}

           Console.WriteLine(department1.GetCourseInfo());   






            //Object initializer in c# 
            Studentinit student = new Studentinit()
            {
                Id = 1,
                Name = "Amin",
                Address = "Dhaka",
                Age = 10
            };

            //string name = student.Name;
            //Console.WriteLine(name);

//collection inintializer in c#
            Studentinit student1 = new Studentinit() { Id = 1, Name = "Amin", 
                                                       Address = "Dhaka", Age = 10 };
            Studentinit student2 = new Studentinit() { Id = 2, Name = "Akij", Address = "Dhaka", Age = 20 };
            Studentinit student3 = new Studentinit() { Id = 3, Name = "Jamil", Address = "Dhaka", Age = 40 };
            Studentinit student4 = new Studentinit() { Id = 4, Name = "Asgar", Address = "Dhaka", Age = 60 };


// add student list without add method.
            List<Studentinit> studentsList1 = new List<Studentinit>()
            {   student1,
                student2,
                student3,
                student4 };
               

            //foreach (var PrintStudent in studentsList1)
            //{
            //    Console.WriteLine(PrintStudent.Name + "\n");
            //    Console.WriteLine(PrintStudent.Age + "\n");
            //}


  // there are another way to initilaze  collection.
            // there in collection section we can init object and add to the list
            List<Studentinit> students = new List<Studentinit>()
            {
                new Studentinit() {Id=33, Age=10},
                new Studentinit() {Id=43, Age=20},
                new Studentinit() {Id=53, Age=30}
            };

            // it's regular system to add value on the list

            //   List<Student> studentsList1 = new List<Student>()
            //studentsList1.Add(student1);
            //studentsList1.Add(student2);
            //studentsList1.Add(student3);
            //studentsList1.Add(student4);

            //foreach (Student Student in studentsList1)
            //{
            //    Console.WriteLine(Student.Name + "\n");
            //    Console.WriteLine(Student.Age + "\n");
            //}




// Dynamic type datatype in c#

         // ExpandoObject is an important aspect in this section.
         // using this we can add new property without 
         // adding property

            dynamic variable1 = 1;
         //   Console.WriteLine(variable1.GetType());
                    variable1 = "This is me";
           /// Console.WriteLine(variable1.GetType());


            //here  we can assign new type as my choice without adding
            dynamic Values = new ExpandoObject();
            Values.id = 12345;
            Values.name = "ajik";
            Values.address = "khulna";
            Values.age = 30;
            Values.gender = "male";


            //   Console.WriteLine(variable1);



//anonymus data type
            var anonymusType = new
            {
                Name = "AMIN",
                id = 44364,
                age = 16

            };

            //Console.WriteLine(anonymusType.Name);
            //  Console.WriteLine(anonymusType.age.GetType());

            
            
            //anonymus array list
            //it's not possible to add new list to this anonymus array.
            // as example if you want to add new list to the array as tredational system it gives error
            // another  if you want to set differrnt parameter
            // it's not possible . you have to add same parameter on array

            var anonymusArray = new[]
            {
                new{ Name= "amin", age= 10,  balance = 1055554.7},
                new{ Name= "jamil", age= 150,  balance = 1550.7},
                new{ Name= "joynul abedin", age= 90,  balance = 190.7}
            };

 //search an value form arraylist

            var namesList = anonymusArray.Where(c=> c.Name.StartsWith("j")).ToList();

            //foreach(var anonymusTest in anonymusArray) 
            //{
            //    Console.WriteLine(anonymusTest.Name );
            //    Console.WriteLine(anonymusTest.balance);

            //}


 //exception handling

            // DivisionNumber divisionNumber = new DivisionNumber();
            //divisionNumber.division(76686725,0);


            // enum example in c#

            // EnumExample example = new EnumExample();

            //  Console.WriteLine((int)EnumExample.Delivery);
            //  Console.WriteLine(EnumExample.OrderConfirm);
            //  Console.WriteLine((int)EnumExample.OrderConfirm);

            int enumStatus = 1;
            if( enumStatus == (int)EnumExample.OrderPlace)
            {
         
            }
            else if( enumStatus == (int )EnumExample.OrderConfirm) {
               // Console.WriteLine("Order confirmed");
            }
            else
            {
               
            }

            //  Console.WriteLine($"order Status is :  {enumStatus}");



            //int[] numbers = { 2, 3, 4, 5 };
            //var squaredNumbers = numbers.Select(x => x * x);
            //Console.WriteLine(string.Join(" ", squaredNumbers));
            
            // Output:
            // 4 9 16 25


// static in c#
            // all member and method in static class must be static but, 
            // we can use static member in non static class


            // important note is that we can't crate instance in the object section
            // if we want to call, we have to declar or call outside of object
            // we can't use non static property in the static method

            Tranning.NumOfTrinneer = 25;
            var resultis = Tranning.GetInfo("Angular ", "10");

          //  Console.Write(resultis);

            Tranning staticTrainning = new Tranning();
            {
               
                staticTrainning.Id = 001;
                staticTrainning.Name = "Alpha";
                staticTrainning.SessionName = "Meeting";
                staticTrainning.TotalHour = 40;
                //staticTrainning.NumOfTrinneer = 20;
            }


            Tranning staticTrainning1 = new Tranning();
            {
                staticTrainning1.Id = 002;
                staticTrainning1.Name = "C++";
                staticTrainning1.SessionName = "Zoom";
                staticTrainning1.TotalHour = 60;
               // staticTrainning1.NumOfTrinneer = 10;
            }


 // Generic in c#

            // it's an type data type.

            // boxing and unboxing 
            // premetive to reference type conversion
            // unboxing is that reference type to premetive type
            // it eleminate problem of boxing and unboxing 


           

            GenericExample<int> generic_Student = new GenericExample<int>();
            {
                generic_Student.Name = "Ahmed Jinalni";
                generic_Student.Sucess = 1;

            }

            GenericExample<string> generic_Student1 = new GenericExample<string>();
            {
                generic_Student1.Name = "Ahmed Hossain";
                generic_Student1.Sucess = "pass";


            }

           
            GenericExample<double> generic_Student2 = new GenericExample<double>();
            {
                generic_Student2.Name = "Ahmed bacca";
                generic_Student2.Sucess = 14.477;
              

            }


            Generic_Student<string,double> DoubleGeneric = new Generic_Student<string, double>();
            {
                DoubleGeneric.Name = "Ahmed bacca";
                DoubleGeneric.Sucess = " Passed ";
                DoubleGeneric.grade = 2.99;



            }


            //PrintResult(DoubleGeneric);

            //PrintResult(generic_Student1);
            //PrintResult(generic_Student2);





 // Deligates : Declar, target method, invoke
         // pass method through Method 
         // even handling 
         // call by method 

        // we can attach more and more  same signature method in the delegate


            SingleDelegateStudent deligateExample = new SingleDelegateStudent();
            //Calculator calculatorhandaler = new Calculator(Add);
            
           // Calculator calHandaler = Add;
          


          //  InvokeDelegate(calHandaler,30,10);

           // Calculator calHandaler1 = Sub;

           // InvokeDelegate(calHandaler1, 30, 10);

            //int resultsDeli=  calHandaler.Invoke(19, 49);
            // int resultsDeli = calHandaler(20,10);

            // Console.WriteLine(resultsDeli);

            deligateExample.Name = "Thus Harold";

// Anonymus  Delegate and lembda expression 

//A delegate is a type that represents references to methods with a particular
//parameter list and return type.

            //Calculator calHandaler = delegate (int firstNum, int secoundNum)
            //{
            //    return firstNum + secoundNum;
            //};

            //Lambda expression

            Calculator calHandaler = ( firstNum, secoundNum) => firstNum + secoundNum;
            // in lambda expression parameter list               such that           method body
            // if i use second bracket then we have to use return 




            // InvokeDelegate(calHandaler, 30, 10);

// Multiple delegate example in c#

                    //SMS smsExample = Hello;
                    //    smsExample += GoodBye;
           
                    //    smsExample("Niloy");

            // also we can declare as
            //  SMS smsExample2 = GoodBye;
            // smsExample1("Niloy");

            // also there are others way

            //SMS Example = Hello;
            //SMS Example1 = GoodBye;
            //SMS Example2 = Example + Example1;
            //   Example2("Aminul Islam Niloy");



 //Generic delegates

            //PrintHandler<string,string> printHandler = Hello;
            //printHandler += GoodBye;
            //printHandler.Invoke("Niloy ft aminul","Confirm");

            //PrintHandler<bool, string> printHandler1 = BoolReturn;
            //printHandler1.Invoke(true, "Recived");

// Func Delegete in c# 

            Func<int, int, int> FuncGenericExa = Add;
            int FuncResult = FuncGenericExa.Invoke(10, 40);

       //     Console.WriteLine( "Func return result is : "+ FuncResult);

          //  Func<int> additionHandler = () => 10;

// Action Delegate 
// it has no return type so  function call time variable data is not allowed in action

            // Action using lambda expresion

        //    Action<int ,int> SumReturnValue= (int num1,  int num2) => Console.WriteLine( num1 + num2 );

           // SumReturnValue.Invoke(66, 33);


//Predicate delegator 

            //List<string> name = new List<string>();

            //name.Add("This is phone");
            //name.Add("A macbook");
            //name.Add("Pen");
            //name.Add("This is Mobile");
            //name.Add("This is Telephone");

            //Predicate<string> alphaSearch = x=> x.StartsWith("This");
            //var data = name.FindAll(alphaSearch);

            //foreach ( var item in data )
            //{
            //    Console.WriteLine(item);
            //}


// Extension method from a class without cration or writing code
// method must be static and it must be used with this
            ExtensionMethod extensionMethod = new ExtensionMethod();
            extensionMethod.Name = "Amin";
            extensionMethod.Description = "Work done";
            extensionMethod.Id = 987654;

           // string info= extensionMethod.GetInfo();
          //  Console.WriteLine(info);




 // Reflection 

           var  StudentClassInfo  = typeof(Studentinit);

            string assemblyName = StudentClassInfo.Assembly.FullName;
           
           // Console.Write(assemblyName);
           
           // var methods= StudentClassInfo.GetMethods();

           // foreach ( var method in methods)
           // {
           //    // Console.WriteLine("Return type is : "+method.ReturnType+ " Method name is: "+ method.Name);
           // }

           //// Console.WriteLine("\n");

           // var GetAllProperties = StudentClassInfo.GetProperties(System.Reflection.BindingFlags.NonPublic|
           //     System.Reflection.BindingFlags.Instance);

           // foreach (var getAllresult in GetAllProperties)
           // {
           //     Console.WriteLine(getAllresult.Name);
           // }

           // Console.WriteLine("\n");

           // var GetProperties = StudentClassInfo.GetProperties();

           // foreach (var getAllresult in GetProperties)
           // {
           //     Console.WriteLine(getAllresult.Name);
           // }




            Console.ReadKey();

             
        }

        public static bool IsChackName(string name)
        {
            if(name.StartsWith("This"))
            {
                return true;
            }
            return false;
        }

       

        public static void PrintResult<T> (GenericExample<T> Exxample)
        {
            //Console.WriteLine(Exxample.Name + " is  : " + Exxample.Sucess);
        }

        public static void PrintResult<T,U>(Generic_Student<T,U> GenericMethod  )
        {
           // Console.WriteLine(GenericMethod.Name + " has  : " + GenericMethod.Sucess +
                                           //   "  with " + GenericMethod.grade +" Grade  ");
        }


        public class Generic_Student2<T>
        {
            public string Name { get; set; }
            public T Sucess { get; set; }
        }


        public class Generic_Student<T,U>
        {
            public string Name { get; set; }
            public T Sucess { get; set; }
            public U grade { get; set; }
        }



  // delegates method 
        static int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        static int Sub(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }


       // public delegate int Calculator(int num1, int num2);

        public static void InvokeDelegate(Calculator calHandaler, int firstNum, int secondNum)
        {
            int resultInvoke = calHandaler.Invoke(firstNum, secondNum);
          //  Console.WriteLine("Result is : " + resultInvoke);
        }


        public static void Hello(string message, string Status)
        {
           Console.WriteLine("Hello " + message);
        }

        public static void GoodBye(string message, string Status)
        {
           Console.WriteLine("Good Bye " + message);
        }

        public static void BoolReturn(bool value, string Status)
        {
            Console.WriteLine("Yes it's true   "+ value + " Status is " + Status);
        }





    }
}
