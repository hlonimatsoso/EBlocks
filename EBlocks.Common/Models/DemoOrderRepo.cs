using EBlocks.Interfaces;
using EBlocks.Interfaces;
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

        public List<IOrder> GetAll()
        {
            return this._orders;
        }
    }
}
