using EBlocks.Interfaces;
using EBlocks.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBlocks.NothWindsBlazorApp.Pages.Categories
{
    public class CategoryListBase : ComponentBase
    {
        [Inject] public ICategoryHttpRepository Repo { get; set; }

        public IEnumerable<Category> CategoriesList { get; set; }

        protected async override Task OnInitializedAsync()
        {
            this.CategoriesList = await this.Repo.GetAll("categories");
        }
    }
}
