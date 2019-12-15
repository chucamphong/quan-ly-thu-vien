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
    }
}
