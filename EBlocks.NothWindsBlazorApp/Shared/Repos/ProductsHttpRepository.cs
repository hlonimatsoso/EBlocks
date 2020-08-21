using EBlocks.Interfaces;
using EBlocks.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EBlocks.NothWindsBlazorApp.Shared.Repos
{
    public class ProductsHttpRepository : HttpRepository<Product>, IProductsHttpRepository
    {
        public ProductsHttpRepository(HttpClient client, IConfiguration config) : base(client, config)
        { 
        
        }

    }
}
