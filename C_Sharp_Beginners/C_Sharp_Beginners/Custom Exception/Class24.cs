using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


//Part 43 C# Tutorial Exception handling abuse

// Using exception handling to implement program logical flow is bad and is termed as exception handling abuse.

namespace C_Sharp_Beginners.Custom_Exception
{
    internal class Class24
    {
        //public static void Main()
        //{
        //    try{
        //        Console.WriteLine("Please enter Numerator");
        //        int Numerator = Convert.ToInt32(Console.ReadLine());

        //        Console.WriteLine("Please enter Denominator");
        //        int Denominator = Convert.ToInt32(Console.ReadLine());

        //        int Result = Numerator / Denominator;

        //        Console.WriteLine("Result = {0}", Result);

        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Please enter a number");
        //    }
        //    catch (OverflowException)
        //    {
        //        Console.WriteLine("Only numbers  between {0} && {1} are allowed",int.MinValue,int.MaxValue);
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        Console.WriteLine("Denominator can not be zero");
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}



        //Part 44 C# Tutorial Preventing exception handling abuse

        //public static void Main()
        //{
        //    try
        //    {
        //        Console.WriteLine("Please enter Numerator");
        //        int Numerator;
                
        //        bool IsNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(),out Numerator);

        //        if (IsNumeratorConversionSuccessful)
        //        {
        //            Console.WriteLine("Please enter Denominator");
        //            int Denominator;

        //            bool IsDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(),out Denominator);  
                    
        //            if(IsDenominatorConversionSuccessful && Denominator!= 0)
        //            {
        //                int Result = Numerator / Denominator;
        //                Console.WriteLine("Result = {0}", Result);
        //            }
        //            else
        //            {
        //                if(Denominator == 0)
        //                {
        //                    Console.WriteLine("Denominator can not be zero");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Denominator should be a valid number between {0} && {1}",int.MinValue,int.MaxValue);
        //                }
        //            }


        //        }
        //        else
        //        {
        //            Console.WriteLine("Numerator should be a valid number {0} && {1}", int.MinValue, int.MaxValue);
        //        }



          

        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Please enter a number");
        //    }
        //    catch (OverflowException)
        //    {
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        Console.WriteLine("Denominator can not be zero");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

    }
}
