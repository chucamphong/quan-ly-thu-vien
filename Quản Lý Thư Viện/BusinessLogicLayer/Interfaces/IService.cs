using System.Collections.Generic;
using System.Threading.Tasks;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public interface IService<TEntity>
        where TEntity : IEntity
    {
        /// <summary>
        /// Lấy tất cả các bản ghi có trong bảng.
        /// </summary>
        /// <returns>Tất cả các bản ghi.</returns>
        Task<IEnumerable<TEntity>> All();

        /// <summary>
        /// Tìm kiếm các bản ghi có <paramref name="id"/> phù hợp.
        /// </summary>
        /// <param name="id">ID cần tìm.</param>
        /// <returns>Bản ghi có <paramref name="id"/> phù hợp.</returns>
        TEntity Find(int id);

        /// <summary>
        /// Tìm kiếm các bản ghi có <paramref name="name"/> phù hợp.
        /// </summary>
        /// <param name="name">Tên cần tìm.</param>
        /// <returns>Các bản ghi có <paramref name="name"/> phù hợp.</returns>
        IEnumerable<TEntity> FindByName(string name);

        /// <summary>
        /// Thêm một bản ghi vào bảng.
        /// </summary>
        /// <param name="entity">Bản ghi cần thêm.</param>
        /// <returns>Bản ghi đã thêm.</returns>
        TEntity Insert(TEntity entity);

        /// <summary>
        /// Cập nhật một bản ghi có trong bảng.
        /// </summary>
        /// <param name="entity">Bản ghi cần cập nhật.</param>
        /// <returns>Bản ghi sau khi đã cập nhật.</returns>
        TEntity Update(TEntity entity);

        /// <summary>
        /// Xóa một bản ghi có trong bảng.
        /// </summary>
        /// <param name="entity">Bản ghi cần xóa.</param>
        /// <returns>Bản ghi sau khi xóa.</returns>
        TEntity Delete(TEntity entity);

        /// <summary>
        /// Đếm tất cả các bản ghi có trong bảng.
        /// </summary>
        /// <returns>Số lượng bản ghi.</returns>
        int Count();
    }
}
