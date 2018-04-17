using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Library
{
    public class library
    {
        public library(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }
        public int LibraryID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
    public class libraryRepository : IRepository<library>, IDisposable
    {
        private LibraryContext context;

        private bool disposed = false;

        public libraryRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<library> GetObjects()
        {
            return context.Libraries.ToList();
        }
        public library GetObjectByID(int entityId)
        {
            return context.Libraries.Find(entityId);
        }
        public void InsertObject(library entity)
        {
            context.Libraries.Add(entity);
        }
        public void DeleteObject(int entityId)
        {
            library u = context.Libraries.Find(entityId);
            context.Libraries.Remove(u);
        }
        public void UpdateObject(library entity)
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

