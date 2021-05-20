using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Interfaces.Repository
{
    public interface IBaseRepository<T>
    {
        /// <summary>
        /// Lấy toàn bộ dữ liệu
        /// </summary>
        /// <returns>
        /// danh sách các đối tượng lấy được
        /// </returns>
        /// CreatedBy: DuongNG (20/05/2021)
        IEnumerable<T> GetAll();
        /// <summary>
        /// Hàm lấy dữ liệu theo mã id
        /// </summary>
        /// <param name="id">Id cần lấy</param>
        /// <returns>
        /// giá trị trong hàng lấy được
        /// </returns>
        /// CreatedBy: DuongNG (20/05/2021)
        T GetById(Guid id);
        /// <summary>
        /// thêm một hàng vào trong table
        /// </summary>
        /// <param name="entity">đối tương cần thêm</param>
        /// <returns>số hàng thao tác được trên table</returns>
        /// CreatedBy: DuongNG (20/05/2021)
        int Insert(T entity);
        /// <summary>
        /// Cập nhật giá trị của đối tượng entity
        /// </summary>
        /// <param name="entity">đối tượng cần cập nhật</param>
        /// <returns>số hàng thao tác được trên bảng</returns>
        /// CreatedBy: DuongNG (20/05/2021)
        int Update(T entity);
        /// <summary>
        /// Hàm xóa dữ liệu trong table
        /// </summary>
        /// <param name="id">Id cần xóa</param>
        /// <returns>
        /// số hàng xóa được trong database
        /// </returns>
        /// CreatedBy: DuongNG (20/05/2021)
        int Delete(Guid id);

    }
}
