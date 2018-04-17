using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Library
{
    public class Person
    {
        public Person() { }
        public Person (string Person_fname, string Person_sname, string Person_mname, DateTime Person_birthdate)
        {
            FirstName = Person_fname;
            LastName = Person_sname;
            MiddleName = Person_mname;
            SetFullName();
            Birthday = Person_birthdate;
        }
        private void SetFullName()
        {
            FullName = FirstName + " " + LastName + " " + MiddleName;
        }
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FullName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
    }
    public class PersonRepository : IRepository<Person>, IDisposable
    {
        private LibraryContext context;

        private bool disposed = false;

        public PersonRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<Person> GetObjects()
        {
            return context.Persons.ToList();
        }
        public Person GetObjectByID(int entityId)
        {
            return context.Persons.Find(entityId);
        }
        public void InsertObject(Person entity)
        {
            context.Persons.Add(entity);
        }
        public void DeleteObject(int entityId)
        {
           Person u = context.Persons.Find(entityId);
            context.Persons.Remove(u);
        }
        public void UpdateObject(Person entity)
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
