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
    public class CategoryHttpRepository : HttpRepository<Category>, ICategoryHttpRepository
    {
        public CategoryHttpRepository(HttpClient client, IConfiguration config, IOracle<IProduct, ICategory, IOrder, IOrderDetails, ISupplier> oracle) : base(client, config, oracle)
        { 

        
        }

        public async override Task<IEnumerable<Category>> GetAll(string path)
        {
            IEnumerable<Category> result = null;

            if (this.Oracle.Categories != null && this.Oracle.Categories.Count() > 0)
                result = (IEnumerable<Category>)this.Oracle.Categories;
            else
            {
                result = await base.GetAll(path);
                this.Oracle.Categories = result;
            }

            return result; 

        }

    }
}
