﻿using MISA.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Interfaces.Repository
{
    public interface ICustomerRepository:IBaseRepository<Customer>
    {
        /// <summary>
        /// Khởi tạo kết nối tới db
        /// </summary>
        /// CreatedBy: DuongNG (20/05/2021)
        
        /*void InitConnection();

        bool CheckCustomerCodeExist(string customerCode);
        bool CheckEmailExists(String email);
        */
    }
}
