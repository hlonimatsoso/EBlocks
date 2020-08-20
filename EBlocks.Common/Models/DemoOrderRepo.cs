using EBlocks.Interfaces;
using EBlocks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Models
{
    public class DemoOrderRepo : IOrderRepository
    {

        private readonly List<IOrder> _orders;

        public DemoOrderRepo()
        {
            this._orders = new List<IOrder> {
            new Order{Id = new Guid(),OrderID = 100,OrderDate = DateTime.Now }
            };


        }

        public bool Delete(IOrder entity)
        {
            throw new NotImplementedException();
        }

        public List<IOrder> GetAll()
        {
            return this._orders;
        }

        public IOrder GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(IOrder entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(IOrder entity)
        {
            throw new NotImplementedException();
        }
    }
}
