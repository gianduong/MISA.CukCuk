using MISA.Common.Entities;
using MISA.CukCuk.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Infrastructure.Repository
{
    public class CustomerGroupRepository : BaseRepository<Customer>, ICustomerGroupRepository
    {
        public int Insert(CustomerGroup entity)
        {
            throw new NotImplementedException();
        }

        public int Update(CustomerGroup entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<CustomerGroup> IBaseRepository<CustomerGroup>.GetAll()
        {
            throw new NotImplementedException();
        }

        CustomerGroup IBaseRepository<CustomerGroup>.GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
