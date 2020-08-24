using EBlocks.Interfaces;
using EBlocks.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBlocks.NothWindsBlazorApp.Pages.Filters
{
    public class ProductsFilterBase : ComponentBase
    {
        public List<string> FilterColunms { get; set; }
        public List<string> FilterValues { get; set; }

        private string _selecteFilterColunm;
        public string SelecteFilterColunm
        {
            get { return _selecteFilterColunm; }
            set
            {
                if (value != null)
                {
                    this._selecteFilterColunm = value;
                    OnFilterColunmChange(value);

                }
            }
        }

        private string _selecteFilterValue;
        public string SelecteFilterValue { 
            get { return _selecteFilterValue; }
            set {
                if (value!=null)
                {
                    this._selecteFilterValue = value;
                    this.OnFilterValueChange(value);
                    //this.UpdateFilterValues(value);
                }
                
            }
        }
        public bool IsSelecteFilterValueEnabled { get { return this.SelecteFilterColunm != string.Empty; } }

        public bool IsCategorySelected { get { return this.SelecteFilterColunm == null ? false : this.SelecteFilterColunm.Equals("category", StringComparison.OrdinalIgnoreCase); } }
        public bool IsSupplySelected { get { return this.SelecteFilterColunm == null ? false : this.SelecteFilterColunm.Equals("supplier", StringComparison.OrdinalIgnoreCase); } }



        [Inject] public IOracle<IProduct, ICategory, IOrder, IOrderDetails, ISupplier> Oracle { get; set; }

        [Inject] public ICategoryHttpRepository CategoryHttpRepository { get; set; }

        [Inject] public ISupplierHttpRepository SupplierHttpRepository { get; set; }



        [Parameter] public EventCallback<List<Product>> FilteredDataChanged { get; set; }

        [Parameter] public IEnumerable<Product> SourceData { get; set; }

        [Parameter] public IEnumerable<Product> FilteredData { get; set; }

        [Parameter] public bool IsFilteringEnabled { get; set; }


        protected override void OnInitialized()
        {
            this.FilterColunms = new List<string> { "Category", "Supplier" };

            this.FilterValues = new List<string>();

            this.Oracle.OnCategoies_Updated += x =>
            {
                Console.WriteLine($"ProductsFilter.OnInitialized: Oracle.OnCategoies_Updated");
                this.FilterValues = x.Select(cat => cat.CategoryID.ToString()).ToList();
            };

            base.OnInitialized();
        }

        public async void OnFilterColunmChange(string s)
        {
            //Console.WriteLine(s);
            //this.SelecteFilterColunm = s;

            //this.UpdateSelectedFilterValues();

            if (this.IsCategorySelected)
            {
                var cats = await this.CategoryHttpRepository.GetAll("categories");

                this.FilterValues = cats.Select((Category cat, int i) => cat.CategoryID.ToString()).ToList();

                Console.WriteLine($"Filtered category ID's{JsonConvert.SerializeObject(this.FilterValues)}");

                //this.UpdateDisplayData(this.FilterCategories);
            }
            else if (this.IsSupplySelected)
            {
                var sups = await this.SupplierHttpRepository.GetAll("suppliers");

                this.FilterValues = sups.Select((Supplier sup, int i) => sup.SupplierID.ToString()).ToList();

                Console.WriteLine($"Filtered supplier ID's{JsonConvert.SerializeObject(this.FilterValues)}");

                //this.UpdateDisplayData(this.FilterSuppliers);
            }

        }


        private async void UpdateFilterValues()
        {
            if (this.SelecteFilterColunm.Equals("category", StringComparison.OrdinalIgnoreCase))
            {
                var cats = await this.CategoryHttpRepository.GetAll("categories");

                this.FilterValues = cats.Select((Category cat, int i) => cat.CategoryID.ToString()).ToList();

                Console.WriteLine($"Filtered category ID's{JsonConvert.SerializeObject(this.FilterValues)}");

                this.UpdateDisplayData(this.FilterCategories);
            }
            else if (this.SelecteFilterColunm.Equals("supplier", StringComparison.OrdinalIgnoreCase))
            {
                var sups = await this.SupplierHttpRepository.GetAll("suppliers");

                this.FilterValues = sups.Select((Supplier sup, int i) => sup.SupplierID.ToString()).ToList();

                Console.WriteLine($"Filtered supplier ID's{JsonConvert.SerializeObject(this.FilterValues)}");

                this.UpdateDisplayData(this.FilterSuppliers);
            }
        }


        private void UpdateDisplayData(Func<IEnumerable<Product>, IEnumerable<Product>> filter)
        {
            this.FilteredData = filter(this.SourceData);
            this.FilteredDataChanged.InvokeAsync(this.FilteredData.ToList());
            Console.WriteLine($"Updated Filter: {this.SelecteFilterColunm}, Current Values ({this.FilteredData.Count()}): {Newtonsoft.Json.JsonConvert.SerializeObject(this.FilteredData)}");
        }


        private IEnumerable<Product> FilterCategories(IEnumerable<Product> source)
        {
            if (this.FilterValues == null || this.FilterValues.Count == 0)
                return source;

            IEnumerable<Product> result = new List<Product> { };
            result = source.Where(product => product.CategoryID.ToString() == this.SelecteFilterValue);
            Console.WriteLine($"Filter Categories : {JsonConvert.SerializeObject(result)}");

            return result;
        }


        private IEnumerable<Product> FilterSuppliers(IEnumerable<Product> source)
        {
            Console.WriteLine($"Filter supplier : Source{JsonConvert.SerializeObject(source)}");
            Console.WriteLine($"Filter supplier : this.FilterValues: {JsonConvert.SerializeObject(this.FilterValues)}");


            if (this.FilterValues == null || this.FilterValues.Count == 0)
                return source;


            IEnumerable<Product> result = new List<Product> { };
            result = source.Where(product => this.FilterValues.Contains(product.SupplierID.ToString()));

            Console.WriteLine($"Filter supplier : Result{JsonConvert.SerializeObject(result)}");

            return result;
        }

        public void OnFilterValueChange(string @string)
        {
            if (this.IsCategorySelected)
                this.UpdateDisplayData(this.FilterCategories);
            else
                this.UpdateDisplayData(this.FilterSuppliers);

        }
    }
}
