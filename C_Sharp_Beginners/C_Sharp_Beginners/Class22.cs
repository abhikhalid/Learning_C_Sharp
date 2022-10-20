using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.IO;

//Part 40 C# Tutorial Exception Handling in C#

// Exception Handling

// An exception is an unforseen that occurs when a program is running.

// Examples: 

// Trying to read from a file that does not exist, throws FileNotFoundException.

// Trying to read from a database table that does not exist, throws a SqlException.

// Showing actual unhandled exceptions to the end user is bad for two reasons.

// 1. Uesrs will be annnoyed as they are cryptic and does not make much sense to the end users.

// 2. Exceptions contain infromation, that can be used for hacking into your application.

// An exception is actually a class that derives from System.Exception class. The System.Exception class has several
// useful properties, that provides valuable information about the exception.

// Message : Gets a message that describes the current exception.
// Stack Trace : Provides the call stack to the line number in the method where the exception occured.




namespace C_Sharp_Beginners
{
    internal class Class22
    {
        //public static void Main()
        //{
        //    //StreamReader streamReader = new StreamReader(@"C:\Users\BJIT\Documents\WorkSpace\C# Beginners\Learning_C_Sharp\C_Sharp_Beginners\C_Sharp_Beginners\Data.txt");

        //    //Console.WriteLine(streamReader.ReadToEnd());

        //    //streamReader.Close();
        //    StreamReader streamReader = null;
        //    try
        //    {
        //        streamReader = new StreamReader(@"C:\Users\BJIT\Documents\WorkSpace\C# Beginners\Learning_C_Sharp\C_Sharp_Beginners\C_Sharp_Beginners\Data.txt");

        //        Console.WriteLine(streamReader.ReadToEnd());

        //    }
        //    catch (FileNotFoundException ex)
        //    {
        //        //Log the details to the DB

        //        Console.WriteLine("Please check if the file {0} exists",ex.FileName);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        if (streamReader != null)
        //        {
        //            streamReader.Close();
        //        }

        //        Console.WriteLine("Finally Block");

        //    }

        //}







        //Part 41 C# Tutorial Inner Exceptions in C#

        // The InnerException property returns the Exception instance that caused the current exception.

        // To retain the original exception pass it as a parameter to the constructor, of the current exception.

        // Always check if inner exception is not null before accessing any property of the inner exception object.
        // else you may get Null Refernence Exception.

        // To get the type of InnerException use GetType() method



        //public static void Main()
        //{
        //    try
        //    {
        //        try
        //        {
        //            Console.WriteLine("Enter First Number");
        //            int FN = Convert.ToInt32(Console.ReadLine());

        //            Console.WriteLine("Enter Second Number");
        //            int SN = Convert.ToInt32(Console.ReadLine());

        //            int Result = FN / SN;

        //            Console.WriteLine("Result = {0}", Result);


        //        }
        //        catch (Exception ex)
        //        {
        //            string filePath = @"C:\Users\BJIT\Documents\WorkSpace\C# Beginners\Learning_C_Sharp\C_Sharp_Beginners\C_Sharp_Beginners\Data.txt";

        //            if (File.Exists(filePath))
        //            {
        //                StreamWriter sw = new StreamWriter(filePath);

        //                sw.WriteLine(ex.GetType().Name);
        //                sw.WriteLine();
        //                sw.Write(ex.Message);
        //                sw.Close();
        //                Console.WriteLine("There is a problem. Please try again");
        //            }
        //            else
        //            {
        //                throw new FileNotFoundException(filePath + " is not present", ex);
        //            }
        //        }

        //    }catch (Exception exception)
        //    {
        //        Console.WriteLine("Current Exception = {0}", exception.GetType().Name);

        //        if(exception.InnerException != null)
        //        {
        //            Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);

        //        }

        //    }


        //}




        

    }
}
