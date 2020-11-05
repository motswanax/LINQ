using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ Query Operators [always start with the from and end with select]
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            // With LINQ Extension Methods
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            foreach (var book in cheapBooks)
            {
                //Console.WriteLine(book.Title + " " + book.Price);
                Console.WriteLine(book);
            }

            // SINGLE OBJECT
            var book1 = books.SingleOrDefault(books => books.Title == "ASP.NET MVC");
            Console.WriteLine(book1.Title);

            // first object
            var book2 = books.First(b => b.Title == "How to code");
            Console.WriteLine(book2.Title + " " + book2.Price);


            // last
            var book3 = books.LastOrDefault(books => books.Title == "ASP.NET MVC");
            Console.WriteLine(book3.Title + " " + book3.Price);

            // skip
            var pagedBooks = books.Skip(2).Take(3);
            Console.WriteLine("\nLast 3 books: ");
            foreach (var pageBook in pagedBooks)
            {
                Console.WriteLine(pageBook.Title);
            }

            // count
            Console.WriteLine($"There are {books.Count()} books. " );

            Console.WriteLine($"The highest priced book is P{books.Max(b => b.Price)}");
        }
    }
}
