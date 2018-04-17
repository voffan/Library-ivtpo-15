using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Library
{
    public class Country
    {
        private string name;
        public Country() { }
        public Country(string country_name) 
        {
            name = country_name;
        }
        public int CountryID { get; set; }
        public string Name { get { return name; } set { name = value; } }
    }
    public class CountryRepository : IRepository<Country>, IDisposable
    {
        private LibraryContext context;

        private bool disposed = false;

        public CountryRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<Country> GetObjects()
        {
            return context.Countries.ToList();
        }
        public Country GetObjectByID(int entityId)
        {
            return context.Countries.Find(entityId);
        }
        public void InsertObject(Country entity)
        {
            context.Countries.Add(entity);
        }
        public void DeleteObject(int entityId)
        {
            Country country = context.Countries.Find(entityId);
            context.Countries.Remove(country);
        }
        public void UpdateObject(Country entity)
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