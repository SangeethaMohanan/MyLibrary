using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI
{
    public class Program
    {
        static void Main(string[] args)//this is method too
        {
            var book = new Book();
            book.Title = "Intro to C#";
            book.ISBN = 1234567;
            book.price = 12.34M;
            book.Count = 5;
            book.PublishedYear = new DateTime(2010, 1, 1);

            Library.AddBook(book);
            // creating another instance of book variable to add another book

            book = new Book();
            book.Title = "Intro to Python";
            book.ISBN = 1238757;
            book.price = 22.34M;
            book.Count = 2;
            book.PublishedYear = new DateTime(2012, 11, 1);

            Library.AddBook(book);
            Library.PrintBooks();
        }
    }
}
