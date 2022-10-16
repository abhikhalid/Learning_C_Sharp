using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Beginners
{
    // What is a class?

    // so far in this video tutorial we have seen simple data types like int, float, double etc. If you want to create complex type then we can make use of classes.

    // A class consists of data and behavior. Class data is represented by it's fields and behavciour is represented by methods. 

    // Purpose of a class constructor

    // The purpose of a class constructor  is to initialize class fields. A class constructor is automatically called when an instance
    // of a class is created.

    // Constructors do not have return values and always have the same name as the class.

    // Constructors are not mandatory. If we do not provide a constructor, a default paramter less construtor is automatically provided.

    // Constructor can be overloaded by the number and type of parameters.


    class Customer
    { 
        string _firstName;
        string _lastName;


        public Customer(): this("No FirstName Provided","No LastName Provided")
        {

        }

         public Customer(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}",this._firstName+" "+this._lastName);
        }

    }


    internal class Class5
    {
        //public static void Main()
        //{
        //    Customer c1 = new Customer();

        //    c1.PrintFullName();

        //    Customer c2 = new Customer("Khalid", "Mahmud");

        //    c2.PrintFullName();
        //}

    }
}
