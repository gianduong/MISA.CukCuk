using Microsoft.AspNetCore.Mvc;
using MISA.Common.Entities;
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
    public class EmployeeController : BaseController<Employee>
    {
        IEmployeeService _empService;
        IEmployeeRepository _empRepository;
        public EmployeeController(IEmployeeRepository repository, IEmployeeService service):base(repository, service)
        {
            _empRepository = repository;
            _empService = service;
        }

        [HttpGet("getCode")]
        public IActionResult Get(String code)
        {
            var rs = _empService.GenNewEmployeeCode();
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

        [HttpGet("search")]
        public IActionResult Search(String name)
        {
            var rs = _empService.SearchEmployees(name);
            if (rs != null)
            {
                return Ok(rs);
            }
            else
            {
                return NoContent();
            }
        }


        [HttpGet("CheckCodeExists")]
        public IActionResult checkCode(String code)
        {
            bool rs = _empService.CheckEmployeeCodeExist(code);

            return Ok(rs);
        }

        [HttpGet("searchByDepartmentId")]
        public IActionResult SearchByDepartmentId(Guid name)
        {
            var rs = _empService.SearchByDepartmentId(name);
            if (rs != null)
            {
                return Ok(rs);
            }
            else
            {
                return NoContent();
            }
        }
    }
}
