using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface IMongoDb
    {
        MongoClient MongoClient { get; set; }

    }
}
