using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface IOrder : IBaseCollection
    {
        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; }


    }
}
