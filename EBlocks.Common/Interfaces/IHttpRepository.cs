using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EBlocks.Interfaces
{
    public interface IHttpRepository<T>
    {
        Task<IEnumerable<T>> GetAll();

        IHttpResult<T> Add(T item);

        HttpClient HttpClient { get; set; }

        string ApiBaseUrl { get; }

    }
}
