using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Part 74 List collection class in c#

// List collection class in C#

// List is one of the generic collection classes present in System.Colelctions.Generic namespace.

// There are several generic collection classes in System.Collections.Generic namespace as listed below.

// 1. Dictionary 
// 2. List
// 3. Stack
// 4. Queue etc.


// All List class can be used to create a collection of any type.
// For example, we can create a list of integers, strings and even complex types.
// The object stored in the list can be accessed by index.
// Unlike arrays, lists can grow in size automatically.
// This class also provides methods to search, sort and manipulate lists.


namespace C_Sharp_Beginners._72_Resst
{
    internal class Class31
    {
        //public static void Main()
        //{
        //    Customer customer1 = new Customer()
        //    {
        //        ID = 101,
        //        Name = "Khalid",
        //        Salary = 5000
        //    };
        //    Customer customer2 = new Customer()
        //    {
        //        ID = 102,
        //        Name = "Pam",
        //        Salary = 6500
        //    };
        //    Customer customer3 = new Customer()
        //    {
        //        ID = 119,
        //        Name = "John",
        //        Salary = 7600
        //    };

        //    Customer[] customers = new Customer[2];
        //    customers[0] = customer1;
        //    customers[1] = customer2;

        //    //customers[2] = customer3; (Exception)

        //    List<Customer> customerList = new List<Customer>(2);
        //    customerList.Add(customer1);
        //    customerList.Add(customer2);
        //    customerList.Add(customer3);

        //    customerList.Insert(0,customer3);

        //    Console.WriteLine(customerList.IndexOf(customer3)); //0
            
        //    //start looking for position 1

        //    Console.WriteLine(customerList.IndexOf(customer3,1)); 

        //    // List grows in size automatically
        //    Customer cust = customerList[0];

        //   // Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);

        //    foreach(Customer c in customerList)
        //    {
        //        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);

        //    }

        //    for (int i = 0; i < customerList.Count; i++)
        //    {
        //        Customer c = customerList[i];

        //        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
        //    }

        //    SavingsCustomer sc = new SavingsCustomer();
        //    customerList.Add(sc);

        //}
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }
    }

    public class SavingsCustomer : Customer
    {

    }


}
