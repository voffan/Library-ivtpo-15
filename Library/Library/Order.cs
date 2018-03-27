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
        public DateTime OrderDate { get { return orderdate; } set { orderdate = value; } }
        public DateTime ReturnDate { get { return returndate; } set { returndate = value; } }
        public Boolean IsReturned { get { return status; } set { status = value; } }
    }
}
