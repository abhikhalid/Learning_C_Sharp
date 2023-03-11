using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Beginners._72_Ressst
{

    public class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5200
            };

            Customer customer2 = new Customer()
            {
                ID = 103,
                Name = "John",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                ID = 102,
                Name = "Ken",
                Salary = 5500
            };

            List<Customer> listCutomers = new List<Customer>(100);
            listCutomers.Add(customer1);
            listCutomers.Add(customer2);
            listCutomers.Add(customer3);

            Console.WriteLine("Are all salaries greater than 5000: "
                + listCutomers.TrueForAll(x => x.Salary > 5000));

            // ReadOnlyCollection will not have Add() or Remove() methods
            System.Collections.ObjectModel.ReadOnlyCollection<Customer>
                readOnlyCustomers = listCutomers.AsReadOnly();

            Console.WriteLine("Total Items in ReadOnlyCollection = " +
                readOnlyCustomers.Count);

            // listCutomers list is created with an initial capacity of 100
            // but only 3 items are in the list. The filled percentage is 
            // less than 90 percent threshold.
            Console.WriteLine("List capacity before invoking TrimExcess = " +
                    listCutomers.Capacity);
            // Invoke TrimExcess() to set the capacity to the actual 
            // number of elements in the List
            listCutomers.TrimExcess();
            Console.WriteLine(listCutomers.Capacity);
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
