using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI
{
    
    /// <summary>
    /// defenition  of a book
    /// </summary>
    public class Book
    {
        #region properties
        public int ISBN { get; set; } //ISBN of the book
        public string Title { get; set; }// title of the book
        public DateTime PublishedYear { get; set; }//published year
        public decimal price { get; set; }
        public int Count { get; set; }
        #endregion


        #region
        public void Checkout()
        {
          //  Count = Count - 1;
            Count--;
        }
        public void Return()
        {
            Count++;
        }
        #endregion
    }
}
