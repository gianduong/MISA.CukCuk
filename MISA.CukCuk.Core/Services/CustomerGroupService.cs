using MISA.Common.Entities;
using MISA.CukCuk.Core.Interfaces.Repository;
using MISA.CukCuk.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Services
{
    public class CustomerGroupService:BaseService<CustomerGroup>, ICustomerGroupService
    {
        ICustomerGroupRepository _repository;
        public CustomerGroupService(ICustomerGroupRepository repository) : base(repository)
        {
            _repository = repository;
        }

        protected override void ValidateCustom(CustomerGroup entity)
        {
            
        }

    }
}
