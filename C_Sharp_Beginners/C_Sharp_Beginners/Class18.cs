using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Abstract Classes

// The abstract keyword is used to create abstract classes.

// An abstract class is incomplete and hence can not be instantiated.

// An abstract class can only be used as base class.

// An abstract class can not be sealed.

// An abstract class may contain abstract members (methods, properteis, indexers and events) but no mandatory.

// A non-abstract class derived from an abstract class must provide implementation for all inherited abstract members.

// If a class inherits an abstract class, there are 2 options available for that class.

// Option 1: Provide implementation for all the abstract members inherited from the base abstract class.

// Option 2: If the class does not wish to provide implementation for all the abstract memberse inherited from the abstracvt class, then the class
// has to be marked as abstract.


namespace C_Shaarp_Beginners
{
    public abstract class Customer
    {
        public abstract void Print();
    }

    //internal abstract class Program : Customer
    //{
    //    static void Main()
    //    {

    //    }

    //}

    //or

    internal sealed class Program : Customer
    {
       
        public override void Print()
        {
            Console.WriteLine("Print Method");
        }

        //static void Main()
        //{
        //    Customer c = new Program();
        //    c.Print();
        //}

    }

    ////////////////////////////////////////////

    //public abstract class Customer
    //{
    //    public  void Print()
    //    {

    //    }
    //}
}
