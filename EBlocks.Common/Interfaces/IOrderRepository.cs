using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface IOrderRepository
    {
         List<IOrder> GetAll();
    }
}
