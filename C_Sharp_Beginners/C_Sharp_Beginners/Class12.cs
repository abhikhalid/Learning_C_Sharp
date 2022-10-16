using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Beginners
{
    //Part 26 - C# Tutorial - Why Properties

    // Making the class fields public and exposing to the externam workd is bad, 
    //as you will not have control over what gets assigned and returned.

    //public class Student
    //{
    //    public int ID;
    //    public string name;
    //    public int PassMark = 35;
    //}

    //proble with public fields

    // 1. ID should always be non negative number
    // 2. Name can not be set to NULL
    // 3. If Student Name is missing "No Name" should be retured
    // 4. PassMark should be read only


    //internal class Class12
    //{
    //    static void Main()
    //    {
    //        Student s1 = new Student();
    //        s1.ID = -101;
    //        s1.name = null;
    //        s1.PassMark = 0;


    //        Console.WriteLine("ID = {0} && Name = {1} && PassMark = {2}", s1.ID, s1.name, s1.PassMark);
    //    }

    //}


    ////////////////////////////////////////////////////////////////////////////////

    //Getter and Setter Methods

    // Programming languages that does not have properties use getter and setter methods to encapsulate and protect fields.

    public class Student
    {
        private int ID;
        private string Name;
        private int PassMark = 35;


        public int GetPassMark()
        {
            return this.PassMark;
        }


        public void SetId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Student id can not be negative");
            }

            this.ID = id;
        }

        public int GetId()
        {
            return this.ID;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name can not be null or empty");
            }
            this.Name = Name;
        }

        public string GetName()
        {
            //if (string.IsNullOrEmpty(this.Name))
            //{
            //    return "No Name";
            //}
            //return this.Name;

            return string.IsNullOrEmpty(this.Name) ? "No Name" : this.Name;

        }
    }


    internal class Class12
    {
        //static void Main()
        //{
        //    Student student = new Student();
        //    student.SetId(101);

        //    Console.WriteLine("Student Id = {0}", student.GetId());
        //}
    }
}