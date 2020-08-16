using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface INorthWindsService 
    {
        public IOrderRepository OrderRepository { get; set; }

    }
}
