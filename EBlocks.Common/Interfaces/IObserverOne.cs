using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface IObserverOne<T>
    {
        event Action<T> OnCreated;
        event Action<T> OnUpdated;
        event Action<T> OnDeleted;
        event Action<IEnumerable<T>> OnCollectionInitialized;

        //EventCallback<IEnumerable<IOrder>> OnOrders_GetAll { get; set; }



    }
}
