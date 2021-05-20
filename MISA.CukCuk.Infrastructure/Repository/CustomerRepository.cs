using MISA.Common.Entities;
using MISA.CukCuk.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Infrastructure.Repository
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public bool CheckCustomerCodeExist(string customerCode)
        {
            throw new NotImplementedException();
        }

        public bool CheckEmailExists(string email)
        {
            throw new NotImplementedException();
        }

        public void InitConnection()
        {
            throw new NotImplementedException();
        }
    }
}
