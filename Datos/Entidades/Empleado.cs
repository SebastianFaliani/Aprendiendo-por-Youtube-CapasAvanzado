using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Empleado
    {
        public int IdPK { get; set; }
        public string IdNumero { get; set; }
        public string Nombre { get; set; }
        public string Mail { get; set; }
        public DateTime Nacimiento { get; set; }

    }
}
