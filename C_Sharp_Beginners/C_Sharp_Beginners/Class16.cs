using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// We create interface using interface keyword. Just like classes interface also contain properties,
// methods, deligates or events. but only declarations and no implementations.

// It is a compile time error to provide implementation for any interface memebr.

// Interface members are public by default. and they do not allow explicit access modifiers

// Interface can not contain fields.

// If a class or a struct from an interface, It must provide implementation for all interface members. Otherwise, we get a compiler error.

// A classs or struct can inherit from more than one interface at the same time. but where as, a class can not inherit from more than once class at the same time.

// Interfaces can inherit from other interfaces. A class that inherits this interface must provide implementation for all interface members in the entire interface inheritance chain.

// We can not create an instance of interface, but an interface reference variable can point to a derived class object.



namespace C_Sharp_Begginners
{
    interface ICustomer1
    {
        void Print1();
    }

    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }

    interface I2
    {
        void I2Method();
        
    }

    class Customer : ICustomer2, I2
    {
        public void I2Method()
        {
            Console.WriteLine("I2 Method");
        }

        public void Print1()
        {
            Console.WriteLine("Interface Print1 Method");
        }

        public void Print2()
        {
            Console.WriteLine("Interface Print2 Method");
        }
    }

    internal class Class16
    {
        //static void Main()
        //{
        //    Customer customer = new Customer();
        //    customer.Print1();
        //    customer.Print2();

        //    ICustomer1 customer2 = new Customer();

        //    customer2.Print1();
        //}
    }
}
