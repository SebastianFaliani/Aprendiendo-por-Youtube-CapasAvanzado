using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Entidades;
using Datos.Interfaces;
using Datos.Repositorios;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositorios
{
    public class EmpleadoRepositorio : MasterRepositorio,IEmpleado
    {
        private string LeerTodo;
        private string Agregar;
        private string Editar;
        private string Eliminar;

        public EmpleadoRepositorio()
        {
            LeerTodo = "SELECT * FROM Employee";
            Agregar = "INSERT INTO Employee VALUES(@idNumero,@nombre,@mail,@nacimiento)";
            Editar = "UPDATE Employee SET IdNumber=@idNumero,Name=@nombre,Mail=@mail,Birthday=@nacimiento WHERE IdPK=@idPK";
            Eliminar = "DELETE FROM Employee WHERE IdPK=@idPK";
        }

        #region CRUD Empleados
        
        public int Create(Empleado entidad)
        {
            ListaParametros = new List<System.Data.SqlClient.SqlParameter>();
            ListaParametros.Add(new SqlParameter("@idNumero", entidad.IdNumero));
            ListaParametros.Add(new SqlParameter("@nombre", entidad.Nombre));
            ListaParametros.Add(new SqlParameter("@mail", entidad.Mail));
            ListaParametros.Add(new SqlParameter("@nacimiento", entidad.Nacimiento));
            return EjecutarABM(Agregar);
        }
        public IEnumerable<Empleado> ReadAll()
        {
            var tablaResul = LeerTabla(LeerTodo);
            var listaEmpleado = new List<Empleado>();

            foreach (DataRow item in tablaResul.Rows)
            {
                listaEmpleado.Add(new Empleado
                {
                    IdPK = Convert.ToInt32(item[0]),
                    IdNumero = Convert.ToString(item[1]),
                    Nombre = Convert.ToString(item[2]),
                    Mail = Convert.ToString(item[3]),
                    Nacimiento = Convert.ToDateTime(item[4]),
                });
            }
            return listaEmpleado;
        }
        public int Update(Empleado entidad)
        {
            ListaParametros = new List<System.Data.SqlClient.SqlParameter>();
            ListaParametros.Add(new SqlParameter("@idPK", entidad.IdPK));
            ListaParametros.Add(new SqlParameter("@idNumero", entidad.IdNumero));
            ListaParametros.Add(new SqlParameter("@nombre", entidad.Nombre));
            ListaParametros.Add(new SqlParameter("@mail", entidad.Mail));
            ListaParametros.Add(new SqlParameter("@nacimiento", entidad.Nacimiento));
            return EjecutarABM(Editar);

        }
        public int Delete(int idpk)
        {
            ListaParametros = new List<System.Data.SqlClient.SqlParameter>();
            ListaParametros.Add(new SqlParameter("@idPK", idpk));
            return EjecutarABM(Eliminar);
        }
        
        #endregion

    }
}
