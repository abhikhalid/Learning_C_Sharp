using System;
using System.IO;
using System.Runtime.Serialization;

namespace C_Sharp_Beginners.Custom_Exception
{
    //Part 42 C# Tutorial Custom Exceptions in C#

    // To understand custom exception, you should have good understanding of

    // 1. Inheritance
    // 2. Exception Handling Basics
    // 3. Inner Exception 

    // Why do you usaully go for creating own custom exceptions?

    // If none of the already existing dotnet exceptions adequately describes the problem.

    // Example : 
    // 1. I have an asp.net web application.
    // 2. The application should allow the user to have only one logged in session.
    // 3/ If the user is already logged in, and if he opens another browser window and tries to login again,
    // the application should throw an error starting he is already logged in another browser window.

    // With in the .NET framework we don't have any exception, that adequately describes this prolem. So this scenaria is one of the examples
    // where you want to create a custom exception.

    //ALT + CTRL + E

    // Custom Exception - Steps

    // 1. Create a class that derives from System.Exception class. As a convention, end the class name with Exception suffix. All .NET exceptions end with, exception suffix.

    // 2. Provide a public constructor, that takes in a a string parameter. THis constructor simply passes the string parameter, to the base exception class constructor.

    // 3. Using Inner Exceptions, you can also track back the original exception. If you want to provide this capability for your custom exception class, then overload
    // the constructor accordingly.

    // 4. If you want your Exception class object to work across application domains, then the object must be serizalizable. To make your exception serializable, mark it with 
    // Serializable attribute and provide a constructor that invokes the base Exception Class constructor that takes in SerializationInfo and StreamingContext object as parameters.

    // Note : It is also possible to provide your own custoom serialization.

    internal class Class23
    {
        //public static void Main()
        //{
        //    try
        //    {
        //        throw new UserAlreadyLoggedInException("User is logged in - no  duplicate session allowed");
        //    }
        //    catch(UserAlreadyLoggedInException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
    }


    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base()
        {

        }

        public UserAlreadyLoggedInException(string message) : base(message) 
        {

        }

        public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
        {

        }


        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context):base(info, context)
        {

        }


    }
}
