using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Beginners
{
    //Part 17 - C# Tutorial - Method parameters

    //The 4 types of method parameteres

    // Value Paremeteres : Creates a copy of the parameter passed, so modification does not affect each other

    // Reference Parameteres : The ref method parameter keyword on a method parameter causes a method to refer to the same variable
    // that was passed into the method. Any changes made to the parameter in the method will be reflected in that variable when control
    // passes back to the calling method.

    // Out Parameteres : Use when you want a method to return more than one value.

    // Parameter Arrays : The params keyword lets you specify a method parameter that takes a variable number of arguments.
    // You can send a comma seperated list of arguments, or an array, or no arguments. Params keyword should be
    // the last one in a method declaration and only one params keyword is permitted in a method declaration.

    // Method parameters vs Method Arguments

    internal class Class4
    {
        //static void Main()
        //{
            //int i =0;

            //SimpleMethod(i);

            //SimpleMethod(ref i);

            //Console.WriteLine(i);

            //int Total = 0;
            //int Product = 0;

            //Calculate(10, 20, out Total, out Product);

            //Console.WriteLine("Sum = {0} && Product = {1}",Total,Product);



            //////////////////////////////////////
            ///
        //    int[] Numbers = new int[3];

        //    Numbers[0] = 101;
        //    Numbers[1] = 102;
        //    Numbers[2] = 103;


        //    ParamsMethod(Numbers);

        //}

        //public static void SimpleMethod(int j)
        //{
        //    j = 101;
        //}

        public static void SimpleMethod(ref int j)
        {
            j = 101;
        }


        //when you want to return more than two value from a method, then output parameter is the solution
        public static void Calculate(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }

        //if you want to make your parameters optional, use params keyword

        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0} elements ", Numbers.Length);

            foreach(int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }

        //follwing signature are not allowed

        // public static void ParamsMethod(params int[] Numbers, int X)

        //    public static void ParamsMethod(params int[] Numbers, params string[] Names)



    }
}
