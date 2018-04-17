using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Library
{
    public class Genre
    {
        public Genre(string name)
        {
            Name = name;
            this.Books = new List<Book>();
        }
        public int GenreID { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; private set; }
    }
    public class GenreRepository : IRepository<Genre>, IDisposable
    {
        private LibraryContext context;

        private bool disposed = false;

        public GenreRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<Genre> GetObjects()
        {
            return context.Genres.ToList();
        }
        public Genre GetObjectByID(int entityId)
        {
            return context.Genres.Find(entityId);
        }
        public void InsertObject(Genre entity)
        {
            context.Genres.Add(entity);
        }
        public void DeleteObject(int entityId)
        {
            Genre u = context.Genres.Find(entityId);
            context.Genres.Remove(u);
        }
        public void UpdateObject(Genre entity)
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
