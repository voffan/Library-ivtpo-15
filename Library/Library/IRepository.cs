using System;
using System.Collections.Generic;

namespace Library
{
    public interface IRepository<T>:IDisposable
    {
        IEnumerable<T> GetObjects();
        T GetObjectByID(int entityId);
        void InsertObject(T entity);
        void DeleteObject(int entityId);
        void UpdateObject(T entity);
        void Save();
    }
}
