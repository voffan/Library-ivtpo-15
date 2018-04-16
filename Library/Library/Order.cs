using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library
{
    public class Order
    {
        private DateTime orderdate;
        private DateTime? returndate;
        private Boolean status;
        public Order () { }
        public Order (DateTime orderdate, Boolean status)
        {
            this.orderdate = orderdate;
            this.returndate = null;
            this.status = status;
        }
        public int OrderID { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get { return orderdate; } set { orderdate = value; } }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ReturnDate { get { return returndate; } set { returndate = value; } }
        
        public Boolean IsReturned { get { return status; } set { status = value; } }

        public int BookID { get; set; }
        public Book Book { get; set; }
        public int ReaderID { get; set; }
        public Reader Reader { get; set; }
        public int? LendingID { get; set; }
        public Lending Lending { get; set; }
        public int? ReadingRoomID { get; set; }
        public ReadingRoom ReadingRoom { get; set; }
    }
}
