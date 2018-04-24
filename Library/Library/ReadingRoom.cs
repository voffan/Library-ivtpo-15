using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Library
{
    public class ReadingRoom
    {
        public ReadingRoom() { }
        public ReadingRoom(string name)
        {
            Name = name;
        }
        public int ReadingRoomID { get; set; }
        public string Name { get; set; }
    }
    public class ReadingRoomRepository : IRepository<ReadingRoom>, IDisposable
    {
        private LibraryContext context;

        private bool disposed = false;

        public ReadingRoomRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<ReadingRoom> GetObjects()
        {
            return context.ReadingRooms.ToList();
        }
        public ReadingRoom GetObjectByID(int entityId)
        {
            return context.ReadingRooms.Find(entityId);
        }
        public void InsertObject(ReadingRoom entity)
        {
            context.ReadingRooms.Add(entity);
        }
        public void DeleteObject(int entityId)
        {
            ReadingRoom u = context.ReadingRooms.Find(entityId);
            context.ReadingRooms.Remove(u);
        }
        public void UpdateObject(ReadingRoom entity)
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
