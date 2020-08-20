using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface IOrderRepository:IRepository<IOrder>
    {
         List<IOrder> GetAll();
    }
}
