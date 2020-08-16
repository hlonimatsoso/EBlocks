using EBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Models
{
    public class Product : IProduct
    {
        public int ProductID { get; set; }

        public int SupplierID { get; set; }

        public Supplier Supplier { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }

    }
}
