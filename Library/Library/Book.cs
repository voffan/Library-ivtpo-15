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
        public int Year { get; set; }
        public string ISBN { get; set; }
        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }
        public int Count { get; set; }
        public int GenreID { get; set; }
        public Genre Genre { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }

        public Book() { }
        public Book(string name, int count)
        {
            this.name = name;
        }
    }
}
