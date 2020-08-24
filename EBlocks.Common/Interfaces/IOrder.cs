using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface IOrder //: IMongoCollection
    {
        Guid OrderID { get; set; }

        DateTime OrderDate { get; set; }

        string CustomerName { get; set; }

        string CustomerContactNumber { get; set; }

    }
}
