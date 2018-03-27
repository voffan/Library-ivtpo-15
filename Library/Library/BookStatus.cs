using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookStatus
    {
        private string name;
        public BookStatus() { }
        public BookStatus(string status_name)
        {
            name = status_name;
        }
        public string Name { get { return name; } }
    }
}
