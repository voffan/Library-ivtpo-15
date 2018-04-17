using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Library
{
    public class Book
    {
        public string Name { get; set; }
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
        public Book(string name, int count, Author author, Publisher publisher)
        {
            Name = name;
            Count = count;
            Author = author;
            Publisher = publisher;
        }
    }

    public class BookRepository : IRepository<Book>, IDisposable
    {
        private LibraryContext context;

        private bool disposed = false;

        public BookRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<Book> GetObjects()
        {
            return context.Books.ToList();
        }
        public Book GetObjectByID(int entityId)
        {
            return context.Books.Find(entityId);
        }
        public void InsertObject(Book entity)
        {
            context.Books.Add(entity);
        }
        public void DeleteObject(int entityId)
        {
            Book u = context.Books.Find(entityId);
            context.Books.Remove(u);
        }
        public void UpdateObject(Book entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {

            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
