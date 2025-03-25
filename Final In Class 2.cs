using System;
using System.Collections.Generic;

namespace Library_Management_System
{
    // Base class for all people (students and staff)
    public class Person
    {
        public string Name;
        public string Email;
        public string ID;
    }

    // Derived class for Students
    public class Student : Person
    {
        public string Major;
        public int GraduationYear;

        public Student(string name, string email, string id, string major, int graduationYear)
        {
            Name = name;
            Email = email;
            ID = id;
            Major = major;
            GraduationYear = graduationYear;
        }
    }

    // Derived class for Staff
    public class Staff : Person
    {
        public string Position;
        public string Department;

        public Staff(string name, string email, string id, string position, string department)
        {
            Name = name;
            Email = email;
            ID = id;
            Position = position;
            Department = department;
        }
    }

    // Class to represent a Book in the library
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public int AvailableCopies;

        public Book(string title, string author, string isbn, int availableCopies)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            AvailableCopies = availableCopies;
        }

        // Method to borrow a book
        public bool BorrowBook()
        {
            if (AvailableCopies > 0)
            {
                AvailableCopies--;
                return true;
            }
            return false;
        }
    }

    // Class to manage the Library
    public class Library
    {
        private List<Book> Books = new List<Book>();
        private List<Person> Patrons = new List<Person>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddPatron(Person patron)
        {
            Patrons.Add(patron);
        }

        public void DisplayBooksInLibrary()
        {
            Console.WriteLine("Books in Library:");
            foreach (var book in Books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
            }
        }

        public void DisplayPatronsInLibrary()
        {
            Console.WriteLine("\nPatrons in Library:");
            foreach (var patron in Patrons)
            {
                Console.WriteLine($"Name: {patron.Name}, ID: {patron.ID}");
            }
        }

        // Borrow Book
        public void BorrowBook(Book book, Person patron)
        {
            if (book.BorrowBook())
            {
                Console.WriteLine($"{patron.Name} borrowed '{book.Title}'");
            }
            else
            {
                Console.WriteLine($"Sorry, '{book.Title}' is not available.");
            }
        }

        // Return Book
        public void ReturnBook(Book book, Person patron)
        {
            book.AvailableCopies++;
            Console.WriteLine($"{patron.Name} returned '{book.Title}'");
        }
    }

    // Main Program to test functionality
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating books
            Book book1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            Book book2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            Book book3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);

            // Creating patrons (students and staff)
            Student student1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            Student student2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
            Staff staff1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");

            // Creating a library and adding books and patrons
            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddPatron(student1);
            library.AddPatron(student2);
            library.AddPatron(staff1);

            // Displaying books and patrons in the library
            library.DisplayBooksInLibrary();
            library.DisplayPatronsInLibrary();

            Console.WriteLine("\nBorrowing Books...");
            library.BorrowBook(book2, student2);  // Sandeep borrows "Business Insights with AI"
            library.BorrowBook(book3, student1);  // Akhil borrows "Analytics in Action"

            Console.WriteLine("\nBooks after borrowing:");
            library.DisplayBooksInLibrary();
        }
    }
}
