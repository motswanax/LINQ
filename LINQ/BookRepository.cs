using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "How to code", Price = 5},
                new Book() {Title = "ASP.NET MVC", Price = 8.99f},
                new Book() {Title = "Idiot's guide to C#", Price = 25.55f},
                new Book() {Title = ".Net Magnet", Price = 9},
                new Book() {Title = "The Missing Manual: C#", Price = 9.45f}
            };
        }
    }
}
