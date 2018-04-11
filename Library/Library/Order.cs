using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Order
    {
        private DateTime orderdate;
        private DateTime returndate;
        private Boolean status;
        public Order () { }
        public Order (DateTime orderdate, DateTime returndate, Boolean status)
        {
            this.orderdate = orderdate;
            this.returndate = returndate;
            this.status = status;
        }
        public int OrderID { get; set; }
        public DateTime OrderDate { get { return orderdate; } set { orderdate = value; } }
        public DateTime ReturnDate { get { return returndate; } set { returndate = value; } }
        public Boolean IsReturned { get { return status; } set { status = value; } }

        public int BookID { get; set; }
        public Book Book { get; set; }
        public int ReaderID { get; set; }
        public Reader Reader { get; set; }
    }
}
