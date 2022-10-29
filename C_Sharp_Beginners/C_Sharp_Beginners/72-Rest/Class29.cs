using System;
using System.Collections.Generic;


// Part 72 - Dictionary in C#

// 1. A dictionary is a collection of (key,value) pairs
// 2. Dictionary class is present in System.Collections.Generic namespace.
// 3. When creating a dicotionary, we need to specify the type for key and value.
// 4. Dictionary provides fast lookups for values using keys.
// 4. Keys in the dictionary must be unique.


namespace C_Sharp_Beginners._72_Rest
{
    internal class Program
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
            
        //    Dictionary<int,Customer> customerList = new Dictionary<int,Customer>();

        //    customerList.Add(customer1.ID, customer1);
        //    customerList.Add(customer2.ID, customer2);
        //    customerList.Add(customer3.ID, customer3);

        //    if (!customerList.ContainsKey(customer1.ID))
        //    {
        //        customerList.Add(customer1.ID, customer3);
        //    }


        //    //Customer customer = customerList[119];

        //    // better approach to retrive value

        //    if (customerList.ContainsKey(119))
        //    {
        //        Customer cust = customerList[119];
        //    }


        //    //Console.WriteLine("ID = {0}, Name = {1}, Salary ={2}",customer.ID,customer.Name,customer.Salary);

        //    //foreach(KeyValuePair<int,Customer> customerKeyValuePair in customerList)
        //    //{
        //    //    Console.WriteLine("Key = {0}", customerKeyValuePair.Key);

        //    //    Customer cust = customerKeyValuePair.Value;

        //    //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",cust.ID,cust.Name,cust.Salary);

        //    //    Console.WriteLine("---------------------");

        //    //}

        //    foreach (Customer cust in customerList.Values)
        //    {
        //        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",cust.ID,cust.Name,cust.Salary);
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
