using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private string name;
        private string isbn;
        private int count;
        private int year;
        private Publisher publisher;
        private Author author;
        private Genre genre;



        public Book() { }
        public Book(string _name, string _ISBN, int _count, int _year, Publisher _publisher, Author _author, Genre _genre)
        {
            name = _name;
            isbn = _ISBN;
            count = _count;
            year = _year;
            publisher = _publisher;
            author = _author;
            genre = _genre;
        }
        public string Name { get { return name; } set { name = value; } }
        public string ISBN { get { return isbn; } set { isbn = value; } }
        public int Count { get { return count; } set { count = value; } }
        public int Year { get { return year; } set { year = value; } }
        public Publisher Publisher { get { return publisher; } set { publisher = value; } }
        public Genre Genre { get { return genre; } set { genre = value; } }
        public Author Author { get { return author; } set { author = value; } }


    }
}
