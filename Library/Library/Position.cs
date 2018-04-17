using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Library
{
    public class Position
    {
        public Position(){}
        public Position(string position_name)
        {
            Name = position_name;
        }
        public string Name { get; set; }
        public int PositionID { get; set; }
    }

    public class PositionRepository : IRepository<Position>, IDisposable

    {
        private LibraryContext context;
        private bool disposed = false;
        public PositionRepository(LibraryContext context)

        {
            this.context = context;
        }

        public IEnumerable<Position> GetObjects()

        {
            return context.Positions.ToList();
        }

        public Position GetObjectByID(int entityId)

        {
            return context.Positions.Find(entityId);
        }

        public void InsertObject(Position entity)

        {
            context.Positions.Add(entity);
        }

        public void DeleteObject(int entityId)

        {
            Position position = context.Positions.Find(entityId);
            context.Positions.Remove(position);
        }

        public void UpdateObject(Position entity)

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