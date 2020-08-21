using EBlocks.Interfaces;
using EBlocks.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBlocks.NothWindsBlazorApp.Pages.Products
{
    public class ListProductsBase : ComponentBase
    {
        public IEnumerable<Product> Products { get; set; }

        [Inject] public IProductsHttpRepository Repo { get; set; }



        protected async override Task OnInitializedAsync()
        {
            this.Products = await this.Repo.GetAll("products");
        }

    }
}
