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

    class Student: Person
    {
        public string Major;
        public string GraduationYear;
    }

    class Staff : Person
    {
        public string Position;
        public string Department;
    }

    class book
	{
		public string title;
		public string author;
		public string isbn;
		public int availCopies;

		public string BorrowBook()
		{
			return title;
		}
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student { Name = "Akhil", Email = "akhil@usf.edu", ID = "S001", Major = "Business Analytics", GraduationYear = "2026" };
            Student S2 = new Student { Name = "Sandeep", Email = "sandeep@usf.edu", ID = "S002", Major = "Information Systems", GraduationYear = "2025" };
            Staff ST1 = new Staff { Name = "Grandon Gill", Email = "grandon@usf.edu", ID = "ST001", Position = "Librarian", Department = "Library Services" };

            book b1 = new book { title = "The Art of Data Strategy", author = "Liam Reynolds", isbn = "ISBN111", availCopies = 4 };
			book b2 = new book { title = "usiness Insights with AI", author = "Olivia Carter", isbn = "ISBN222", availCopies = 3 };
			book b3 = new book { title = "Analytics in Action", author = "Nathan Brooks", isbn = "ISBN333", availCopies = 6 };

			Console.WriteLine("Books in Library:");
			Console.WriteLine("Title: " + b1.title + ", Author: " + b1.author + ", Available Copies: " + b1.availCopies);
			Console.WriteLine("Title: " + b2.title + ", Author: " + b2.author + ", Available Copies: " + b2.availCopies);
			Console.WriteLine("Title: " + b3.title + ", Author: " + b3.author + ", Available Copies: " + b3.availCopies);

			Console.WriteLine();
			Console.WriteLine("Borrowing Books...");
			Console.WriteLine("borrowed " + b1.BorrowBook());
        }
    }
}
