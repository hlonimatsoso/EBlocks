using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface IOrderDetails
    {
         int OrderDetailsID { get; set; }

         int OrderID { get; set; }

         int ProductID { get; set; }

         double UintPrice { get; set; }

         int Quantity { get; set; }

         double Discount { get; set; }

    }
}
