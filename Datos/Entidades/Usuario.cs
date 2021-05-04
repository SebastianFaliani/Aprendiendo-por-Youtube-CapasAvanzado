using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Pass { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Permiso { get; set; }
        public string Email { get; set; }
    }
}
