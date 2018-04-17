using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Library
{
    public class BookStatus
    {
        public BookStatus() { }
        public BookStatus(string status_name)
        {
            Name = status_name;
        }
        public int BookStatusID { get; set; }
        public string Name { get; set; }
    }

    public class BookStatusRepository : IRepository<BookStatus>, IDisposable
    {
        private LibraryContext context;

        private bool disposed = false;

        public BookStatusRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<BookStatus> GetObjects()
        {
            return context.BookStatuses.ToList();
        }
        public BookStatus GetObjectByID(int entityId)
        {
            return context.BookStatuses.Find(entityId);
        }
        public void InsertObject(BookStatus entity)
        {
            context.BookStatuses.Add(entity);
        }
        public void DeleteObject(int entityId)
        {
            BookStatus u = context.BookStatuses.Find(entityId);
            context.BookStatuses.Remove(u);
        }
        public void UpdateObject(BookStatus entity)
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