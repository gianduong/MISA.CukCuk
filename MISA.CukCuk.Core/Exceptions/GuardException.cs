using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Exceptions
{
    public class GuardException<T>:Exception
    {
        /// <summary>
        /// Khởi tạo hàm ngoại lệ
        /// </summary>
        /// <param name="msg">Nội dung thông báo</param>
        /// <param name="entity">đối tượng trả về của thông báo</param>
        public GuardException(String msg, T entity):base(msg)
        {
            this.Data.Add(1, entity);
        }

    }
}
