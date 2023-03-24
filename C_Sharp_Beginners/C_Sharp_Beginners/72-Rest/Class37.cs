using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_Sharp_Beginners._72_Rest
{
    //Part 88 - ThreadStart delegate
    class Class37
    {
        public static void Main()
        {
            //Thread t1 = new Thread(Number.PrintNumbers);

            //We can rewrite the above line using ThreadStart delegate as shown below.
            Thread t1 = new Thread(new ThreadStart(Number.PrintNumbers));
            t1.Start();

            //We can also rewrite the same line using delagate() keyword as shown below.
            Thread t2 = new Thread(delegate () { Number.PrintNumbers(); });
            t2.Start();
        }
    }

    class Number
    {
        public static void PrintNumbers()
        {
            for(int i=0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
