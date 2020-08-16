using EBlocks.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EBlocks.Models
{
    public class MongoDbRepository<TEntity> : IRepository<TEntity> where TEntity : IBaseCollection
    {
        private MongoDatabase database;
        private MongoCollection<TEntity> collection;

        private string _databaseName;
        private string _collectionName;

        private IOptions<AppSettings> _appSettings;

        public MongoDbRepository()
        {
            this._databaseName = this._appSettings.Value.DatabaseName;
            this._collectionName = this._appSettings.Value.CollectionName;

            GetDatabase();
            GetCollection();
        }

        public bool Insert(TEntity entity)
        {
            entity.Id = Guid.NewGuid();
            collection.Insert(entity);
            return true;
        }

        public bool Update(TEntity entity)
        {
            if (entity.Id == null)
                return Insert(entity);

            return collection
            .Save(entity)
            .DocumentsAffected > 0;
        }

        public bool Delete(TEntity entity)
        {
            return collection
            .Remove(Query.EQ("_Id", entity.Id))
            .DocumentsAffected > 0;
        }

        public IList<TEntity>
        SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
            return collection
            .AsQueryable<TEntity>()
            .Where(predicate.Compile())
            .ToList();
        }

        public List<TEntity> GetAll()
        {
            return collection.FindAllAs<TEntity>().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return collection.FindOneByIdAs<TEntity>(id);
        }

        #region Private Helper Methods  
        private void GetDatabase()
        {
            var client = new MongoClient(GetConnectionString());
            var server = client.GetServer();

            database = server.GetDatabase(GetDatabaseName());
        }

        private string GetConnectionString()
        {
            return this._databaseName;
        }

        private string GetDatabaseName()
        {
            return this._collectionName;
        }

        private void GetCollection()
        {
            collection = database
            .GetCollection<TEntity>(typeof(TEntity).Name);
        }
        #endregion
    }
}
