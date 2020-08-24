using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface IOrder : IMongoCollection
    {
         int OrderID { get; set; }

          DateTime OrderDate { get; set; }


    }
}
