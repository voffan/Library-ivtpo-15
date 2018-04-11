using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private string name;

        public string Name { get { return name; } set { name = value; } }
        public int BookID { get; set; }

        public Book() { }
        public Book(string name)
        {
            this.name = name;
        }
    }
}
