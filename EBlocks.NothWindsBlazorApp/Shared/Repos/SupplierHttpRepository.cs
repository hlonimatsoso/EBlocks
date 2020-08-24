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
    public class SuppliersHttpRepository : HttpRepository<Supplier>, ISupplierHttpRepository
    {
        public SuppliersHttpRepository(HttpClient client, IConfiguration config, IOracle<IProduct, ICategory, IOrder, IOrderDetails, ISupplier> oracle) : base(client, config, oracle)
        { 
                    
        }

        public async override Task<IEnumerable<Supplier>> GetAll(string path)
        {
            IEnumerable<Supplier> result = null;

            if (this.Oracle.Supplier != null && this.Oracle.Supplier.Count() > 0)
                result = (IEnumerable<Supplier>)this.Oracle.Supplier;
            else
            {
                result = await base.GetAll(path);
                this.Oracle.Supplier = result;
            }

            return result; 

        }

    }
}
