using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using ZIMO.Data;
using ZIMO.DAL.Abstractions;
using ZIMO.Entities.Abstractions;

namespace ZIMO.DAL.Concretes
{
    public class DataRepository<T> : IDataRepository<T> where T : class, IEntity
    {
        // TODO - Update DBContext after you create it
         public virtual IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            using (var context = new ZimoDbContext())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                //Apply eager loading
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                list = dbQuery
                    .AsNoTracking()
                    .ToList<T>();
            }

            return list;
        }

        public virtual IList<T> GetList(Func<T, bool> where,
            params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            using (var context = new ZimoDbContext())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                //Apply eager loading
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                list = dbQuery
                    .AsNoTracking()
                    .Where(where)
                    .ToList<T>();
            }

            return list;
        }

        public virtual T GetSingle(Func<T, bool> where,
            params Expression<Func<T, object>>[] navigationProperties)
        {
            T item = null;
            using (var context = new ZimoDbContext())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                //Apply eager loading
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                item = dbQuery
                    .AsNoTracking() //Don't track any changes for the selected item
                    .FirstOrDefault(where); //Apply where clause
            }

            return item;
        }

        public virtual void Add(params T[] items)
        {
            Update(items);
        }

        public virtual void Update(params T[] items)
        {
            using (var context = new ZimoDbContext())
            {
                DbSet<T> dbSet = context.Set<T>();
                foreach (T item in items)
                {
                    dbSet.Add(item);
                    foreach (DbEntityEntry<IEntity> entry in context.ChangeTracker.Entries<IEntity>())
                    {
                        IEntity entity = entry.Entity;
                        entry.State = GetEntityState(entity.EntityState);
                    }
                }
                context.SaveChanges();
            }
        }

        public virtual void Remove(params T[] items)
        {
            Update(items);
        }

        // Entity Stater this method switches entity states to make real methods above
        protected static System.Data.Entity.EntityState GetEntityState(ZIMO.Entities.Abstractions.EntityState entityState)
        {
            switch (entityState)
            {
                case ZIMO.Entities.Abstractions.EntityState.Unchanged:
                    return System.Data.Entity.EntityState.Unchanged;
                case ZIMO.Entities.Abstractions.EntityState.Added:
                    return System.Data.Entity.EntityState.Added;
                case ZIMO.Entities.Abstractions.EntityState.Modified:
                    return System.Data.Entity.EntityState.Modified;
                case ZIMO.Entities.Abstractions.EntityState.Deleted:
                    return System.Data.Entity.EntityState.Deleted;
                default:
                    return System.Data.Entity.EntityState.Detached;
            }
        }
    }
}
