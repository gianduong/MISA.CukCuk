using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Required : Attribute
    {
        public String msgError = String.Empty;
        public Required(String msg)
        {
            msgError = msg;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class MISAMaxLength : Attribute
    {
        public int MaxLength = 0;
        public String msgError = String.Empty;
        public MISAMaxLength(String msg = "", int MaxLength = 0)
        {
            this.MaxLength = MaxLength;
            msgError = msg;
        }
    }
}
