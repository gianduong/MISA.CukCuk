using MISA.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Interfaces.Repository
{
    public interface ICustomerRepository:IBaseRepository<Customer>
    {
        /// <summary>
        /// Khởi tạo kết nối tới db
        /// </summary>
        /// CreatedBy: DuongNG (20/05/2021)
        
        void InitConnection();
        /// <summary>
        /// Kiểm tra mã có tồn tại không
        /// </summary>
        /// <param name="customerCode"></param>
        /// <returns>
        /// true - có tồn tại
        /// false - không tồn tại
        /// </returns>
        bool CheckCustomerCodeExist(string customerCode);
        /// <summary>
        ///kiểm tra email có tồn tại không
        /// </summary>
        /// <param name="email">email do người dùng nhập</param>
        /// <returns>
        /// true - có tồn tại
        /// false - không tồn tại
        /// </returns>
        bool CheckEmailExists(String email);
        
    }
}
