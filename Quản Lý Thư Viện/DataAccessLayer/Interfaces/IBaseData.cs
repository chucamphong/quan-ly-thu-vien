﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer
{
    public interface IBaseData<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Thêm <paramref name="entity"/> vào trong bảng.
        /// </summary>
        /// <param name="entity">Bản ghi cần thêm.</param>
        /// <returns>Bản ghi đã thêm.</returns>
        TEntity Insert(TEntity entity);

        /// <summary>
        /// Lấy tất cả các bản ghi trong bảng.
        /// </summary>
        /// <returns>Danh sách tất cả các bản ghi có trong bảng.</returns>
        IEnumerable<TEntity> GetAll();

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
        /// Cập nhật một bản ghi có trong bảng.
        /// </summary>
        /// <param name="entity">Bản ghi cập nhật.</param>
        /// <returns>Bản ghi sau khi cập nhật.</returns>
        TEntity Update(TEntity entity);

        /// <summary>
        /// Xóa bản ghi tương ứng với <paramref name="entity"/>.
        /// </summary>
        /// <param name="entity">Bản ghi cần xóa.</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Đếm số lượng bản ghi có trong bảng.
        /// </summary>
        /// <returns>Số lượng bản ghi.</returns>
        int Count();

        /// <summary>
        /// Thực hiện truy vấn lên cơ sở dữ liệu, sử dụng khi thực hiện các truy vấn Insert, Update, Delete.
        /// </summary>
        /// <returns><see langword="true"/> nếu thành công và <see langword="false"/> nếu thất bại.</returns>
        bool Save();
    }
}
