using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   public class Reader:Person
    {
        private string phone;
        private string address;
        public Reader():base() { }
        public Reader(string fname, string sname, string mname, DateTime birthdate, string phone, string address):base(fname, sname, mname, birthdate)
        {
            this.phone = phone;
            this.address = address;
            this.Orders = new List<Order>();
        }
        public int ReaderID { get; set; }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Address { get { return address; } set { address = value; } }

        public ICollection<Order> Orders { get; private set; }
    }
}