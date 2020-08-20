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
        public OrdersHttpRepository(HttpClient client, IConfiguration config) : base(client, config)
        { 
        
        }

    }
}
