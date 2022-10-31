using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_Amanul_vaiya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to  Shape Calculator....\n");
            int choice;

            do
            {
                Console.WriteLine("Press 1 to Calculate the area of a Rectange");
                Console.WriteLine("Press 2 to Calculate the area of a Square");
                Console.WriteLine("Press 3 to Calculate the area of a Circle");
                Console.WriteLine("Press 4 to exit the program.....");

                choice = int.Parse(Console.ReadLine());

                if (choice != 1 && choice != 2 && choice != 3 && choice != 4)
                {
                    Console.WriteLine("Please enter a valid input...\n");
                    continue;
                }

                Shape shape;

                //calculate the area of a rectangle
                if(choice == 1)
                {
                    shape = new Rectangle();
                    shape.Area();
                    shape.Draw();
                }
                //calculate the area of a square
                else if (choice == 2)
                {
                    shape = new Square();
                    shape.Area();
                    shape.Draw();
                }
                //calculate the area of a circle
                else if (choice == 3)
                {
                    shape = new Circle();
                    shape.Area();
                    shape.Draw();
                }
               


                
            }while(choice!=4);
        }
    }
}
