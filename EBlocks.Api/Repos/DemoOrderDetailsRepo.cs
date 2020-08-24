using EBlocks.Interfaces;
using EBlocks.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBlocks.Api.Repos
{
    public class DemoOrderDetailsRepo : IOrderDetailsRepository
    {

        private readonly List<IOrderDetails> _orderDetails;

        public DemoOrderDetailsRepo()
        {
            this._orderDetails = new List<IOrderDetails> {
                new OrderDetails{OrderID = 1}
            };

        }

        public event Action<IOrderDetails> OnCreated;
        public event Action<IOrderDetails> OnUpdated;
        public event Action<IOrderDetails> OnDeleted;


        public bool Delete(IOrderDetails entity)
        {
            this.OnDeleted?.Invoke(entity);
            throw new NotImplementedException();
        }

        public List<IOrderDetails> GetAll()
        {
            return this._orderDetails;
        }

        public IOrder GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(IOrderDetails entity)
        {
            this._orderDetails.Add(entity);
            this.OnCreated?.Invoke(entity);
            return true;
        }

        public bool Update(IOrderDetails entity)
        {
            throw new NotImplementedException();
        }
    }
}
