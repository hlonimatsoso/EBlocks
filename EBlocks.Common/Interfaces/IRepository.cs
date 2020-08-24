using EBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface IRepository<T> //where T: IMongoCollection
    {

        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        //IList<T> SearchFor(Expression<Func<T, bool>> predicate);
        List<T> GetAll();
        T GetById(Guid id);


    }
}
