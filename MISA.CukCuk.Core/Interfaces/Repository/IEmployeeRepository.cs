using MISA.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Interfaces.Repository
{
    public interface IEmployeeRepository:IBaseRepository<Employee>
    {
        /// <summary>
        /// Kiểm tra mã code có tồn tại trong hệ thống hay không
        /// </summary>
        /// <param name="code">Mã EmploeeCode người dùng nhập</param>
        /// <returns>
        /// true - có tồn tại
        /// false - không tồn tại
        /// </returns>
        bool CheckEmployeeCodeExists(String code);
        /// <summary>
        /// Kiểm tra email có tồn tại trong hệ thống không
        /// </summary>
        /// <param name="email">Email do người dùng nhập</param>
        /// <returns>
        /// true - có tồn tại
        /// false - không tồn tại
        /// </returns>
        bool CheckEmailExists(String email);
        /// <summary>
        /// Kiểm tra xem số CMT có tồn tại trong hệ thống không
        /// </summary>
        /// <param name="iNumber">Mã số Chứng minh thư do người dùng nhập</param>
        /// <returns>
        /// true - có tồn tại
        /// false - không tồn tại
        /// </returns>
        bool checkIdentifyNumberExists(String iNumber);
        /// <summary>
        /// Sinh ra mã nhân viên mới
        /// </summary>
        /// <returns>
        /// Mã nhân viên mới
        /// </returns>
        public string GenEmployeeCode();
        /// <summary>
        /// tìm kiếm nhân viên theo mã nhân viên hoặc tên nhân viên
        /// </summary>
        /// <param name="name">mã nhân viên hoặc tên nhân viên cần kiểm tra</param>
        /// <returns>
        /// danh sách nhân viên có mã hoặc tên chứa "name"
        /// </returns>
        public IEnumerable<Employee> SearchEmployees(string name);
        /// <summary>
        /// Tìm kiếm nhân viên theo phòng ban
        /// </summary>
        /// <param name="department">phòng ban cần tìm kiếm</param>
        /// <returns>
        /// Danh sách nhân viên thuộc phòng ban đó
        /// </returns>
        public IEnumerable<Employee> SearchByDepartmentId(Guid department);

    }
}
