using EBlocks.Interfaces;
using EBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Models
{
    public class Order : IOrder
    {
        public Guid OrderID { get; set ; }
        public DateTime OrderDate { get ; set ; }
        public string CustomerName { get ; set ; }
        public string CustomerContactNumber { get ; set ; }

        //public Guid Id { get ; set ; }

        public Order()
        {
            this.OrderDate = DateTime.Now;
        }
    }
}
