using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_Amanul_vaiya
{
    internal class Circle : Shape
    {
        public float Radius { get; set; }
        public float area { get; set; }

        public override void Area()
        {
            Console.WriteLine("Give me the radius of a cirlce");

            Radius = float.Parse(Console.ReadLine());

            area = 3.1416f * this.Radius * this.Radius;

          
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a Cirlce with radius {0}\n",Radius);
            Console.WriteLine("\nThe Area of a Circle is : {0}", area);
        }
    }
}
