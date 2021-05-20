using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Interfaces.Repository
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        int Insert(T entity);
        int Update(T entity);
        int Delete(Guid id);

    }
}
