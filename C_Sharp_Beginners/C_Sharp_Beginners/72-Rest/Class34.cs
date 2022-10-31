using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Sorting a list of simple types

// Sorting a list of simple types like int, string, char etc is straight forward.
// Just involve the sort() method on the list instance and the data will be automatically sorted in ascending order

// List <int> numbers = new List<int>{1,8,7,5,2,3,4};

// numbers.Sort();

// If you want the data to be retrived in descending order, use Reverse() method on the list instance.

// numbers.Reverse();

// However, when you do the same thing on a complex type like Customer.
// we get a runtime invalid operation exception - Failed to compare 2 elements in the array.
// This because .NET runtime does not know how to sort complex types. We have to tell the way
// we want data to be sorted in the list by implementing IComparable interface.

// Hown is the sort functionality working for simple types like int,string, char etc?

// That is because these types (int, string,decimal, char etc) have implemented IComparable interface already.


namespace C_Sharp_Beginners._72_Rest
{
    internal class Class34
    {
        //public static void Main()
        //{
        //    List<int> numbers = new List<int> { 1, 8, 7, 5, 2, 3, 4,9,6 };

        //    Console.WriteLine("Numbers before sorting");

        //    foreach(int number in numbers)
        //    {
        //        Console.WriteLine(number);
        //    }

        //    numbers.Sort();

        //    Console.WriteLine("Numbers after sorting");

        //    foreach(int number in numbers)
        //    {
        //        Console.WriteLine(number);
        //    }

        //    numbers.Reverse();

        //    Console.WriteLine("Numbers in descending order");

        //    foreach (int number in numbers)
        //    {
        //        Console.WriteLine(number);
        //    }

        //    List<string> alphabets = new List<string> { "B","F","D","E","A","C"};

        //    Console.WriteLine("Alphabets before sorting");

        //    foreach(string alphabet in alphabets)
        //    {
        //        Console.WriteLine(alphabet);
        //    }

        //    alphabets.Sort();

        //    Console.WriteLine("Alphabets after sorting");

        //    foreach (string alphabet in alphabets)
        //    {
        //        Console.WriteLine(alphabet);
        //    }

        //    alphabets.Reverse();

        //    Console.WriteLine("Alphabets in descending order");

        //    foreach (string alphabet in alphabets)
        //    {
        //        Console.WriteLine(alphabet);
        //    }




        //}
    }
}
