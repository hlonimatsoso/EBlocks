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

        public Guid Id { get ; set ; }
    }
}
