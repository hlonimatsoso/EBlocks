using EBlocks.Interfaces;
using EBlocks.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBlocks.Api.Repos
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

        public event Action<IOrder> OnCreated;
        public event Action<IOrder> OnUpdated;
        public event Action<IOrder> OnDeleted;


        public bool Delete(IOrder entity)
        {
            this.OnDeleted?.Invoke(entity);
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
            this._orders.Add(entity);
            this.OnCreated?.Invoke(entity);
            return true;
        }

        public bool Update(IOrder entity)
        {
            throw new NotImplementedException();
        }
    }
}
