using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Attributes
{
    
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class MongoCollectionAttribute : Attribute
    {
        public string CollectionName { get; }

        public MongoCollectionAttribute(string collection)
        {
            CollectionName = collection;
        }
    }
}
