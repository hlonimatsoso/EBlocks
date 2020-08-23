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

        [Inject] public IOracle<IProduct, ICategory, IOrder, IOrderDetails, ISupplier> Oracle { get; set; }

        protected async override Task OnInitializedAsync()
        {
            this.Products = await this.Repo.GetAll("products");
            this.Oracle.OnProducts_Updated += Oracle_OnProducts_Updated;
        }

        private void Oracle_OnProducts_Updated(IEnumerable<IProduct> products)
        {
            this.Products = products as IEnumerable<Product>;
        }
    }
}
