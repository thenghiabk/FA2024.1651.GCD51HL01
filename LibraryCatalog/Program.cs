using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int Year { get; private set; }
        public bool IsAvailable { get; set; }

        public Book(string title, string author, int year)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
            this.IsAvailable = true;
        }
    }

    class LibraryCatalog
    {
        private List<Book> books;

        public LibraryCatalog()
        {
            books = new List<Book>();
        }

        public bool AddBook(Book book)
        {
            books.Add(book);

            return true;
        }

        public Book BorrowBook(string title)
        {

            foreach (Book book in books)
            {
                if (book.Title.Contains(title)){
                    if(book.IsAvailable == true)
                    {
                        book.IsAvailable = false;
                        return book;
                    }   
                }
            }

            return null;
        }

        public bool ReturnBook(Book book)
        {

            return true;
        }

        public void DisplayAllBooks()
        {
            foreach(Book book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}, Available: {book.IsAvailable}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Book A", "Author A", 2020);
            Book book2 = new Book("Book B", "Author B", 2021);
            Book book3 = new Book("Book C", "Author C", 2022);
            Book book4 = new Book("Book D", "Author D", 2023);

            LibraryCatalog libraryCatalog = new LibraryCatalog();


            // Add book
            libraryCatalog.AddBook(book1);
            libraryCatalog.AddBook(book2);
            libraryCatalog.AddBook(book3);
            libraryCatalog.AddBook(book4);

            libraryCatalog.DisplayAllBooks();


            // Borrow book A
            Book result = libraryCatalog.BorrowBook("Book A");

            if(result == null)
            {
                Console.WriteLine("This book is not available to borrow.");
            } 
            else
            {
                Console.WriteLine("A book has been borrowed.");
                Console.WriteLine($"Title: {result.Title}, Author: {result.Author}, Year: {result.Year}");
            }

            // Borrow book A again
            result = libraryCatalog.BorrowBook("Book A");

            if (result == null)
            {
                Console.WriteLine("This book is not available to borrow.");
            }
            else
            {
                Console.WriteLine("A book has been borrowed.");
                Console.WriteLine($"Title: {result.Title}, Author: {result.Author}, Year: {result.Year}");
            }


            libraryCatalog.DisplayAllBooks();
        }
    }
}
