using EBlocks.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBlocks.NothWindsBlazorApp.Pages
{
    public class OrdersBase : ComponentBase
    {

        public IEnumerable<IOrder> Orders { get; set; }

        [Inject] public IOrdersHttpRepository Repo { get; set; }



        protected async override Task OnInitializedAsync()
        {
            this.Orders = await this.Repo.GetAll("orders");
        }
    }
}
