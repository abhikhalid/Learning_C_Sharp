using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Part 76 Working with generic list class and ranges in c#

// AddRange() - Add() method allows you to add one item at a time to the end of the list,
// where as AddRange(0 allows you to add another list of items, to the end of the list.

// GetRange() - Using an item index, we can retrieve only one item at a time from the list,
// if you want to get a list of items from the list, the use GetRange() function. This function
// expects 2 parameters, the start index in the list and the number of elements to return.

//  InsertRange() - Insert() method allows you to insert a single item into the list at a specificed index,
// where as InsertRange() allows you to insert another list of items to your list at specified index.

// RemoveRange() - Remove() function removes only the first matching item from the list.
// RemoveAll() function removes the item at the specified index in the list. RemoveAll() function removes all the items that matches
// the specified condition. 

namespace C_Sharp_Beginners._72_Resstt
{
    internal class Class33
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000,
                Type = "RetailCustomer"
            };
            Customer customer2 = new Customer()
            {
                ID = 101,
                Name = "Pam",
                Salary = 7000,
                Type = "RetailCustomer"
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500,
                Type = "RetailCustomer"
            }; 
            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "John",
                Salary = 6500,
                Type = "CorporateCustomer"
            };
            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Sam",
                Salary = 3500,
                Type = "CorporateCustomer"
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);


            //listCustomers.InsertRange(0, listCorporateCustomers);

            //listCustomers.RemoveAll(x => x.Type == "CorporateCustomer");

            //listCustomers.RemoveRange(3, 2);


            listCustomers.AddRange(listCorporateCustomers);

            foreach(Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type ={3}",c.ID,c.Name,c.Salary,c.Type);
            }

           Customer cs =  listCustomers[0];

           List<Customer> customers = listCustomers.GetRange(3, 2);
    
           foreach(Customer c in customers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type ={3}", c.ID, c.Name, c.Salary, c.Type);

            }

        }

    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }    
        public int Salary { get; set; } 
        public string Type { get; set; }
    }
}
