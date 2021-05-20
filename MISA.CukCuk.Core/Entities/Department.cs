using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Entities
{
    public class Department
    {
        /// <summary>
        /// thông tin của Bảng Phòng ban
        /// </summary>
        /// CreatedBy: DuongNG (20/05/2021)
        #region Declare

        #endregion

        #region Constructure

        #endregion
        #region Properties
        /// <summary>
        /// Mã của phòng ban
        /// </summary>
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// Tên phòng ban
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// Mô tả của phòng ban
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// ngày khởi tạo
        /// </summary>
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// người khởi tạo
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
