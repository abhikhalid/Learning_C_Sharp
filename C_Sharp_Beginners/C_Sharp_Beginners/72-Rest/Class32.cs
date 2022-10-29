using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Part 75 List collection class in c# continued

// Contains() function : Checks if an item exists in the list. This methods returns true
// if the items exists, else false

// Exists() function : Checks if an item exists in the list based on a condition. This method returns true if the items exists, else false

// Find() function : Searchs for an element that matches the conditions defined by the specified lambda expression and returns the first matching from
// the list

// FindLast() function : Searches for an element that matches the conditions defined by the specified lambda expression and returns the last matching item from the list.

// FindAll() function : Returns all the items from the list that match the conditions specified by the lambda expression.


namespace C_Sharp_Beeginners._72_Rest
{
    internal class Class32
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


        //    List<Customer> customerList = new List<Customer>();
        //    customerList.Add(customer1);
        //    customerList.Add(customer2);
        //    customerList.Add(customer3);

        //    //if(customerList.Contains(customer3))
        //    //{
        //    //    Console.WriteLine("Customer3 object exists in the list");
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("Customer3 object does not exist in the list");
        //    //}


        //    //if(customerList.Exists(customr => customr.Name.StartsWith("A")))
        //    //{
        //    //    Console.WriteLine("Customer3 object exists in the list");
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("Customer3 object does not exist in the list");
        //    //}

        //    // Contains() and Exists() return booleans

        //    // Find() returns the first matching object

        //    // FindLast() returs the last matching object

        //    // FindAll() returns a list based on a condition

        //    Customer c = customerList.Find(cust => cust.Salary > 5000);
        //    Customer c1 = customerList.FindLast(cust => cust.Salary > 5000);
        //    List<Customer> cList = customerList.FindAll(cust => cust.Salary > 5000);

        //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);

        //    Console.WriteLine(customerList.FindIndex(cust => cust.Salary > 5000));
        //    Console.WriteLine(customerList.FindIndex(2, cust => cust.Salary > 5000));
        //    Console.WriteLine(customerList.FindLastIndex(cust => cust.Salary > 5000));


        //    // Array to a List

        //    Customer[] customerArray = new Customer[3];
        //    customerArray[0] = customer1;
        //    customerArray[1] = customer2;
        //    customerArray[2] = customer3;

        //    List<Customer> listCustomers = customerArray.ToList();

        //    foreach(Customer ct in listCustomers)
        //    {
        //        Console.WriteLine("ID = {0}, Name = {1], Salary = {2}", ct.ID, ct.Name, ct.Salary);
        //    }

        //    // List to an array

        //    List<Customer> listCustomerss = new List<Customer>();
        //    listCustomers.Add(customer1);
        //    listCustomers.Add(customer2);
        //    listCustomers.Add(customer3);


        //    listCustomers.ToArray();

        //    // List to dictionary

        //    Dictionary<int,Customer> dictionary =  listCustomers.ToDictionary(x=>x.ID);

        //    foreach(KeyValuePair<int,Customer> kvp in dictionary)
        //    {
        //        Customer customer = kvp.Value;

        //        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
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
