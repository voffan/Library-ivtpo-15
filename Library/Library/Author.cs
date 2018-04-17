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
    public class Author:Person
    {
        public int AuthorID { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Death_date { get; set; }

        public Author():base() { }
        public Author(string fname, string sname, string mname, DateTime birthdate, DateTime death_date, Country country):base(fname, sname, mname, birthdate)
        {
            Death_date = death_date;
            Country = country;
            Books = new List<Book>();
        }

        public ICollection<Book> Books { get; private set; }
    }
    public class AuthorRepository : IRepository<Author>, IDisposable
    {
        private LibraryContext context;

        private bool disposed = false;

        public AuthorRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<Author> GetObjects()
        {
            return context.Authors.ToList();
        }
        public Author GetObjectByID(int entityId)
        {
            return context.Authors.Find(entityId);
        }
        public void InsertObject(Author entity)
        {
            context.Authors.Add(entity);
        }
        public void DeleteObject(int entityId)
        {
            Author u = context.Authors.Find(entityId);
            context.Authors.Remove(u);
        }
        public void UpdateObject(Author entity)
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
