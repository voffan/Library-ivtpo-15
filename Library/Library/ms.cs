using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library
{
    public class Person
    {
        private string fname;
        private string sname;
        private string mname;
        private string fullname;
        private DateTime birthdate;
        public Person() { }
        public Person (string Person_fname, string Person_sname, string Person_mname, DateTime Person_birthdate)
        {
            fname = Person_fname;
            sname = Person_sname;
            mname = Person_mname;
            SetFullName();
            birthdate = Person_birthdate;
        }
        private void SetFullName()
        {
            fullname = fname + " " + sname + " " + mname;
        }
        public int PersonID { get; set; }
        public string FirstName { get { return fname; } set { fname = value; SetFullName(); } }
        public string LastName { get { return sname; } set { sname = value; SetFullName(); } }
        public string MiddleName { get { return mname; } set { mname = value; SetFullName(); } }
        public string FullName { get { return fullname; } }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get { return birthdate; } set { birthdate = value; } }
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
            context.UPersons.Remove(u);
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
