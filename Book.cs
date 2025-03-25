using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Book
{
	internal class Book
	{
		static void Main(string[] args)
		{
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
	}
}
