using EBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Models
{
    public class NorthWindService : INorthWindsService
    {
        public IOrderRepository OrderRepository { get ; set ; }

        public NorthWindService(IOrderRepository orderRepo)
        {
            this.OrderRepository = orderRepo;
        }
    }
}
