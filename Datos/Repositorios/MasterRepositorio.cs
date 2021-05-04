using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Datos.Repositorios
{
    public abstract class MasterRepositorio : Repositorio
    {
        protected List<SqlParameter> ListaParametros;

        //Este metodo se usa para ejecutar comandos de NO Consultas osea Insertar-Editar-Eliminar
        protected int EjecutarABM(string parametro)
        {
            //Al usar using Una vez que se usa la conexion se libera la memoria
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = parametro;
                    cmd.CommandType = CommandType.Text;
                    foreach (SqlParameter item in ListaParametros)
                    {
                        cmd.Parameters.Add(item);
                    }
                    //devuelve la cantidad de filas que fueron afectas con el Insertar-Editar-Eliminar
                    int result = cmd.ExecuteNonQuery();
                    ListaParametros.Clear();
                    return result;
                }
            }
        }
        
        //Este metodo se usa para ejecutar comandos de Consultas Leer filas de tablas y mostrarlas
        protected DataTable LeerTabla(string parametro) 
        {
            //Al usar using Una vez que se usa la conexion se libera la memoria
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = parametro;
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader Leer = cmd.ExecuteReader())
                    {
                        using (var tabla = new DataTable())
                        {
                            tabla.Load(Leer);
                            return tabla;
                        }
                    }
                }
            }
        }
    }
}
