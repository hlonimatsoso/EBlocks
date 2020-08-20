using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface INorthWindsService 
    {
        IOrderRepository OrderRepository { get; set; }

    }
}
