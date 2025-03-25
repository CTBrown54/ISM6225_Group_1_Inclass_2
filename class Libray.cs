using System;

namespace class_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            Book book2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            Book book3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);

            Student student1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            Student student2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
            Staff staff1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");

            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddPatron(student1);
            library.AddPatron(student2);
            library.AddPatron(staff1);
        }
    }

    public class Library
    {
        private List<Book> Books = new List<Book>();
        private List<Person> Patrons = new List<Person>();

        // Method to add a new book to the library
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        // Method to add a new patron to the library
        public void AddPatron(Person patron)
        {
            Patrons.Add(patron);
        }

        // Method to display books in the library
        public void DisplayBooksInLibrary()
        {
            Console.WriteLine("Books in Library:");
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
        }

        // Method to display patrons in the library
        public void DisplayPatronsInLibrary()
        {
            Console.WriteLine("\nPatrons in Library:");
            foreach (var patron in Patrons)
            {
                Console.WriteLine(patron);
            }
        }

    }

 