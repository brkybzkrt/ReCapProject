using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entity;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new() // car,brand ve color nesnelerimiz gelebilecek 
    {

        List<T> GetAll(Expression<Func<T,bool>> filter=null);


        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
