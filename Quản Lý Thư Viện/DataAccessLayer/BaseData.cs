using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public abstract class BaseData<TEntity> : IDisposable, IBaseData<TEntity> where TEntity : class
    {
        protected readonly LibraryManagementSystemContext Context = new LibraryManagementSystemContext();

        public int Count()
        {
            return this.Context.Set<TEntity>().AsNoTracking().Count();
        }

        public void Dispose()
        {
            if (this.Context is null)
            {
                this.Context.Dispose();
            }
        }
    }
}
