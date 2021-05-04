using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IEmpleado:IGenericRepository<Empleado>
    {
       // IEnumerable<Empleado> GetSueldo();
    }
}
