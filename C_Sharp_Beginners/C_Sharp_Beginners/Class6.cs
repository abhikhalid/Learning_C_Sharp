using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Beginners
{
    //Part 20 - C# Tutorial - Static and instance class members

    // When a class membner includes a static modifier, the member is called as static member.
    // When no static modifier is present the member is called as non static member or instance member.

    // Static members are invoked using class name, where as instance member are invoked using instances (objects) of the class.

    // An instance member belongs to specific instance (object) of a class. If I create 3 objects of a class, I will have 3 sets of instance of members
    // members in the memory, where as there will ever be only one copy of a static memebr. no matter how many instances of a class are created.


    // Static Constructor

    // Static constrcutors are used to initalize static fields in a class.
    // You declare a static constructor by using the keyword static in front of the constructor name.

    // Static Constructor is called only once, no matter how many instances you create.
    // Static constructors are called before instance constructors.

    class Circle
    {
        static float _PI;
        int _Radius;

        static Circle()
        {
            Console.WriteLine("Static Constructor Called");

            Circle._PI = 3.14F;
        }

        public Circle(int Radius)
        {
            Console.WriteLine("Non Constructor Called");

            this._Radius = Radius;
        }

        public float CalculateArea()
        {
            return _PI * this._Radius * this._Radius;
        }
    }

    internal class Class6
    {
      

    }
}
