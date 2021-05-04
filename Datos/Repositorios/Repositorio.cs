using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Datos.Repositorios
{
    public abstract class Repositorio
    {
        private readonly string conexion;
        public Repositorio()
        {
            conexion = ConfigurationManager.ConnectionStrings["MyConexion"].ToString();
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conexion);
        }

    }
}
