using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class OrderBooks
    {
        public OrderBooks() { }
        public OrderBooks(Book book, int count, BookStatus status)
        {
            Book = book;
            Count = count;
            BookStatus = status;
        }
        public int OrderBooksID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int Count { get; set; }
        public int BookStatusID { get; set; }
        public BookStatus BookStatus { get; set; }
    }
}
