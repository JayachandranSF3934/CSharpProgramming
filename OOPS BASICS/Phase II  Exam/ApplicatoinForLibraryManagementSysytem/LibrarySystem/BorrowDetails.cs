using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem
{
    
    public class BorrowDetails
    {
        private static int s_borrowId = 300;

        public string BorrowId { get; set; }
        public string BookId { get; set; }
        public string RegisterId { get; set; }
        public DateTime BorrowDate { get; set; }
        public BookStatus Status { get; set; }



        // Constructor

        public BorrowDetails(string borrowId,string bookId, string registerId, DateTime borrowDate, BookStatus status)
        {
            s_borrowId++;
            BorrowId = "LB"+s_borrowId;
            BookId = bookId;
            RegisterId = registerId;
            BorrowDate = borrowDate;
            Status = status;
        }
    }
}