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
    public class CustomerGroupController : BaseController<CustomerGroup>
    {
        ICustomerGroupService _groupService;
        ICustomerGroupRepository _groupRepository;
        public CustomerGroupController(ICustomerGroupService groupService, ICustomerGroupRepository groupRepository):base(groupRepository,groupService)
        {
            _groupService = groupService;
            _groupRepository = groupRepository;
        }
    }
}
