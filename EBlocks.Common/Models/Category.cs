
using EBlocks.Interfaces;
using EBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Models
{
    public class Category : ICategory //, IMongoCollection
    {
        public Guid CategoryID { get ; set ; }
        public string CategoryName { get ; set ; }
        public string Description { get ; set ; }
        public string Picture { get ; set; }
        //public Guid Id { get ; set ; }
    }
}
