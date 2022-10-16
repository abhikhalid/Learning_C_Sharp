using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Part 35 - C# Tutorial - Multiple class inheritance using interfaces

// Implementation of multiple class inhertiance using interfaces

namespace C_Shharp_Beginners
{
    interface IA
    {
        void AMethod();
    }

    class A : IA
    {
        public void AMethod()
        {
            Console.WriteLine("A");
        }
    }

    interface IB
    {
        void BMethod();
    }

    class B : IB
    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }

    class AB : IA,IB
    {
        A a = new A();
        B b = new B();
         
        public void AMethod()
        {
            a.AMethod();
        }
        public void BMethod()
        {
            b.BMethod();
        }

    }

    internal class Class20
    {
        //static void Main()
        //{
        //    AB ab = new AB();
        //    ab.AMethod();
        //    ab.BMethod();
        //}
    }
}
