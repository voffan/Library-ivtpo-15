using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Genre
    {
        private string name;
        public Genre(string name)
        {
            this.name = name;
            this.Books = new List<Book>();
        }
        public int GenreID { get; set; }
        public string Name { get { return name; } set { name = value; } }
        public ICollection<Book> Books { get; private set; }
    }
}
