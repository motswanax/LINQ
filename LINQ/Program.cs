using System;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // Without LINQ
            var cheapBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Price < 10)
                    cheapBooks.Add(book);
            }

            foreach (Book book in cheapBooks)
            {
                Console.WriteLine(book.Title + " " + book.Price);
            }
        }
    }
}
