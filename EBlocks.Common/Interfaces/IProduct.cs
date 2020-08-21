using EBlocks.Models;
using System;

namespace EBlocks.Interfaces
{
    public interface IProduct: IBaseCollection
    {
         int ProductID { get; set; }

         int SupplierID { get; set; }

         Supplier Supplier { get; set; }

         int CategoryID { get; set; }

         Category Category { get; set; }

         Guid Id { get; set; }

         string ProductName { get; set; }
         int QuantityPerUnit { get; set; }

         double UnitPrice { get; set; }

         int UnitsInStock { get; set; }

         int UnitsOnOrder { get; set; }

         int ReorderLevel { get; set; }

         bool Discontinued { get; set; }
    }
}
