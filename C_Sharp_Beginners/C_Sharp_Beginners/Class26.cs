using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Part 47 C# Tutorial Enums in c#

// Enums

// 1. Enums are enumerations.

// 2. Enums are stronglyb typed constants. Hence, an explicit cast is needed to convert
//    from enum type to an integral type and vice versa. Also, an enum of one type can not 
//    be implicityly assigned to an enum of another type even though the underlying of
//    their members are the same.


// 3. The default underlying type of an enum is int.

// 4. The default value for first element is ZERO and gets incremented by 1.

// 5. It is possible to customize the uderlying type and values.

// 6. Enums are value types.

// 7. Enum keyword (all small letters) is used to create enumerations, where as Enum
//    class, contains static GetValues() and GetNames() methods which can be used to list
//    Enum underlying type values and Names.

namespace C_Sharp_Beginners
{
    internal class Class26
    {
        //public static void Main()
        //{
        //    int[] Values =  (int[])Enum.GetValues(typeof(Gender));

        //    foreach(int value in Values)
        //    {
        //        Console.WriteLine(value);
        //    }

        //    string[] Names = Enum.GetNames(typeof(Gender));

        //    foreach(string Name in Names)
        //    {
        //        Console.WriteLine(Name);
        //    }

        //    Gender gender = (Gender)3;

        //    int Num = (int)Gender.Unknown;

        //    //not allowed
        //    //Gender gender = Season.Winter;


        //    //allowed
        //    //Gender gender = (Gender)Season.Winter;

        //}
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public enum Season
    {
        Winter = 1,
        Spring = 2,
        Summer = 3
    }

    //public enum Gender: short
    //{
    //    Unknown =1,
    //    Male = 5,
    //    Female = 23
    //}

    //public enum Gender: short
    //{
    //    Unknown,
    //    Male,
    //    Female
    //}

    //public enum Gender: short
    //{
    //    Unknown = 1,
    //    Male,
    //    Female
    //}


}
