using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library
{
        public class Lending
        {
            private string name;
            public Lending() { }
            public Lending(string name)
            {
                this.name = name;
            }
            public int LendingID { get; set; }
            public string Name { get { return name; } set { name = value; } }
        }
    public class LendingRepository : IRepository<Lending>, IDisposable
    {
        private LibraryContext context;

        private bool disposed = false;

        public LendingRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<Lending> GetObjects()
        {
            return context.Lendings.ToList();
        }
        public Lending GetObjectByID(int entityId)
        {
            return context.Lendings.Find(entityId);
        }
        public void InsertObject(Lending entity)
        {
            context.Lendings.Add(entity);
        }
        public void DeleteObject(int entityId)
        {
            Lending u = context.Lendings.Find(entityId);
            context.Lendings.Remove(u);
        }
        public void UpdateObject(Lending entity)
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
