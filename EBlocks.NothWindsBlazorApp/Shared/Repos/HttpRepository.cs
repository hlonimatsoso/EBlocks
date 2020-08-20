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

        private IConfiguration _config;

        public HttpRepository(HttpClient client, IConfiguration config)
        {
            this.HttpClient = client;
            this._config = config;
        }

        public IHttpResult<T> Add(T item)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            IEnumerable<T> result = default(IEnumerable<T>);

            try
            {
                Console.WriteLine($"Calling {this.ApiBaseUrl}orders");

                var response = await this.HttpClient.GetAsync($"{this.ApiBaseUrl}orders");

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
