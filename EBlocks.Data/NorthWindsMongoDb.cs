using EBlocks.Interfaces;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System;

namespace EBlocks.Data
{
    public class NorthWindsMongoDb : IMongoDb
    {
        public MongoClient MongoClient { get ; set ; }

        public NorthWindsMongoDb(string connetion)
        { 
        
        }
    }
}
