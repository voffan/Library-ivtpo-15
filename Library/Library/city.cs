﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Library
{
    public class City
    {
        public City() { }
        public City(string city_name, Country city_country)
        {
            Name = city_name;
            Country = city_country;
        }
        public int CityID { get; set; }
        [Required]
        public string Name { get; set; }
        public int CountryID { get; set; }
        [Required]
        public Country Country { get; set; }
    }
    public class CityRepository : IRepository<City>, IDisposable
    {
        private LibraryContext context;

        private bool disposed = false;

        public CityRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<City> GetObjects()
        {
            return context.Cities.ToList();
        }
        public City GetObjectByID(int entityId)
        {
            return context.Cities.Find(entityId);
        }
        public void InsertObject(City entity)
        {
            context.Cities.Add(entity);
        }
        public void DeleteObject(int entityId)
        {
            City u = context.Cities.Find(entityId);
            context.Cities.Remove(u);
        }
        public void UpdateObject(City entity)
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
