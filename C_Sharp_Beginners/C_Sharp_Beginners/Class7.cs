using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Beginners
{
    //    //Part 21 - C# Tutorial - Inheritance in c#

    //    // Why Inheritance ?
    //    // Pillars of Object Oriented Programming

    //    // 1. Inhertiance
    //    //  2. Encapsulation
    //    //  3. Abstraction
    //    //  4. Polymorphism

    //    // Inheritance is one of the priamry pillars of object oriented programming.
    //    // It allows code reuse.
    //    // Code reuse can reduce time and errors.

    //    // You will specify all the common fields, properties, methods in the base class
    //    // which allows reusability. In the derived class you will only have fields, proeperties and methods, that are specific to them. 

    //    // In the example, DerivedClass inhertis from ParentClass.
    //    // C# supprts only single class inheritance.
    //    // C# supports multiple interface inheritance.
    //    // Child class is a specialization of base class.
    //    // Base classes are automaticallyu instantiated before derived classes.
    //    // Parent Calss constructo executes before child Class constructor.

    //    public class Employee
    //    {
    //        public string FirstName;
    //        public string LastName;
    //        public string Email;

    //        public void PrintFullName()
    //        {
    //            Console.WriteLine(FirstName + " " + LastName);
    //        }
    //    } 

    //    public class FullTimeEmployee : Employee
    //    {
    //        public float YearlySalary;
    //    }

    //    public class PartTimeEmployee : Employee
    //    {
    //        public float HourlyRate;
    //    }

    //    class A : PartTimeEmployee
    //    {

    //    }

    //    internal class Class7
    //    {
    //        static void Main()
    //        {
    //            FullTimeEmployee FTE = new FullTimeEmployee();

    //            FTE.FirstName = "Khalid";
    //            FTE.LastName = "Mahmud";
    //            FTE.YearlySalary = 3434534;

    //            FTE.PrintFullName();


    //            PartTimeEmployee PTE = new PartTimeEmployee();

    //            PTE.FirstName = "Tahmina";
    //            PTE.LastName = "Khan";
    //            PTE.HourlyRate = 60;

    //            PTE.PrintFullName();

    //        }
    //    }


    /////////////////////////////////////////////////////
    
    public class ParentClss
    {
        public ParentClss()
        {
            Console.WriteLine("ParentClass Constructor called");
        }

        public ParentClss(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ChildClass : ParentClss
    {
        public ChildClass() : base("Derived class controlling Parent class")
        {
            Console.WriteLine("ChildClass Constructor called");

        }
    }

    public class MainClass { 
    
        //public static void Main()
        //{
        //    ChildClass c = new ChildClass();
        //}
    
    }



}
