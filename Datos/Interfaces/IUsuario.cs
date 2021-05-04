using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Entidades;

namespace Datos.Interfaces
{
    public interface IUsuario:IGenericRepository<Usuario>
    {
        bool Login(string usuario, string pass);
        string RecuperarPassword(string usuario);
        

    }
}
