using Microsoft.AspNetCore.Http;
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
    public class CustomerController : BaseController<Customer>
    {
        public CustomerController(ICustomerRepository baseBL, ICustomerService customerService):base(baseBL, customerService)
        {
        }
    }
}
