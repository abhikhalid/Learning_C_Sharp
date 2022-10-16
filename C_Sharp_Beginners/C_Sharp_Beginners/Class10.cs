using System;

//Part 24 - C# Tutorial - Difference between method overriding and method hiding.avi


namespace C_Sharp_Beginners
{
    //Method Overloading

    // In method overriding a base class reference variable pointing to a child class object, will involve the overriden method in the Child Class.

    //public class BaseClass
    //{
    //    public virtual void Print()
    //    {
    //        Console.WriteLine("I am a Base Class Print Method");
    //    }
    //}

    //public class DerivedClass : BaseClass
    //{

    //    //overriding a method

    //    public override void Print()
    //    {
    //        Console.WriteLine("I am a Derived Class Print Method");
    //    }

    //}

    //internal class Class10
    //{
    //    static void Main()
    //    {
    //        BaseClass b = new DerivedClass();

    //        b.Print();
    //    }
    //}


    //Method Hiding

    // In method hiding a base class reference variable pointing to a child class object, will involve the hidden method in the Base Class.

    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Base Class Print Method");
        }
    }

    public class DerivedClass : BaseClass
    {

        //hiding a method

        public new void Print()
        {
            Console.WriteLine("I am a Derived Class Print Method");
        }

    }

    internal class Class10
    {
        //static void Main()
        //{
        //    BaseClass b = new DerivedClass();

        //    b.Print();

        //    DerivedClass d = new DerivedClass();
        //    d.Print();

        //}
    }
}
