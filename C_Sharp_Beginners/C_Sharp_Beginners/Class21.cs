using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Delegates
// A delegate is a type safe function pointer

// What is a delegate?
// A delegate is a type safe function pointer. That is, it holds a reference (Pointer) to a function
// The Signature of the delegate must match the signature of the function the delegate point to
//otherwise, you get a compiler error. This is the reason delegates are called as tyep safe function pointers.

// A delegate is similar to a class. You can create an instance of it, and when you do so, you pass in the function anme as a parameter to the delegate constructor,
// and it is to this function the delegate will point to.

//Try to remember delegate syntax :  Delegate syntanx look very much similar to a method with a delegate keyword.

namespace C_Shsarp_Beginners
{

    //public delegate void HelloFunctionDelegate(string message);

    //internal class Class21
    //{
    //    public static void Main()
    //    {
    //        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);

    //        del("Hello from Deligate");
    //    }   

    //    public static void Hello(string strMessage)
    //    {
    //        Console.WriteLine(strMessage);
    //    }

    //}


    //Part 37 - C# Tutorial - Delegates usage in c#
    internal class Class21
    {
        //public static void Main()
        //{
        //    List<Employee> employees = new List<Employee>();

        //    employees.Add(new Employee() { ID = 101, Name = "Khalid", Salary = 5000, Experience = 5 });
        //    employees.Add(new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
        //    employees.Add(new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 6 });
        //    employees.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });


        //    //IsPromotable isPromotable = new IsPromotable(Promote);

        //    //Employee.PromoteEmployee(employees, isPromotable);

        //    //or 


        //    Employee.PromoteEmployee(employees, emp => emp.Experience >=5);

        //}

        //public static bool Promote(Employee emp)
        //{
        //    if (emp.Experience >= 5) return true;
        //    return false;
        //}

    }

    delegate bool IsPromotable(Employee empl);



    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
        {
            foreach(Employee employee in employeeList)
            {
                //if(employee.Experience >= 5)
                //{
                //    Console.WriteLine(employee.Name + " promoted");
                //}

                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }

    }
    
}
