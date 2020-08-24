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
    public class OrderDetailsHttpRepository : HttpRepository<OrderDetails>, IOrderDetailsHttpRepository
    {
        public OrderDetailsHttpRepository(HttpClient client, IConfiguration config, IOracle<IProduct, ICategory, IOrder, IOrderDetails, ISupplier> oracle) : base(client, config, oracle)
        { 

        
        }

        public async override Task<IEnumerable<OrderDetails>> GetAll(string path)
        {
            IEnumerable<OrderDetails> result = null;

            if (this.Oracle.OrderDetails != null && this.Oracle.OrderDetails.Count() > 0)
                result = (IEnumerable<OrderDetails>)this.Oracle.OrderDetails;
            else
            {
                result = await base.GetAll(path);
                this.Oracle.OrderDetails = result;
            }

            return result; 

        }

    }
}
