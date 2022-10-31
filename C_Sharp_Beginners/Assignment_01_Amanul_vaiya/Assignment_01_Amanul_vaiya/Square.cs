using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_Amanul_vaiya
{
    internal class Square : Shape
    {
        public float Length { get ; set; }
        public override void Area()
        {
            Console.WriteLine("Give me a side of a square....");

            Length = float.Parse(Console.ReadLine());   

            Console.WriteLine("Area of a square is : {0}\n", (this.Length * this.Length));
        }

        public override void Draw()
        {
           
        }
    }
}
