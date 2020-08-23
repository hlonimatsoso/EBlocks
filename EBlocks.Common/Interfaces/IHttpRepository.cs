using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EBlocks.Interfaces
{
    public interface IHttpRepository<T>:IObserverOne<T>
    {
        IOracle<IProduct, ICategory, IOrder, IOrderDetails, ISupplier> Oracle { get; set; }

        Task<IEnumerable<T>> GetAll(string path);

        IHttpResult<T> Add(T item);

        HttpClient HttpClient { get; set; }

        string ApiBaseUrl { get; }

    }
}
