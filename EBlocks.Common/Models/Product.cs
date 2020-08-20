using EBlocks.Interfaces;
using System;

namespace EBlocks.Models
{
    public class Product : IProduct
    {
        public int ProductID { get; set; }

        public int SupplierID { get; set; }

        public Supplier Supplier { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }

        public Guid Id { get; set; }

        public string ProductName { get; set; }
        public int QuantityPerUnit { get; set; }

        public double UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public int UnitsOnOrder { get; set; }

        public int ReorderLevel { get; set; }

        public bool Discontinued { get; set; }


    }
}
