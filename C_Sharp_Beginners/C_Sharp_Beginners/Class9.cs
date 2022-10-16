using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Polymorphism

//Polymorphism is one of the primary pillars of object-oriented programming.

//Polymorphism allows you to invoke derived class methods through a base class reference during runtime.


// In the base class the method is declared virtual, an in the derived class we override the same method.



// The virtual keyword indicates, the method can be overridden in any derived class.


namespace C_Sharp_Beginnerss
{
    public  class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Part Time");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Full Time");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Temporary Time");
        }
    }

    internal class Class9
    {
        static void Main()
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach(Employee e in employees)
            {
                e.PrintFullName();
            }
        }
    }
}
