using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Part 73 What is dictionary in c# continued

// In this video, we will discuss the follwing methods of Dictionary Class

// 1. TryGetValue()
// 2. Count()
// 3. Remove()
// 4. Clear()
// 5. Using LINQ extension methods with Dictionary\
// 6. Different ways to convert an array into a dictioary.

namespace C_Ssharp_Beginners._72_Rest
{
    internal class Class30
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

        //    Dictionary<int, Customer> customerList = new Dictionary<int, Customer>();

        //    customerList.Add(customer1.ID, customer1);
        //    customerList.Add(customer2.ID, customer2);
        //    customerList.Add(customer3.ID, customer3);


        //    Customer cust;

        //    if (customerList.TryGetValue(101, out cust))
        //    {
        //        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
        //    }
        //    else
        //    {
        //        Console.WriteLine("The Key is not found!");
        //    }

        //    Console.WriteLine("Total Items = {0}", customerList.Count);
        //    Console.WriteLine("Total Items = {0}", customerList.Count());

        //    Console.WriteLine("Total Items = {0}", customerList.Count(cusst => cusst.Value.Salary > 4000));

        //    customerList.Remove(110);

        //    customerList.Clear();


        //    Customer[] customers = new Customer[3];
        //    customers[0] = customer1;
        //    customers[1] = customer2;
        //    customers[2] = customer3;

        //    List<Customer> customers = new List<Customer>();
        //    customers.Add(customer1);
        //    customers.Add(customer2);
        //    customers.Add(customer3);

        //    Dictionary<int, Customer> dict = customers.ToDictionary(cusst => cust.ID, cusst => cust);


        //    foreach (KeyValuePair<int, Customer> customer in dict)
        //    {
        //        Console.WriteLine("Key = {0}", customer.Key);

        //        Customer customerr = customer.Value;

        //        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customerr.ID, customerr.Name, customerr.Salary);
        //    }


        //}
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }
    }
}
