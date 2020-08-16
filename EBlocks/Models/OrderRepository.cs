using EBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Models
{
    public class OrderRepository : MongoDbRepository<IOrder>, IOrderRepository
    {
        List<IOrder> IOrderRepository.GetAll()
        {
            return base.GetAll();
        }
    }
}
