
using EBlocks.Attributes;
using EBlocks.Interfaces;
using EBlocks.Interfaces;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Models
{
    [MongoCollection("category")]
    public class Category : ICategory, IMongoTbale
    {
        public Guid CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public ObjectId Id { get; set; }
        public DateTime CreatedAt { get; }
    }
}
