using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataTransferObject;

namespace DataAccessLayer
{
    public abstract class BaseData<TEntity> : IBaseData<TEntity>, IDisposable
        where TEntity : class, IEntity
    {
        private readonly DbSet<TEntity> dbSet;

        public BaseData()
        {
            this.dbSet = this.Context.Set<TEntity>();
        }

        protected LibraryManagementSystemContext Context { get; } = new LibraryManagementSystemContext();

        public int Count()
        {
            return this.dbSet.Count();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            this.Context.Database.Log = Console.WriteLine;
            IQueryable<TEntity> query = this.dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (string.IsNullOrEmpty(includeProperties))
            {
                string[] splitIncludeProperties = includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string includeProperty in splitIncludeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }

            return query.ToList();
        }

        public IEnumerable<TEntity> FindByName(string name)
        {
            return this.dbSet.Where(entity => entity.Name.Contains(name));
        }

        public IEnumerable<TEntity> All()
        {
            return this.dbSet;
        }

        public void Dispose()
        {
            if (this.Context != null)
            {
                this.Context.Dispose();
            }
        }

        public TEntity Update(TEntity entity)
        {
            entity = this.dbSet.Attach(entity);

            this.Context.Entry(entity).State = EntityState.Modified;

            return entity;
        }

        public bool Save()
        {
            return this.Context.SaveChanges() > 0 ? true : false;
        }

        public TEntity Insert(TEntity entity)
        {
            return this.dbSet.Add(entity);
        }

        public TEntity Delete(TEntity entity)
        {
            if (this.Context.Entry(entity).State == EntityState.Detached)
            {
                this.dbSet.Attach(entity);
            }

            return this.dbSet.Remove(entity);
        }
    }
}
