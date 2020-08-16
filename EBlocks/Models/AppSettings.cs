using EBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Models
{
    public class AppSettings 
    {
        public string DatabaseName { get ; set ; }
        public string CollectionName { get ; set ; }
        public string ConnectionString { get ; set ; }
    }
}
