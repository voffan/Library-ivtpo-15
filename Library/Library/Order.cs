﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Library
{
    public class Order
    {
        private DateTime orderdate;
        private DateTime? returndate;
        private Boolean status;
        public Order () { }
        public Order (DateTime orderdate, Boolean status)
        {
            this.orderdate = orderdate;
            this.returndate = null;
            this.status = status;
        }
        public int OrderID { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get { return orderdate; } set { orderdate = value; } }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ReturnDate { get { return returndate; } set { returndate = value; } }
        
        public Boolean IsReturned { get { return status; } set { status = value; } }

        public int ReaderID { get; set; }
        public Reader Reader { get; set; }
        public int? LendingID { get; set; }
        public Lending Lending { get; set; }
        public int? ReadingRoomID { get; set; }
        public ReadingRoom ReadingRoom { get; set; }
    }

    public class OrderRepository : IRepository<Order>, IDisposable
    {
        private LibraryContext context;

        private bool disposed = false;

        public OrderRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<Order> GetObjects()
        {
            return context.Orders.ToList();
        }
        public Order GetObjectByID(int entityId)
        {
            return context.Orders.Find(entityId);
        }
        public void InsertObject(Order entity)
        {
            context.Orders.Add(entity);
        }
        public void DeleteObject(int entityId)
        {
            Order u = context.Orders.Find(entityId);
            context.Orders.Remove(u);
        }
        public void UpdateObject(Order entity)
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

