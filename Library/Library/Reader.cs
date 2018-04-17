using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Library
{
   public class Reader:Person
    {
        private string phone;
        private string address;
        public Reader():base() { }
        public Reader(string fname, string sname, string mname, DateTime birthdate, string phone, string address):base(fname, sname, mname, birthdate)
        {
            this.phone = phone;
            this.address = address;
            this.Orders = new List<Order>();
        }
        public int ReaderID { get; set; }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Address { get { return address; } set { address = value; } }

        public ICollection<Order> Orders { get; private set; }
    }
    public class ReaderRepository : IRepository<Reader>, IDisposable
    {
        private LibraryContext context;

        private bool disposed = false;

        public ReaderRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<Reader> GetObjects()
        {
            return context.Readers.ToList();
        }
        public Reader GetObjectByID(int entityId)
        {
            return context.Readers.Find(entityId);
        }
        public void InsertObject(Reader entity)
        {
            context.Readers.Add(entity);
        }
        public void DeleteObject(int entityId)
        {
            Reader u = context.Readers.Find(entityId);
            context.Readers.Remove(u);
        }
        public void UpdateObject(Reader entity)
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