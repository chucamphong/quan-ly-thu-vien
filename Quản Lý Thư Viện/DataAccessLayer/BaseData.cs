using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public abstract class BaseData<TEntity> : IDisposable, IBaseData<TEntity> where TEntity : class
    {
        protected readonly LibraryManagementSystemContext Context = new LibraryManagementSystemContext();
        private readonly DbSet<TEntity> DbSet;

        public BaseData()
        {
            this.Context = new LibraryManagementSystemContext();
            this.DbSet = this.Context.Set<TEntity>();
        }

        public int Count()
        {
            return this.DbSet.Count();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            this.Context.Database.Log = Console.WriteLine;
            IQueryable<TEntity> query = this.DbSet;

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

        public IEnumerable<TEntity> GetAll()
        {
            return this.DbSet;
        }

        public void Dispose()
        {
            if (this.Context != null)
            {
                this.Context.Dispose();
            }
        }

        public void Update(TEntity entity)
        {
            this.DbSet.Attach(entity);
            this.Context.Entry(entity).State = EntityState.Modified;
        }

        public bool Save()
        {
            return this.Context.SaveChanges() > 0 ? true : false;
        }

        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            if (this.Context.Entry(entity).State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            this.DbSet.Remove(entity);
        }
    }
}
