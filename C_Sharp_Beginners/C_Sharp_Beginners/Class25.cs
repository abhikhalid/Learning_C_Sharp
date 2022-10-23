using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Part 45 C# Tutorial Why Enums

// Why Enums

// Enums are stronngly typed constants.

// If a program uses set of integral numbers, consider replacing them with enums
// Otherwise the program becomes less

// Readable
// Maintainable

// In the next session, we will replace, these integral numbers with enums, which makes the program 
// better readable and maintainable.

namespace C__Sharp_Beginners
{
    //internal class Class25
    //{
    //    public static void Main()
    //    {
    //        Customer[] customers = new Customer[3];

    //        customers[0] = new Customer
    //        {
    //            Name = "Mark",
    //            Gender = 1
    //        };
    //        customers[1] = new Customer
    //        {
    //            Name = "Mary",
    //            Gender = 2
    //        };
    //        customers[2] = new Customer
    //        {
    //            Name = "Sam",
    //            Gender = 0
    //        };

    //        foreach(Customer customer in customers)
    //        {
    //            Console.WriteLine("Name = {0} && Gender = {1}",customer.Name, GetGender(customer.Gender));
    //        }

    //    }

    //    public static string GetGender(int gender)
    //    {
    //        switch (gender)
    //        {
    //            case 0:
    //                return "Unknown";

    //            case 1:
    //                return "Male";

    //            case 2:
    //                return "Female";

    //            default:
    //                return "Invalid data detected";

    //        }
    //    }

    //}



    //// 0 - Unknown
    //// 1 - Male
    //// 2 - Female

    //public class Customer
    //{
    //    public string Name { get; set; }
    //    public int Gender { get; set; }
    //}


    ///////////////////////////////////////////////////////////////////////

    //Part 46 C# Tutorial Enums Example


    internal class Class25
    {
        //public static void Main()
        //{
        //    Customer[] customers = new Customer[3];

        //    customers[0] = new Customer
        //    {
        //        Name = "Mark",
        //        Gender = Gender.Male
        //    };
        //    customers[1] = new Customer
        //    {
        //        Name = "Mary",
        //        Gender = Gender.Female
        //    };
        //    customers[2] = new Customer
        //    {
        //        Name = "Sam",
        //        Gender = Gender.Unknown
        //    };

        //    foreach (Customer customer in customers)
        //    {
        //        Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGender(customer.Gender));
        //    }

        //}

        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";

                case Gender.Male:
                    return "Male";

                case Gender.Female:
                    return "Female";

                default:
                    return "Invalid data detected";

            }
        }

    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }


    // 0 - Unknown
    // 1 - Male
    // 2 - Female

    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }

}
