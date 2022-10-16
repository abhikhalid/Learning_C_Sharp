using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Beginners
{
    //Part 2 - C# Tutorial - Reading and writing to a console.avi

    //Reading from the console
    // Writing to the console
    // 2 ways to write to console
    // a) Concatenation
    // b) Place holder syntax - Most preferred


    internal class Class2
    {
        //static void Main()
        //{
        //Console.WriteLine("Please enter your name");

        //string UserName = Console.ReadLine();

        //Console.WriteLine("Hello " + UserName);

        //Console.WriteLine("Hello {0}",UserName);

        //--------------------------------------------

        //    Console.WriteLine("Please enter your first name");

        //    string FirstName = Console.ReadLine();

        //    Console.WriteLine("Please enter your last name");

        //    string LastName = Console.ReadLine();

        //    Console.WriteLine("Hello {0} {1}", FirstName, LastName);
        //}







        //Part 3 - C# Tutorial - Built - in types

        //static void Main()
        //{
        //    bool b  = true;

        //    //b = 123; error

        //    int i = 0;

        //    Console.WriteLine("Min = {0}", int.MinValue);
        //    Console.WriteLine("Max = {0}", int.MaxValue);

        //    double d = 123.22242433;
        //    Console.WriteLine(d);
        //}


        //Part 4 - C# Tutorial - String type in c#

        //static void Main()
        //{
        //    string name = "\"Khalid\"";

        //    string name2 = "One\nTwo\nThree\n";


        //    //Verbatim Literal : is a string with an @symbol prefix, as if @"Hello"

        //    //Verbatim literals make escape sequences traslate as normal printable characters to enhances readablity.




        //    string name3 = @"\KhalidMahmud";

        //    Console.WriteLine(name);

        //    Console.WriteLine(name2);

        //    Console.WriteLine(name3);
        //}




        //Part 5 - C# Tutorial - Common Operators in c#

        //Assignment Operator  = 
        //Arithmetic Operatos like +, - , * , /, %
        //Comparison Operators like == , !=, >, <=
        //Conditional Operators lik &&, ||
        //Ternary Operator ?:
        // Null Coalescing Operator ??

        //static void Main()
        //{
        //Assignment Operator  = 

        //int i = 10;
        //bool b = true;

        //////////////////////////////////////////

        //int Numerator = 10;
        //int Denominator = 2;

        //int Result = Numerator / Denominator;

        //Console.WriteLine("Result = {0}", Result);

        //////////////////////////////////////////


        //int Number = 10;
        //int AnotherNumber = 20;

        //if(Number == 10 && AnotherNumber == 20)
        //{
        //    Console.WriteLine("Hello");
        //}

        //if (Number == 10 || AnotherNumber == 20)
        //{
        //    Console.WriteLine("Hello");
        //}


        //Ternary Operator 

        //int Number = 10;

        //bool IsNumber10;

        //if(Number == 10)
        //{
        //    IsNumber10 = true;
        //}
        //else
        //{
        //    IsNumber10 = false; 
        //}

        //IsNumber10 = Number == 10 ? true : false;

        //Console.WriteLine("Number == 10 is {0}",IsNumber10);



        //}


        //Part 6 - C# Tutorial - Nullable Types

        //Types in C#

        //In C# types are divided into 2 broad categories

        // i. Value Types - int, float, structs, enums etc
        // ii. Reference Types - Interface, Class, delegates, arrays etc

        // By default value types are non nullable. To make them nullable use ?

        // int i = 0 (i is non nullable, so i can not be set to null, i = null will generate compiler error)
        // int? j = 0 (j is nullable int,  so j = null is legal)


        // The default value for reference type is null
        // The default value for value type is 0

        //Nullable types bridfge the differences betwee4n C# types and Database types  

        //static void Main()
        //{
        //int? i = null;

        ////////////////////////////////////////

        //bool? AreYouMajor = null;

        //if (AreYouMajor == true)
        //{
        //    Console.WriteLine("User is Major");
        //}
        //else if(AreYouMajor == false)
        //{
        //    Console.WriteLine("User is not Major");
        //}
        //else
        //{
        //    Console.WriteLine("User did not answer the Question");
        //}


        //////////////////////////////////////////////////

        //int? TicketOnSale = null;

        //int AvailableTickets; 

        //if(TicketOnSale == null)
        //{
        //    AvailableTickets = 0;
        //}
        //else
        //{
        //   // AvailableTickets = TicketOnSale.Value;

        //   //or

        //   AvailableTickets = (int)TicketOnSale;

        //}

        //Console.WriteLine("Available = {0}", AvailableTickets);









        //  }


        /////////////////////////////


        //Part 8 - C# Tutorial - Arrays in C#


        //static void Main()
        //{


        //Array : An array is a collection of similar data types.

        //Advantages : Arrays are strongly typed.

        // Disadvantages : Arrays can not grow in size once initialized.

        // Have to rely on integral indices to store or retrive items from the array

        //int[] EvenNumbers = new int[3];

        //EvenNumbers[0] = 0;
        //EvenNumbers[1] = 2;
        //EvenNumbers[2] = 4;

        //Console.WriteLine(EvenNumbers[1]);


        //}


        //////////////////////////////////////////////////

        //Part 9 - C# Tutorial - Comments in C#

        //Single line Comments - //
        //Multi Line Comments - /* */

        //Comments are used to document what the program does and what specific 
        //blocks of lines of code do. C# compiler ignores comments.

        // To comment and Uncomment
        // Keyboard shorcut : Ctrl + K, Ctrl + C, Ctrl + U

        //Note: Dont try to comment every line of code. Use comments only for blocks
        // or lines of code that are difficult to understand.

        //static void main()
        //{
        //    SampleClass sm = new SampleClass();
        //}






        //////////////////////////////////////////////



        //Part 10 - C# Tutorial - If statement in C#
        //static void Main()
        //{
        //Console.WriteLine("Please enter a number");

        //int UserNumber = int.Parse(Console.ReadLine());

        //if(UserNumber == 1)
        //{
        //    Console.WriteLine("Your Number is one");
        //}

        //if (UserNumber == 2)
        //{
        //    Console.WriteLine("Your Number is two");
        //}

        //if (UserNumber == 3)
        //{
        //    Console.WriteLine("Your Number is three");
        //}

        //if(UserNumber != 1 && UserNumber !=2 && UserNumber != 3)
        //{
        //    Console.WriteLine("Your Number is not between 1 and 3");
        //}

        //if (UserNumber == 1)
        //{
        //    Console.WriteLine("Your Number is one");
        //}

        //else if (UserNumber == 2)
        //{
        //    Console.WriteLine("Your Number is two");
        //}

        //else if (UserNumber == 3)
        //{
        //    Console.WriteLine("Your Number is three");
        //}
        //else
        //{
        //    Console.WriteLine("Your Number is not between 1 and 3");
        //}



        ////////////////////////////////////////////

        //Console.WriteLine("Please enter a number");

        //int UserNumber = int.Parse(Console.ReadLine());

        //if (UserNumber == 10 || UserNumber == 20)
        //{
        //    Console.WriteLine("Your number is 10 or 20");
        //}
        //else
        //{

        //}






        //}


        //////////////////////////////////////////////////

        //Part 11 - C# Tutorial - switch statement in C#

        //static void Main()
        //{
        //Console.WriteLine("Please enter a  number");
        //int UserNumber = int.Parse(Console.ReadLine());

        //if (UserNumber == 10)
        //{
        //    Console.WriteLine("Your number is 10");
        //}
        //else if (UserNumber == 20)
        //{
        //    Console.WriteLine("Your Number is 20");
        //}
        //else if(UserNumber == 30)
        //{
        //    Console.WriteLine("Your Number is 30");
        //}
        //else
        //{
        //    Console.WriteLine("Your number is not 10, 20 & 30");
        //}

        //switch(UserNumber)
        //{
        //    case 10:
        //        Console.WriteLine("Your number is 10");
        //        break;
        //    case 20:
        //        Console.WriteLine("Your Number is 20");
        //        break;
        //    case 30:
        //        Console.WriteLine("Your Number is 30");
        //        break;
        //    default:
        //        Console.WriteLine("Your number is not 10, 20 & 30");
        //        break;
        //}

        //Part 12 - C# Tutorial - switch statement in c# continued

        //    int TotalCoffeeCost = 0;

        //    Console.WriteLine("1 - Small, 2 - Medium, 3 - Large");

        //    int UserChoice = int.Parse(Console.ReadLine());

        //    switch (UserChoice) {

        //        case 1:
        //            TotalCoffeeCost += 1;
        //            break;
        //        case 2:
        //            TotalCoffeeCost += 2;
        //            break;
        //        case 3:
        //            TotalCoffeeCost += 3;
        //            break;

        //        default:
        //            Console.WriteLine("Your choice {0} is invalid",UserChoice);
        //            break;

        //    }

        //    Console.WriteLine("Thank you for shopping with us");
        //    Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);


        //}


        ////////////////////////////////////////////

        //Part 13 - C# Tutorial - while loop in c#

        //static void Main()
        //{
        //    Console.WriteLine("Please enter your target");

        //    int userTarget = int.Parse(Console.ReadLine());

        //    int Start = 0;

        //    while(Start <= userTarget){
        //        Console.WriteLine(Start);
        //        Start += 2;
        //    }

        //}

        //////////////////////////////////

        //Part 14 - C# Tutorial - do while loop in c#

        //static void Main()
        //{
        //    String UserChoice = "";

        //    do
        //    {
        //        Console.WriteLine("Please enter your target?");
        //        int UserTarget = int.Parse(Console.ReadLine());

        //        int Start = 0;

        //        while (Start <= UserTarget)
        //        {
        //            Console.Write(Start + " ");

        //            Start += 2;
        //        }

        //        do
        //        {
        //            Console.WriteLine("\nDo you want to continue - Yes or No?");

        //            UserChoice = Console.ReadLine().ToLower();

        //            if (UserChoice != "yes" && UserChoice != "no")
        //            {
        //                Console.WriteLine("Invalid Choice, please say yes or  No");

        //            }
        //        } while (UserChoice != "yes" && UserChoice != "no");

        //    } while (UserChoice != "no");
        //}


        // Part 15 - C# Tutorial - for and foreach loops in c#

        //static void Main()
        //{
        //int[] Numbers = new int[3];

        //Numbers[0] = 10;
        //Numbers[1] = 20;
        //Numbers[2] = 30;

        //int i = 0;

        //while(i< Numbers.Length)
        //{
        //    Console.WriteLine(Numbers[i++]);
        //}

        //for (int i = 0; i < Numbers.Length; i++)
        //{
        //    Console.WriteLine(Numbers[i]);
        //}

        //foreach(int k in Numbers)
        //{
        //    Console.WriteLine(k);
        //}



        ///////////////////////////////////////////////

        //for (int i = 0; i < 20; i++)
        //{
        //    Console.WriteLine(i);

        //    if(i == 10)
        //    {
        //        break;
        //        }
        //}

        //    for (int i = 0; i < 20; i++)
        //    {
        //        if(i % 2 == 1)
        //        {
        //            continue;
        //        }

        //        Console.WriteLine(i);
        //    }




        //}

        ////////////////////////////////////////////////////

        

    }
    /// <summary>
    /// This is a sample class and a sample documentation
    /// </summary>
    public class SampleClass
    {

    }

}
