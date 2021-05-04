using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IGenericRepository<T> where T:class
    {
        //CRUD
        int Create(T entidad);
        IEnumerable<T> ReadAll();
        int Update(T entidad);
        int Delete(int idpk);
    }
}
