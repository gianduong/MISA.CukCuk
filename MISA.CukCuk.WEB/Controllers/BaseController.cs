using Microsoft.AspNetCore.Mvc;
using MISA.CukCuk.Core.Exceptions;
using MISA.CukCuk.Core.Interfaces.Repository;
using MISA.CukCuk.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.WEB.Controllers
{
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class BaseController<T> : Controller
    {     
        IBaseRepository<T> _baseBL;
        public BaseController(IBaseRepository<T> baseBL)
        {
            _baseBL = baseBL;
        }
        /// <summary>
        /// Lấy toàn bộ dữ liệu
        /// </summary>
        /// <return>
        /// 200 - Có dữ liệu
        /// 204 - Không có dữ liệu
        /// 500 - Lỗi ngoại lệ trên server
        /// </return>
        /// CreatedBy: DuongNG (20/05/2021)
        [HttpGet]
        public IActionResult Get()
        {
            try 
            { 
                var rs = _baseBL.GetAll();
                if (rs != null)
                {
                    return Ok(rs);
                }
                else
                    return NoContent();
            }
            catch (Exception ex)
            {

                var mes = new
                {
                    devMsg = ex.Message,
                    userMsg = "Có lỗi xảy ra, vui lòng liên hệ MISA để được trợ giúp",
                };
                return StatusCode(500, mes);
            }
        }

        /// <summary>
        /// Lấy dữ liệu theo Id
        /// </summary>
        /// <return>
        /// 200 - Có dữ liệu
        /// 204 - Không có dữ liệu
        /// 500 - Lỗi ngoại lệ trên server
        /// </return>
        /// CreatedBy: DuongNG (20/05/2021)
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var rs = _baseBL.GetById(id);
                // 4. Trả về cho Client:
                if (rs != null)
                {
                    return Ok(rs);
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception ex)
            {

                var mes = new
                {
                    devMsg = ex.Message,
                    userMsg = "Có lỗi xảy ra, vui lòng liên hệ MISA để được trợ giúp",
                };
                return StatusCode(500, mes);
            }
        }

        /// <summary>
        /// Thêm dữ liệu vào database
        /// </summary>
        /// <return>
        /// 200 - Thêm thành công
        /// 400 - Lỗi do người dùng nhập
        /// 500 - Lỗi ngoại lệ trên server
        /// </return>
        /// CreatedBy: DuongNG (20/05/2021)
        [HttpPost]
        public IActionResult Post([FromBody] T entity)
        {
            try
            {
                var rowAffects = _baseBL.Insert(entity);
                if (rowAffects > 0)
                {
                    return Ok();
                }
                else
                {
                    return NoContent();
                }
            }
            catch (GuardException<T> ex)
            {
                var mes = new
                {
                    devMsg = ex.Message,
                    userMsg = "Dữ liệu không hợp lệ, vui lòng kiểm tra lại!",
                    data = ex.Data
                };
                return StatusCode(400, mes);
            }
            catch (Exception ex)
            {

                var mes = new
                {
                    devMsg = ex.Message,
                    userMsg = "Có lỗi xảy ra, vui lòng liên hệ MISA để được trợ giúp",
                };
                return StatusCode(500, mes);
            }

        }

        /// <summary>
        /// Cập nhật dữ liệu
        /// </summary>
        /// <return>
        /// 200 - Cập nhật thành công
        /// 400 - Lỗi do người dùng nhập
        /// 500 - Lỗi ngoại lệ trên server
        /// </return>
        /// CreatedBy: DuongNG (20/05/2021)
        [HttpPut("{id}")]
        public IActionResult Update([FromBody] T entity)
        {
            try
            {
                var rowAffects = _baseBL.Update(entity);
                if (rowAffects > 0)
                {
                    return Ok();
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception ex)
            {
                var mes = new
                {
                    devMsg = ex.Message,
                    userMsg = "Có lỗi xảy ra, vui lòng liên hệ MISA để được trợ giúp",
                };
                return StatusCode(500, mes);
            }
        }


        /// <summary>
        /// Xóa dữ liệu theo id
        /// </summary>
        /// <return>
        /// 200 - Xóa thành công
        /// 204 - không xóa được do không tìm thấy id
        /// 500 - Lỗi ngoại lệ trên server
        /// </return>
        /// CreatedBy: DuongNG (20/05/2021)
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var rowAffects = _baseBL.Delete(id);
                if (rowAffects > 0)
                {
                    return StatusCode(200, "Xóa thành công!");
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception ex)
            {
                var mes = new
                {
                    devMsg = ex.Message,
                    userMsg = "Có lỗi xảy ra, vui lòng liên hệ MISA để được trợ giúp",
                };
                return StatusCode(500, mes);
            }
        }
    }
}
