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
        public ProductsHttpRepository(HttpClient client, IConfiguration config, IOracle<IProduct, ICategory, IOrder, IOrderDetails, ISupplier> oracle) : base(client, config, oracle)
        { 
        
        }

        public async override Task<IEnumerable<Product>> GetAll(string path)
        {
            IEnumerable<Product> result = null;

            if (this.Oracle.Products != null && this.Oracle.Products.Count() > 0)
                result = (IEnumerable<Product>)this.Oracle.Products;
            else
            {
                result = await base.GetAll(path);
                this.Oracle.Products = result;
            }

            return result;

        }

    }
}
