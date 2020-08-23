using EBlocks.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace EBlocks.NothWindsBlazorApp.Shared.Repos
{
    public class HttpRepository<T> : IHttpRepository<T>
    {
        public HttpClient HttpClient { get; set; }
        public string ApiBaseUrl
        {
            get
            {
                return "http://localhost:5002/api/";
                return this._config.GetValue<string>("ApiBaseUrl");
            }
        }

        public IOracle<IProduct, ICategory, IOrder, IOrderDetails, ISupplier> Oracle { get ; set ; }

        private IConfiguration _config;

        public event Action<T> OnCreated;
        public event Action<T> OnUpdated;
        public event Action<T> OnDeleted;
        public event Action<IEnumerable<T>> OnCollectionInitialized;

        public HttpRepository(HttpClient client, IConfiguration config, IOracle<IProduct, ICategory, IOrder, IOrderDetails, ISupplier> oracle)
        {
            this.HttpClient = client;
            this._config = config;
            this.Oracle = oracle;
        }

        public IHttpResult<T> Add(T item)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<T>> GetAll(string path)
        {
            IEnumerable<T> result = default(IEnumerable<T>);

            try
            {

                Console.WriteLine($"Calling {this.ApiBaseUrl}{path}");

                var response = await this.HttpClient.GetAsync($"{this.ApiBaseUrl}{path}");

                var content = await response.Content.ReadAsStringAsync();

                Console.WriteLine($"Results: {content.ToString()}");
                var t = typeof(T);

                result = JsonSerializer.Deserialize<IEnumerable<T>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            }
            catch (Exception ex)
            {
                Console.WriteLine($"FATAL ERROR : {ex.ToString()}");
            }



            return result;
        }
    }
}
