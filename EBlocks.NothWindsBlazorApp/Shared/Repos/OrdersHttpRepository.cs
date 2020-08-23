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
    public class OrdersHttpRepository : HttpRepository<Order>, IOrdersHttpRepository
    {
        public OrdersHttpRepository(HttpClient client, IConfiguration config, IOracle<IProduct, ICategory, IOrder, IOrderDetails, ISupplier> oracle) : base(client, config, oracle)
        { 

        
        }

        public async override Task<IEnumerable<Order>> GetAll(string path)
        {
            IEnumerable<Order> result = null;

            if (this.Oracle.Orders != null && this.Oracle.Orders.Count() > 0)
                result = (IEnumerable<Order>)this.Oracle.Orders;
            else
            {
                result = await base.GetAll(path);
                this.Oracle.Orders = result;
            }

            return result; 

        }

    }
}
