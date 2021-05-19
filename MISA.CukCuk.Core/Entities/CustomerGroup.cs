using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Entities
{
    /// <summary>
    /// Thông tin của Nhóm khách hàng
    /// </summary>
    /// CreatedBy: DuongNG
    public class CustomerGroup
    {
        #region Declare

        #endregion
        /// <summary>
        /// dinh nghia ham khoi tao
        /// </summary>
        #region Constructure
        public CustomerGroup()
        {
            CustomerGroupId = Guid.NewGuid();
        }
        #endregion

        /// <summary>
        /// dinh nghia các Properties
        /// </summary>
        #region Properties
        /// <summary>
        /// Mã nhóm khách hàng
        /// </summary>
        public Guid CustomerGroupId { get; set; }
        /// <summary>
        /// Tên nhóm khách hàng
        /// </summary>
        public string CustomerGroupName { get; set; }
        /// <summary>
        /// Mô tả nếu có
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Ngày khởi tạo
        /// </summary>
        public DateTime? CreateDate { get; set; }
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
