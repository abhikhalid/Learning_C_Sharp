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
        public static void Main()
        {
             Customer customer1 = new Customer()
        {
            ID = 101,
            Name = "Mark",
            Salary = 4000
        };

        Customer customer2 = new Customer()
        {
            ID = 102,
            Name = "John",
            Salary = 7000
        };

        Customer customer3 = new Customer()
        {
            ID = 103,
            Name = "Ken",
            Salary = 5500
        };

        List<Customer> listCutomers = new List<Customer>();
        listCutomers.Add(customer1);
        listCutomers.Add(customer2);
        listCutomers.Add(customer3);

        Console.WriteLine("Customers before sorting");
        foreach (Customer customer in listCutomers)
        {
            Console.WriteLine(customer.Name + " - " + customer.Salary);
        }

        // Sort() method should sort customers by salary
        listCutomers.Sort();

        Console.WriteLine("Customers after sorting");
        foreach (Customer customer in listCutomers)
        {
            Console.WriteLine(customer.Name + " - " + customer.Salary);
        }

        // To sort customers by name instead of salary
        SortByName sortByName = new SortByName();
        listCutomers.Sort(sortByName);

        Console.WriteLine("Customers after sorting by Name");
        foreach (Customer customer in listCutomers)
        {
            Console.WriteLine(customer.Name + " - " + customer.Salary);
        }

        Console.ReadLine();
    }
    }

   public class SortByName : IComparer<Customer>
{
    public int Compare(Customer x, Customer y)
    {
        return x.Name.CompareTo(y.Name);
    }
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
