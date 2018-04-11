using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class library
    {
        private string name;
        private string address;
        private string phone;
        public library(string name, string address, string phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
        public int LibraryID { get; set; }
        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
    }
}
