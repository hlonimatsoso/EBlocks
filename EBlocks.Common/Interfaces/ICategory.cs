using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface ICategory//: IMongoCollection
    {
         Guid CategoryID { get; set; }

         string CategoryName { get; set; }

         string Description { get; set; }

         string Picture { get; set; }

    }
}
