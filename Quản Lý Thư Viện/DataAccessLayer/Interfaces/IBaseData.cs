using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataTransferObject;

namespace DataAccessLayer
{
    public interface IBaseData<TEntity>
        where TEntity : class, IEntity
    {
        /// <summary>
        /// Lấy tất cả các bản ghi trong bảng.
        /// </summary>
        /// <returns>Danh sách tất cả các bản ghi có trong bảng.</returns>
        IEnumerable<TEntity> All();

        /// <summary>
        /// Thực hiện lấy các bản ghi trong bảng theo <paramref name="filter"/>, <paramref name="orderBy"/> và <paramref name="includeProperties"/>.
        /// </summary>
        /// <param name="filter">Lọc bản ghi.</param>
        /// <param name="orderBy">Sắp xếp bản ghi.</param>
        /// <param name="includeProperties">Các bảng cần nối với nhau.</param>
        /// <returns>Các bản ghi phù hợp.</returns>
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

        /// <summary>
        /// Tìm kiếm theo <paramref name="id"/>.
        /// </summary>
        /// <param name="id">ID cần tìm.</param>
        /// <returns>Bản ghi có <paramref name="id"/> phù hợp.</returns>
        TEntity Find(int id);

        /// <summary>
        /// Tìm kiếm theo <paramref name="name"/>.
        /// </summary>
        /// <param name="name">Tên cần tìm</param>
        /// <returns>Các bản ghi có <paramref name="name"/> phù hợp.</returns>
        IEnumerable<TEntity> FindByName(string name);

        /// <summary>
        /// Thêm <paramref name="entity"/> vào trong bảng.
        /// </summary>
        /// <param name="entity">Bản ghi cần thêm.</param>
        /// <returns>Bản ghi đã thêm.</returns>
        TEntity Insert(TEntity entity);

        /// <summary>
        /// Cập nhật một bản ghi có trong bảng.
        /// </summary>
        /// <param name="entity">Bản ghi cập nhật.</param>
        /// <returns>Bản ghi sau khi cập nhật.</returns>
        TEntity Update(TEntity entity);

        /// <summary>
        /// Xóa bản ghi tương ứng với <paramref name="entity"/>.
        /// </summary>
        /// <param name="entity">Bản ghi cần xóa.</param>
        /// <returns>Bản ghi sau khi xóa.</returns>
        TEntity Delete(TEntity entity);

        /// <summary>
        /// Đếm số lượng bản ghi có trong bảng.
        /// </summary>
        /// <returns>Số lượng bản ghi.</returns>
        int Count();

        /// <summary>
        /// Thực hiện truy vấn lên cơ sở dữ liệu, sử dụng khi thực hiện các truy vấn Insert, Update, Delete.
        /// </summary>
        /// <exception cref="System.Data.Entity.Infrastructure.DbUpdateException">Đã xảy ra lỗi khi gửi truy vấn đến cơ sở dữ liệu.</exception>
        /// <exception cref="System.Data.Entity.Infrastructure.DbUpdateConcurrencyException">Bản ghi đã bị thay đổi trước khi truy vấn.</exception>
        /// /// <exception cref="System.Data.Entity.Validation.DbEntityValidationException">Câu truy vấn đã bị hủy bỏ vì không hợp lệ.</exception>
        /// <returns><see langword="true"/> nếu thành công và <see langword="false"/> nếu thất bại.</returns>
        bool Save();
    }
}
