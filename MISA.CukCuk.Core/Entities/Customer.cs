using MISA.CukCuk.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Entities
{
    /// <summary>
    /// Thông tin khách khách
    /// </summary>
    /// CreatedBy: DuongNG ()
    public class Customer
    {

        #region Declare

        #endregion
        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        #region Constructure
        public Customer()
        {
            CustomerId = Guid.NewGuid();
        }
        #endregion
        /// <summary>
        /// Thuộc tính
        /// </summary>
        #region Properties
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid CustomerId { get; set; }
        /// <summary>
        /// Mã khách hàng
        /// </summary>
        [Required("Mã khách hàng không được phép để trống!")]
        [MISAMaxLength(MaxLength: 10)]
        public string CustomerCode { get; set; }

        /// <summary>
        /// Họ và tên
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// ngày sinh
        /// </summary>
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// giới tính
        /// </summary>
        public int? Gender { get; set; } = 0;
        /// <summary>
        /// Mã thẻ của khách hàng
        /// </summary>
        public string MemberCardCode { get; set; }
        /// <summary>
        /// Mã nhóm khách hàng
        /// </summary>
        public Guid? CustomerGroupId { get; set; }
        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Tên công ty
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// Mã số thuế
        /// </summary>
        public string CompanyTaxCode { get; set; }
        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Ghi chú
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// Ngày khởi tạo
        /// </summary>
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Người khởi tạo
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Ngày sửa đổi
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// Người sửa đổi
        /// </summary>
        public string ModifiedBy { get; set; }
        #endregion

        #region Method

        #endregion


    }
}
