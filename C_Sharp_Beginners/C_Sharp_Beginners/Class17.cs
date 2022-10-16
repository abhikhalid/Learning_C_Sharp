using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Part 31 - C# Tutorial - Explicit interfaces implementation

// A class inherits from 2 interfaces and both the interfaces have the same method name. 
// How should the class implement the method for both the interfaces?

// We are using Explicit Interface implementation technique to solve this problem.

// Note : When a class explicitly implements, an interface member, the interface member can no longer be accessed through reference variable.
//but only through the interface reference variable.

// Access modifiers are not allowed on explicity implemented interface members.


namespace C_Sharp_Beginners
{
    //interface I1
    //{
    //    void InterfaceMethod();
    //}

    //interface I2
    //{
    //    void InterfaceMethod();
    //}
    //internal class Class17 : I1, I2
    //{

    //    public void InterfaceMethod()
    //    {
    //        Console.WriteLine("I1 Interface Method");
    //    }

    //    static void Main()
    //    {
    //        Class17 P = new Class17();

    //        //P.InterfaceMethod();

    //        ((I1)P).InterfaceMethod();

    //        ((I2)P).InterfaceMethod();

    //    }


    //}

    ////////////////////////////////////////////////////////

    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }
    internal class Class17 : I1, I2
    {

        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }
        
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }

        //default implementation
        public void InterfaceMethod()
        {

        }

        //static void Main()
        //{
        //    // Class17 P = new Class17();

        //    //P.InterfaceMethod();

        //    //   ((I1)P).InterfaceMethod();

        //    //  ((I2)P).InterfaceMethod();

        //    // the you can not say : P.InterfaceMethod(); it will be a ambuiguity


        //    ////////////////////////////////////////


        //    I1 i1 = new Class17();
        //    I2 i2 = new Class17();

        //    i1.InterfaceMethod();
        //    i2.InterfaceMethod();


        //}


    }


}
