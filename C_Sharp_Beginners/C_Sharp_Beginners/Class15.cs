using C_Sharp_Beginners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Beginnersss
{
    //Part 29 - C# Tutorial - Difference between classes and structs in c#.
    
    // Classes Vs Structs

    // A struct is a value type where as a class is a reference type.
    // All the differences that are applicable to value types and reference types are also applicable to classes and structs.
    // Structs are stored on stack, where as classes are stored on the heap.
    // Value types hold their value in memory where  they are declared, but reference type hold a reference to an object in memory.
    // Value types are destroyed immediately after the scope is lost, where as for reference type only
    // the reference variable is destoryed after the scope is lost. The object is later destroyed by garbage collector.

    // When you copy a struct into anotehr struct, a new copy of that struct  get created and modifications on one struct will not affect the values contained by the other struct.
    // When you copy a class into another class, we only get a copy of the reference variable. Both the reference variables point to the same object on the heap.
    // So, Operations on one variable will affect the values contained by other reference variable.
  

    // Structs can't have distructors, but classes cna have distructors.
    
    // Structs can not have explicit parameter less constructor where as a class can.

    // Struct can not inherit from another class where as a class can. Both sturcts and  classes can inherit from interface.

    // Note 1: A class or a struct can not inherit from another struct. Struct are sealed types.

    // Note 2: How do you prevent a class from being inherited? Or What is the significance of sealed keyword? 

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        ~Customer()
        {

        }
        
    }

    internal class Class15
    {
        //static void Main()
        //{
            //int i = 0;

            //if (i == 10)
            //{
            //    int j = 20;
            //    Customer c1 = new Customer();
            //    c1.ID = 101;
            //    c1.Name = "Khalid";
            //}

            //Console.WriteLine("Hello");


            ///////////////////////////////////////

        //    int i = 10;
        //    int j = i;

        //    Console.WriteLine("i = {0} && j = {1}",i,j);

        //    Customer c1 = new Customer();
        //    c1.ID = 101;
        //    c1.Name = "Khalid";

        //    Customer c2 = new Customer();

        //    c2 = c1;

        //    c2.Name = "Mahmud";

        //    Console.WriteLine(c1.Name);

        //}


    }
}
