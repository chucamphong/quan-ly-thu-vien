using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public abstract class Service<TEntity> : IService<TEntity>
        where TEntity : class, IEntity
    {
        public virtual List<TEntity> All()
        {
            using (var entityData = this.CreateInstance())
            {
                return entityData.All().ToList();
            }
        }

        public int Count()
        {
            using (var entityData = this.CreateInstance())
            {
                return entityData.Count();
            }
        }

        public TEntity Delete(TEntity entity)
        {
            using (var entityData = this.CreateInstance())
            {
                entity = entityData.Delete(entity);
                entityData.Save();
                return entity;
            }
        }

        public List<TEntity> FindByName(string name)
        {
            using (var entityData = this.CreateInstance())
            {
                return entityData.FindByName(name).ToList();
            }
        }

        public TEntity Insert(TEntity entity)
        {
            using (var entityData = this.CreateInstance())
            {
                entity = entityData.Insert(entity);
                entityData.Save();
                return entity;
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var entityData = this.CreateInstance())
            {
                entity = entityData.Update(entity);
                entityData.Save();
                return entity;
            }
        }

        /// <summary>
        /// Tạo ra một thực thể của tầng Data Access Layer để phục vụ cho việc lấy dữ liệu tương ứng.
        /// </summary>
        /// <returns>Thực thể của bảng.</returns>
        protected abstract BaseData<TEntity> CreateInstance();
    }
}
