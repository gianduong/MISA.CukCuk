using MISA.Common.Entities;
using MISA.CukCuk.Core.Exceptions;
using MISA.CukCuk.Core.Interfaces.Repository;
using MISA.CukCuk.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Services
{
    public class CustomerService : BaseService<Customer>, ICustomerService
    {
        ICustomerRepository _service;
        public CustomerService(ICustomerRepository service):base(service)
        {
            _service = service;
        }

        protected override void ValidateCustom(Customer entity)
        {
            if (entity is Customer)
            {
                var customer = entity as Customer;

                // 2. Check mã khách hàng đã tồn tại hay chưa?
                var isExists = _service.CheckCustomerCodeExist(customer.CustomerCode);
                if (isExists == true)
                {
                    throw new GuardException<Customer>("Mã khách hàng đã tồn tại trong hệ thống, vui lòng kiểm tra lại", null);
                }

                // 3. Kiểm tra Email có đúng định dạng hay không?
                var emailTemplate = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
                if (!Regex.IsMatch(customer.Email, emailTemplate))
                {
                    throw new GuardException<Customer>("Email không đúng định dạng, vui lòng kiểm tra lại", null);
                }

                if (_service.CheckEmailExists(customer.Email))
                {
                    throw new GuardException<Customer>("Email đã tồn tại trong hệ thống, vui lòng kiểm tra lại", null);
                }
            }
        }
    }
}
