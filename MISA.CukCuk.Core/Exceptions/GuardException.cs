using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Exceptions
{
    public class GuardException<T>:Exception
    {
        public GuardException(String msg, T entity):base(msg)
        {
            this.Data.Add(1, entity);
        }

    }
}
