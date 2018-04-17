using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Library
{
    public class Librarian: Person
    {
        public int LibrarianID { get; set; }
        public int PositionID { get; set; }
        public Position Position { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Librarian():base() { }
        public Librarian(string Person_fname, string Person_sname, string Person_mname, DateTime Person_birthdate, Position position, User user, string phone="", string address="")
            : base(Person_fname, Person_sname, Person_mname, Person_birthdate)
        {
            Position = position;
            User = user;
            Phone = phone;
            Address = address;
        }
    }
    public class LibrarianRepository : IRepository<Librarian>, IDisposable
    {
        private LibraryContext context;

        private bool disposed = false;

        public LibrarianRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<Librarian> GetObjects()
        {
            return context.Librarians.ToList();
        }
        public Librarian GetObjectByID(int entityId)
        {
            return context.Librarians.Find(entityId);
        }
        public void InsertObject(Librarian entity)
        {
            context.Librarians.Add(entity);
        }
        public void DeleteObject(int entityId)
        {
            Librarian u = context.Librarians.Find(entityId);
            context.Librarians.Remove(u);
        }
        public void UpdateObject(Librarian entity)
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
