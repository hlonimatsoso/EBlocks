using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface INorthWindsService
    {
        IOrderRepository OrderRepository { get; set; }

        IProductRepository ProductRepository { get; set; }

        IOrderDetailsRepository OrderDetailsRepository { get; set; }

        ICategoryRepository CategoryRepository { get; set; }
        ISupplierRepository SupplierRepository { get; set; }


    }
}
