using MISA.CukCuk.Core.Attributes;
using MISA.CukCuk.Core.Exceptions;
using MISA.CukCuk.Core.Interfaces.Repository;
using MISA.CukCuk.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Services
{
    public class BaseService<T> : IBaseService<T>
    {
        IBaseRepository<T> _baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        /// <summary>
        /// hàm thêm mới một đối tương
        /// </summary>
        /// <param name="entity">đối tượng cần thêm mới</param>
        /// <returns>số cột bị thay đổi trong database</returns>
        public int Insert(T entity)
        {
            Validate(entity);
            ValidateCustom(entity);
            return _baseRepository.Insert(entity);
        }

        /// <summary>
        /// Hàm cập nhật một đối tượng trong database
        /// </summary>
        /// <param name="entity">đối tượng cần cập nhật</param>
        /// <returns>số cột bị thay đổi trong database</returns>
        public int Update(T entity)
        {
            Validate(entity);
            ValidateCustom(entity);
            return _baseRepository.Update(entity);
        }
        /// <summary>
        /// Hàm validate dữ liệu chung trước khi cập nhật hay thêm mới
        /// </summary>
        /// <param name="entity">đối tượng cần kiểm tra</param>
        void Validate(T entity)
        {
            var properties = typeof(T).GetProperties();
            foreach (var prop in properties)
            {
                var attributeRequired = prop.GetCustomAttributes(typeof(Required), true);
                var attributeMaxLength = prop.GetCustomAttributes(typeof(MISAMaxLength), true);
                if (attributeRequired.Length > 0)
                {
                    //lay gia tri cua propery
                    var propetyValue = prop.GetValue(entity);
                    var properyType = prop.PropertyType;
                    if (prop.PropertyType == typeof(String) && String.IsNullOrEmpty(propetyValue.ToString()))
                    {
                        var msgError = (attributeRequired[0] as Required).msgError;
                        throw new GuardException<T>(msgError, entity);
                    }
                }
                if (attributeMaxLength.Length > 0)
                {
                    //lay gia tri cua propery
                    var propetyValue = prop.GetValue(entity);
                    //lay ra do dai cho phep
                    var maxLength = (attributeMaxLength[0] as MISAMaxLength).MaxLength;
                    if (propetyValue.ToString().Length > maxLength)
                    {
                        throw new GuardException<T>($"Thông tin {prop.Name} không được dài quá {maxLength} ký tự!", entity);
                    }
                }
            }
        }
        /// <summary>
        /// Hàm validate cho từng đối tượng riêng biệt
        /// </summary>
        /// <param name="entity">đối tượng cần validate</param>
        protected virtual void ValidateCustom(T entity)
        {

        }
    }
}
