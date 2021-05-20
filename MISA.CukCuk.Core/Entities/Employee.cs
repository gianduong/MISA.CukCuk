using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Entities
{
    public class Employee
    {
        public Guid EmployeeId { set; get; }
        public string EmployeeCode { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? Gender { get; set; }
        public Guid DepartmentId { get; set; }
        public string PositionName { get; set; }
        public string IdentifyNumber { get; set; }   
        public DateTime? IdentifyDate { get; set; }
        public string IdentifyRegion { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }
        public string BankAccount { get; set; }   
        public string BankName { get; set; }
        public string Agency { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }


    }
}
