using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI
{
    static class Library
    // when ever i mark a class static everything inside of this is suppose to be static
    {
        #region
        public static string Name { get; set; }

        public static string Address { get; set; }

        /// <summary>
        /// Collection of books
        /// </summary>
        public static List<Book> Books { get; set; }
        // create a collection of books(creating Bag to put in the interntory)

        #endregion
        #region Contructor
         static Library()
        {           
            Books = new List<Book>(); 
            //internally creat a contructor
        }
        #endregion
        #region Methods
        /// <summary>
        /// creating a method
        /// </summary>
        /// <param name="book"></param>
        public static void AddBook(Book book)
        {
            //adds books to list of books
   
            Books.Add(book);
        }

        public static void PrintBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine("Title: {0},ISBN:{1}, Price: {2}, Published {3}",book.Title,book.ISBN,book.price,book.PublishedYear);

            }
        }

        #endregion
    }
}
