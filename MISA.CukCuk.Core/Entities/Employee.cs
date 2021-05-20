using MISA.CukCuk.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Entities
{
    public class Employee
    {
        #region Declare
        /// <summary>
        /// Thông tin Nhân viên
        /// </summary>
        /// CreatedBy: DuongNG (20/05/2021)
        #endregion

        #region Constructure
        public Employee()
        {
            EmployeeId = Guid.NewGuid();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Mã nhân viên trong hệ thống
        /// </summary>
        public Guid EmployeeId { set; get; }
        /// <summary>
        /// Mã nhân viên 
        /// </summary>
        [Required("Mã nhân viên không được phép để trống!")]
        [MISAMaxLength(MaxLength: 20)]
        public string EmployeeCode { get; set; }
        /// <summary>
        /// Tên nhân viên
        /// </summary>
        [MISAMaxLength(MaxLength: 50)]
        public string FullName { get; set; }
        /// <summary>
        /// Ngày tháng năm sinh
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Giới tính
        /// </summary>
        public int Gender { get; set; } = 0;
        /// <summary>
        /// Mã phòng ban
        /// </summary>
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// Vị trí trong công ty
        /// </summary>
        public string PositionName { get; set; }
        /// <summary>
        /// Mã số Chứng minh thư
        /// </summary>
        [MISAMaxLength(MaxLength: 12)]
        public string IdentifyNumber { get; set; }
        /// <summary>
        /// Ngày cấp CMT
        /// </summary>
        public DateTime? IdentifyDate { get; set; }
        /// <summary>
        /// Nơi cấp CMT
        /// </summary>
        public string IdentifyRegion { get; set; }
        /// <summary>
        /// Nơi ở hiện tại
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Số điện thoại
        /// </summary>
        [MISAMaxLength(MaxLength: 20)]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Số điện thoại bàn
        /// </summary>
        [MISAMaxLength(MaxLength: 20)]
        public string HomePhone { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        [MISAMaxLength(MaxLength: 50)]
        public string Email { get; set; }
        /// <summary>
        /// Tài khoản ngân hàng
        /// </summary>
        [MISAMaxLength(MaxLength: 20)]
        public string BankAccount { get; set; }
        /// <summary>
        /// Tên ngân hàng
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// Chi nhánh ngân hànd
        /// </summary>
        public string Agency { get; set; }
        /// <summary>
        /// Ngày khởi tạo
        /// </summary>
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Người khởi tạo
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Ngày thay đổi
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// Người thay đổi
        /// </summary>
        public string ModifiedBy { get; set; }
        #endregion

        #region Method

        #endregion

    }
}
