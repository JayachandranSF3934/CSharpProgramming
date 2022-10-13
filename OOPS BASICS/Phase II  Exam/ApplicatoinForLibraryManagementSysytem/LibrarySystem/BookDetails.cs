using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public enum BookStatus{Default,Issued, Returned}
    public class BookDetails
    {
        private static int s_bookId = 100;  // field

        public string BookId { get; set; }  // porperty
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int BookCount { get; set; }
        public BookStatus Status { get; set; }

        // Constructor

        public BookDetails( string bookId ,string bookName, string authorName, int bookCount, BookStatus status)
        {
            s_bookId++;
            BookId = "BID"+s_bookId;
            BookName = bookName;
            AuthorName = authorName;
            BookCount = bookCount;
            Status = status;

        }
    }
}