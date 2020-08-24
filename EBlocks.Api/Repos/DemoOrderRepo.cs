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
                new Order{OrderID = new Guid("0e8eb30d-edc4-44c1-9673-11950687902f"),OrderDate = DateTime.Now,CustomerName="Dr Kalid Muhammad", CustomerContactNumber="0115551234" },
                new Order{OrderID = new Guid("c6b7277b-4c5d-4f97-806d-394cc619009e"),OrderDate = DateTime.Now.AddDays(-2),CustomerName="Dr Neil deGrasse Tyson", CustomerContactNumber="0125554321" },
                new Order{OrderID = new Guid("af1b97c3-03e4-400c-9d8a-13599544bd52"),OrderDate = DateTime.Now.AddDays(3),CustomerName="Tinky Winky", CustomerContactNumber="0225551122" }
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
