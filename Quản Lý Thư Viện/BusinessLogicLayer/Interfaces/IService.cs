using System.Collections.Generic;

namespace BusinessLogicLayer
{
    internal interface IService<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Lấy tất cả các bản ghi có trong bảng.
        /// </summary>
        /// <returns>Tất cả các bản ghi.</returns>
        List<TEntity> All();

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
