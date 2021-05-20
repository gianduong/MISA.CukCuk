using MISA.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Interfaces.Services
{
    public interface IEmployeeService:IBaseService<Employee>
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public IEnumerable<Employee> SearchEmployees(string name);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public String GenNewEmployeeCode();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        public bool CheckEmployeeCodeExist(string Code);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public IEnumerable<Employee> SearchByDepartmentId(Guid department);
    }
}
