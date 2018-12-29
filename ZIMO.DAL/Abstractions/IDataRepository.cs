using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ZIMO.Entities.Abstractions;

namespace ZIMO.DAL.Abstractions
{
    public interface IDataRepository<T> where T : class, IEntity 
    {
        IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        void Add(params T[] items);
        void Update(params T[] items);
        void Remove(params T[] items);
    }
}
