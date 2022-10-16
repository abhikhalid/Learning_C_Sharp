using ProjectA.TeamA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using PATA = ProjectA.TeamA ;
using PATB = ProjectA.TeamB ;

namespace C_Sharp_Beginners.NameSpaces
{
    //Part 18 - C# Tutorial - Namespaces

    // Namespaces are used to organize your program.

    // They also provide assistance in avoiding name clashes.

    internal class Program
    {
        //public static void Main()
        //{
        //    //ProjectA.TeamA.ClassA.Print();

        //    // 2 ways to resolve abmuiguity

        //   // ProjectA.TeamA.ClassA.Print();
        //   //ProjectA.TeamB.ClassA.Print();

        //    PATA.ClassA.Print();
        //    PATB.ClassA.Print();

        //}

    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA      
        { 
            public static void Print()
            {
                Console.WriteLine("Team A Print Method");
            }
        }
    }
}


namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method");
            }
        }
    }
}

