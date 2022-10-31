using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Part 78 Sort a list of complex types in c#


namespace C_Sharp_Begginners._72_Rest
{
    internal class Class35
    {
        //public static void Main()
        //{
        //    Customer customer1 = new Customer()
        //    {
        //        ID = 101,
        //        Name = "Mark",
        //        Salary = 4000,
        //        Type = "RetailCustomer"
        //    };
        //    Customer customer2 = new Customer()
        //    {
        //        ID = 101,
        //        Name = "Pam",
        //        Salary = 7000,
        //        Type = "RetailCustomer"
        //    };
        //    Customer customer3 = new Customer()
        //    {
        //        ID = 103,
        //        Name = "Rob",
        //        Salary = 5500,
        //        Type = "RetailCustomer"
        //    };

        //    List<Customer> listCustomers = new List<Customer>();
        //    listCustomers.Add(customer1);
        //    listCustomers.Add(customer2);
        //    listCustomers.Add(customer3);

        //    listCustomers.Sort();



        //}
    }

    public class Customer:IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }

        public int CompareTo(Customer other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }
}
