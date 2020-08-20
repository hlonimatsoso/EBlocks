using EBlocks.Interfaces;
using EBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Api.Repos
{
    public class OrderRepository : MongoDbRepository<IOrder>, IOrderRepository
    {
        List<IOrder> IOrderRepository.GetAll()
        {
            return base.GetAll();
        }
    }
}
