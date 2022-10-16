using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Beginners
{
    internal class Program3
    {
        //Part 16 - C# Tutorial - Methods in c#

        //Why Methods ?

        // Methods are also called as functions. These terms are  used interchangeably.

        // Methods are extreamly useful because they allow you to define your logic once, and use it at many places.

        // Methods make the application maintenance of your application easier.

        //static void Main()
        //{
        //    Program3 program = new Program3();
        //    //program.EvenNumbers();

        //    //EvenNumbers();

        //    //or

        //    //Program3.EvenNumbers();

        //    Program3.EvenNumbers(30);

        //    Console.WriteLine("Sum = {0}", program.Add(10, 20));

        //}

        //public void EvenNumbers()
        //{
        //    int Start = 0;

        //    while(Start <= 20)
        //    {
        //        Console.WriteLine(Start);
        //        Start += 2;
        //    }
        //}


        //public static void EvenNumbers()
        //{
        //    int Start = 0;

        //    while (Start <= 20)
        //    {
        //        Console.WriteLine(Start);
        //        Start += 2;
        //    }
        //}

        public int Add(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;  
        }

        public static void EvenNumbers(int Target)
        {
            int Start = 0;

            while (Start <= Target)
            {
                Console.WriteLine(Start);
                Start += 2;
            }
        }

    }
}
