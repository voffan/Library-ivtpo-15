using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Library
{
    class User {
        private string name;
        private string pwd;
        public User() { }
        public User(string user_name, string user_pwd)
        {
            name = user_name;
            pwd = user_pwd;
        }
        public string Login { get { return name; } }
        public string Password { get { return pwd; } }
    }

    public class UserRepository:IRepository<User>, IDisposable
    {
        private LibraryContext context;

        private bool disposed = false;

        public UserRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetObjects() 
        {
            return context.User.ToList();
        }
        User GetObjectByID(int entityId) 
        {
            return context.User.Find(entityId);
        }
        void InsertObject(User entity) 
        {
            context.User.Add(entity);
        }
        void DeleteObject(int entityId) 
        {
            User u = context.User.Find(entityId);
            context.User.Remove(u);
        }
        void UpdateObject(User entity) 
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        void Save() 
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