using System;
using System.ComponentModel.DataAnnotations;

namespace Library_Management_System
{

    class Person
    {
        public string Name;
        public string Email;
        public string ID;

    }
/*
       public Person()
        {
           Name = "";
            Email = "Name + @usf.edu";
            ID = "U123456";
        }
*/

    class Student: Person
    {
        public string Major;
        public string GraduationYear;
    }
     /*   public Student(): base()
        {
            Major = "BAIS";
            GraduationYear = "2026";
        }

    */
    class Staff : Person
    {
        public string Position;
        public string Department;
    }
     /*   public Staff() : base()
        {
            Position = "Professor";
            Department = "BAIS";
        }
    }
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Student S1 = new Student { Name = "Akhil", Email = "akhil@usf.edu", ID = "S001", Major = "Business Analytics", GraduationYear = "2026" };
            Student S2 = new Student { Name = "Sandeep", Email = "sandeep@usf.edu", ID = "S002", Major = "Information Systems", GraduationYear = "2025" };
            Staff ST1 = new Staff { Name = "Grandon Gill", Email = "grandon@usf.edu", ID = "ST001", Position = "Librarian", Department = "Library Services" };
        }
    }
}
