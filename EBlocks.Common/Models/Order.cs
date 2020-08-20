using EBlocks.Interfaces;
using EBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Models
{
    public class Order : IOrder
    {
        public int OrderID { get; set ; }
        public DateTime OrderDate { get ; set ; }
        public Guid Id { get ; set ; }
    }
}
