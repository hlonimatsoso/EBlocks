using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface IObserverAll<IProduct, ICategory, IOrder,IOrderDetails, ISupplier>
    {
        event Action<IEnumerable<IProduct>> OnProducts_Updated;

        event Action<IEnumerable<ICategory>> OnCategoies_Updated;

        event Action<IEnumerable<IOrder>> OnOrders_Updated;

        void AddProduct(IProduct product);
        void UpdateProduct(IProduct product);
        void DeleProduct(IProduct product);

        void AddOrder(IOrder order);
        void UpdateOrder(IOrder order);
        void DeleOrder(IOrder order);


    }
}
