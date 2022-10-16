using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Beginners
{
    //Part 22 - C# Tutorial - Method hiding in c#

    public class Employee
    {
        public string FirstName;
        public string LastName;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

    }

    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            //base.PrintFullName();

            Console.WriteLine(FirstName + " " + LastName + " - Contractor");
        }
    }

    public class FullTimeEmployee : Employee
    {

    }

    internal class Class8
    {
        //public static void Main()
        //{
        //    FullTimeEmployee FTE = new FullTimeEmployee();
        //    FTE.FirstName = "FullTime";
        //    FTE.LastName = "Employee";
        //    FTE.PrintFullName();

        //    //PartTimeEmployee PTE = new PartTimeEmployee();
        //    //PTE.FirstName = "Tahmina";
        //    //FTE.LastName = "Khan";

        //    //PTE.PrintFullName();

        //    Employee PTE = new PartTimeEmployee();
        //    PTE.FirstName = "Tahmina";
        //    FTE.LastName = "Khan";

        //    PTE.PrintFullName();


        //}

    }
}
