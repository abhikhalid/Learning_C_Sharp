using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Part 28 - C# Tutorial - Structs in C#

//Structs

// just like classes structs can have 
// 1. Private Fields
// 2. Public Properties
// 3. Constructors
// 4. Methods

namespace C_Sharp_Beginnerss
{

    public struct Customer
    {
        private int id;
        private string name;

        public Customer(int Id, String Name)
        {
            this.id = Id;
            this.name = Name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1}", this.id, this.name);
        }

        
    }

    internal class Class14
    {

        //static void Main()
        //{
        //    Customer c1 = new Customer(101,"Khalid");
        //    c1.PrintDetails();

        //    Customer c2 = new Customer();
        //    c2.Id = 102;
        //    c2.Name = "Mahmud";
        //    c2.PrintDetails();

        //    // Using 'Object Initializer' syntax

        //    Customer c3 = new Customer
        //    {
        //        Id = 103,
        //        Name = "John"
        //    };

        //    c3.PrintDetails();

        //}
    }
}
