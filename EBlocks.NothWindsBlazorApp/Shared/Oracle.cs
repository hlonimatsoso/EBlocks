using EBlocks.Interfaces;
using EBlocks.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBlocks.NothWindsBlazorApp.Shared
{
    public class Oracle : IOracle<IProduct, ICategory, IOrder, IOrderDetails, ISupplier>
    {
        // Live manual cache
        public IEnumerable<IProduct> Products { get; set; }
        public IEnumerable<IOrder> Orders
        {
            get
            {
                return this._orders;
            }
            set
            {
                if (value != null)
                {
                    this._orders = value;
                    if (this.Orders.Count() > 0)
                        this.OnOrders_Updated?.Invoke(value);
                }
                else
                    Console.WriteLine("IOrder collection is empty");
            }
        }
        public IEnumerable<IOrderDetails> OrderDetails { get; set; }
        public IEnumerable<ISupplier> Supplier { get; set; }
        public IEnumerable<ICategory> Categories { get; set; }

        //Events
        public event Action<IEnumerable<IProduct>> OnProducts_Updated;
        public event Action<IEnumerable<ICategory>> OnCategoies_Updated;
        public event Action<IEnumerable<IOrder>> OnOrders_Updated;



        // Private variables
        IEnumerable<IProduct> _products;
        IEnumerable<IOrder> _orders;
        IEnumerable<IOrderDetails> _orderDetails;
        IEnumerable<ISupplier> _supplier;
        IEnumerable<ICategory> _categories;

        public Oracle()
        {
            this.Products = new List<Product>();
            this._products = new List<Product>();
            this.Categories = new List<Category>();
            this._categories = new List<Category>();
            this.OrderDetails = new List<OrderDetails>();
            this._orderDetails = new List<OrderDetails>();
            this.Supplier = new List<Supplier>();
            this._supplier = new List<Supplier>();
            this.Orders = new List<Order>();
            this._orders = new List<Order>();


        }

        public void AddProduct(IProduct product)
        {
            ((List<IProduct>)this.Products).Add(product);
            this.OnProducts_Updated?.Invoke(this.Products);

        }

        public void UpdateProduct(IProduct product)
        {
            throw new NotImplementedException();
        }

        public void DeleProduct(IProduct product)
        {
            throw new NotImplementedException();
        }

        public void AddOrder(IOrder order)
        {
            ((List<IOrder>)this.Orders).Add(order);
            this.OnOrders_Updated?.Invoke(this.Orders);
        }

        public void UpdateOrder(IOrder order)
        {
            throw new NotImplementedException();
        }

        public void DeleOrder(IOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
