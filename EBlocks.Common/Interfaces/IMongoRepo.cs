using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EBlocks.Interfaces
{
    public interface IMongoRepo<Doc> where Doc : IMongoTbale
    {

        IQueryable<Doc> AsQueryable();

        IEnumerable<Doc> FilterBy(
            Expression<Func<Doc, bool>> filterExpression);

        IEnumerable<TProjected> FilterBy<TProjected>(
            Expression<Func<Doc, bool>> filterExpression,
            Expression<Func<Doc, TProjected>> projectionExpression);

        Doc FindOne(Expression<Func<Doc, bool>> filterExpression);

        Task<Doc> FindOneAsync(Expression<Func<Doc, bool>> filterExpression);

        Doc FindById(string id);

        Task<Doc> FindByIdAsync(string id);

        void InsertOne(Doc document);

        Task InsertOneAsync(Doc document);

        void InsertMany(ICollection<Doc> documents);

        Task InsertManyAsync(ICollection<Doc> documents);

        //void ReplaceOne(Doc document);

        //Task ReplaceOneAsync(Doc document);

        //void DeleteOne(Expression<Func<Doc, bool>> filterExpression);

        //Task DeleteOneAsync(Expression<Func<Doc, bool>> filterExpression);

        //void DeleteById(string id);

        //Task DeleteByIdAsync(string id);

        //void DeleteMany(Expression<Func<Doc, bool>> filterExpression);

        //Task DeleteManyAsync(Expression<Func<Doc, bool>> filterExpression);
    }
}
