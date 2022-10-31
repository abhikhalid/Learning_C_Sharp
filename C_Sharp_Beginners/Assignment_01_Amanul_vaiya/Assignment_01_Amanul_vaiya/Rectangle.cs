using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_Amanul_vaiya
{
    internal class Rectangle : Shape
    {
        public float Length { get; set; }

        public float Width { get; set; }

        public override void Area()
        {
           Console.WriteLine("Give me the length of a rectange");
           
           Length = float.Parse(Console.ReadLine());


           Console.WriteLine("Give me the width of a rectange");

           Width = float.Parse(Console.ReadLine());


           float area = Length * Width;

           Console.WriteLine("\nArea of a Rectange is : {0}", area);
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle with Width {0} and Length {1}\n", Width, Length);

        }
    }
}
