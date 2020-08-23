using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface IOracle<IProduct, ICategory, IOrder,IOrderDetails, ISupplier> : IObserverAll<IProduct, ICategory, IOrder, IOrderDetails, ISupplier>
    {
        IEnumerable<IProduct> Products { get; set; }
        IEnumerable<IOrder> Orders { get; set; }
        IEnumerable<IOrderDetails> OrderDetails { get; set; }
        IEnumerable<ISupplier> Supplier { get; set; }
        IEnumerable<ICategory> Categories { get; set; }

    }
}
