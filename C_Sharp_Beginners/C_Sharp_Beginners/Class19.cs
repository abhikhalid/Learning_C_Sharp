using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Part 33 - C# Tutorial - Difference between abstract classes and interfaces

// Abstract classes vs Interfaces

// Abstract classes can have implementation for some of its members (Methods), but the interface 
// can not have implementation for any of its members.

//Interfaces can not have fields where as abstract class can have field.

// An interface can inherit from another interface only and can not inherit from an abstract class, where as
// an asbtract class can inherit from another abstract class or another interface.

// A class can inherit from multiple interfaces at the same time, where as a class can not inherit from multiple classes at the same time.

// Abstract class members can have access modifiers where as interface members can not have access modifiers.




/////////////////////////////////////////////////////


//Part 34 - C# Tutorial - Problems of multiple class inheritance

namespace C_Sharp_Beginners
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B Implementation");
        }
    }
    
    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C Implementation");
        }
    }

    //compiler error due to multiple inheritance
    //class D : B, C
    //{

    //}

    internal class Class19
    {
        //static void Main()
        //{
        //    D d = new D();

        //    d.Print(); // ?? (diamond problem)
        //    d.Print(); // ?? (diamond problem)
        //}

    }
}
