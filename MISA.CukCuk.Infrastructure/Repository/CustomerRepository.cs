using Dapper;
using MISA.Common.Entities;
using MISA.CukCuk.Core.Interfaces.Repository;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Infrastructure.Repository
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public bool CheckCustomerCodeExist(string customerCode)
        {
            _dbConnection = new MySqlConnection(_connectionString);
            // 3. Thực thi lệnh lấy dữ liệu trong Database:
            var sqlCommand = $"Proc_CheckCustomerCodeExists";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@d_CustomerCode", customerCode);
            var res = _dbConnection.ExecuteScalar<bool>(sqlCommand, dynamicParameters, commandType: CommandType.StoredProcedure);
            return res;
        }

        public bool CheckEmailExists(string email)
        {
            _dbConnection = new MySqlConnection(_connectionString);
            // 3. Thực thi lệnh lấy dữ liệu trong Database:
            var sqlCommand = $"Proc_D_CheckCustomerEmailExists";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@d_Email", email);
            var res = _dbConnection.ExecuteScalar<bool>(sqlCommand, dynamicParameters, commandType: CommandType.StoredProcedure);
            return res;
        }

        public void InitConnection()
        {
            throw new NotImplementedException();
        }
    }
}
