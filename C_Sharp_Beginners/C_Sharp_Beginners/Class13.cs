using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Part 27 - C# Tutorial - Properties in C#

// Read/Write Properties
// Read Only Properties
// Write Only Properties
// Auto Implemented Properties

// In C# to encapsulate and protect fields we use properties

// 1. We use get and set accessors to implement properties.
// 2. A property with both get and set accessor is a  Read/Write property.
// 3. A property with only get accessor is a Read Only Property.
// 4. A property with only set accessor is a Write only Property.

// Note : The advantage of properties over traditional Get() and Set() methods is that, you can access them as if they were public fields.

// Auto Implemented Properties

// If there is no additional login in the property accessors, then we can make use of auto-implemented properties introduced in C# 3.0

// Auto-implemented properties reduce the amount of code that we have to write

// When you use auto-implemented properties, the compiler creates a private, anonymous field that can only be accessed through the propertie's get
// and set accessors.


namespace C_Sharp_Beginnerss
{
    public class Student
    {
        private int ID;
        private string Name;
        private int PassMark = 35;



        //private string City;
        //private string Email;

        //public string city
        //{
        //    get
        //    {
        //        return City;
        //    }

        //    set
        //    {
        //        City = value;
        //    }
        //}

        //public string email
        //{
        //    get
        //    {
        //        return Email;
        //    }

        //    set
        //    {
        //        Email = value;
        //    }
        //}



        // Auto-implemented properties
        //compiler will create us automatically private field and then
        // this property will be used to read and write to that private field
        public string City { get; set; }
        public string Email { get; set; }

        public int id
        {
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Student Id can not be negative");
                }

                this.ID = value;
                
            }
            get
            {
                return this.ID;
            }
        }

        public string name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name can not be null or empty!");
                }

                this.Name = value;

            }

            get
            {
                return string.IsNullOrEmpty(this.Name) ? "No Name" : this.Name;
            }
        }

        public int passMark
        {
            get
            {
                return this.PassMark;
            }
        }


    }

        internal class Class13
    {
        //static void Main()
        //{
        //    Student student = new Student();
        //    student.id = 11280;
        //    student.name = "Khalid";

        //    Console.WriteLine("Studnet Id = {0}",student.id);
        //    Console.WriteLine("Studnet Name = {0}", student.name);
        //    Console.WriteLine("PassMark = {0}", student.passMark);

        //}

    }
}
