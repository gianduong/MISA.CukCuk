using MISA.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Interfaces.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(Guid CustomerId);
        int Insert(Customer Customer);
        int Update(Customer customer);
        int Delete(Guid CustomerId);
    }
}
