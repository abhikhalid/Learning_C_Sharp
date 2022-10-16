using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Beginners
{
    //Part 25 - C# Tutorial - Method overloading in c#

    // Function overlaoding and Method overloadingf terms are used interchangeably.

    // Method overloading allows a class to have multiple methods with the same  name but with a
    // different signature. So, in C# functions can be overloaded based on the number, type (int,float)
    // etc and kind (Value, Ref or Out) nof parameters

    //The signature of a method consists of the name of the method and the type, Kind (value, reference, or output)
    // and the number of its formal parameters. The signature of a method does not include the return type and the params modifier.
    // So, it is not possible to overload na function, just based on the return type or params modifier.

    //it is not overload based on params keyword



    internal class Class11
    {
        //public static void Main()
        //{
           
        //}

        public static void Add(int FN, int SN,params int[] TN)
        {
            //Console.WriteLine("Sum = {0}", FN + SN + TN);
        }

        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN  +TN);
        }
        
        public static void Add(int FN, int SN, out int Sum)
        {
            Console.WriteLine("Sum = {0}", FN + SN);

            Sum = FN + SN;
        }






        public static void Add(int FN, int SN)
        {
            Console.WriteLine("Sum = {0}",FN+SN);
        }

        public static void Add(float FN, float SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        public static void Add(int FN, float SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }





    }
}
