using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Cache
{
    public static class UsuarioSesionCache
    {
        public static int IdUsuario { get; set; }
        public static string Usuario { get; set; }
        public static string Password { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Permiso { get; set; }
        public static string Email { get; set; }
    }
}
