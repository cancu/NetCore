using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LifeIn2.Application.Interfaces
{
    public interface IRepositoryBase<T> //where T : IAggregateRoot    
    {
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Save(); //todo: unit of work e taşı
    }
}
