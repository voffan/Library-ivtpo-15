using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class OrderBooks
    {
        private Order order;
        private Book book;
        private int count;
        private BookStatus bookStatus;
        public OrderBooks() { }
        public OrderBooks(Book book, int count, BookStatus status)
        {
            this.book = book;
            this.count = count;
            this.bookStatus = status;
        }
        public int OrderBooksID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get{ return order; } set{ order =value; } }
        public int BookID { get; set; }
        public Book Book { get { return book; } set { book = value; } }
        public int Count { get { return count; } set { count = value; } }
        public int BookStatusID { get; set; }
        public BookStatus BookStatus { get { return bookStatus; } set { bookStatus = value; } }
    }
}
