using EBlocks.Interfaces;
using EBlocks.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBlocks.NothWindsBlazorApp.Pages.Suppliers
{
    public class SuppliersBase : ComponentBase
    {
        [Inject] public ISupplierHttpRepository Repo { get; set; }

        public IEnumerable<Supplier> SuppliersList { get; set; }

        protected async override Task OnInitializedAsync()
        {
            this.SuppliersList = await this.Repo.GetAll("suppliers");
        }
    }
}
