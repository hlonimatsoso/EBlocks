using EBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Models
{
    public class OrderDetails : IOrderDetails
    {
        public int OrderDetailsID { get ; set ; }
        public int OrderID { get ; set ; }
        public int ProductID { get ; set ; }
        public double UintPrice { get ; set ; }
        public int Quantity { get ; set ; }
        public double Discount { get ; set ; }
    }
}
