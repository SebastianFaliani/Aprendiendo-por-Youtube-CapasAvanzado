using Datos.Entidades;
using Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soporte.Cache;

namespace Datos.Repositorios
{
    public class UsuarioRepositorio : MasterRepositorio, IUsuario
    {
        private string LeerTodo;
        private string Agregar;
        private string Editar;
        private string Eliminar;

        public UsuarioRepositorio()
        {
            LeerTodo = "SELECT * FROM Users";
            Agregar = "INSERT INTO Users VALUES(@nombreUsuario, @pass, @nombre, @apellido, @permiso, @mail)";
            Editar = "UPDATE Users SET LoginName=@nombreUsuario, Password=@pass, FirstName=@nombre, LastName=@apellido, Email=@mail " +
                "WHERE UserID=@idUsuario";
            Eliminar = "DELETE FROM Users WHERE UserID=@idUsuario";
        }

        #region CRUD Usuarios

        public int Create(Usuario entidad)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Usuario> ReadAll()
        {
            throw new NotImplementedException();
        }
        public int Update(Usuario entidad)
        {
            ListaParametros = new List<System.Data.SqlClient.SqlParameter>();
            ListaParametros.Add(new SqlParameter("@idUsuario", entidad.IdUsuario));
            ListaParametros.Add(new SqlParameter("@nombreUsuario", entidad.NombreUsuario));
            ListaParametros.Add(new SqlParameter("@pass", entidad.Pass));
            ListaParametros.Add(new SqlParameter("@nombre", entidad.Nombre));
            ListaParametros.Add(new SqlParameter("@apellido", entidad.Apellido));
            ListaParametros.Add(new SqlParameter("@mail", entidad.Email));
            return EjecutarABM(Editar);
        }
        public int Delete(int idpk)
        {
            throw new NotImplementedException();
        }
        
        #endregion


        public string RecuperarPassword(string usuario)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM Users WHERE LoginName=@nombreUsuario or Email=@mail";
                    cmd.Parameters.AddWithValue("@nombreUsuario", usuario);
                    cmd.Parameters.AddWithValue("@mail", usuario);
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader Leer = cmd.ExecuteReader())
                    {
                        if (Leer.Read() == true)
                        {
                            string nombreUsuario = Leer.GetString(3) + ", " + Leer.GetString(4);
                            string userMail = Leer.GetString(6);
                            string pass = Leer.GetString(2);
                            var mailService = new MailServicios.MailSoporte();
                            mailService.enviaMail(
                                asunto: "NedaOver Sístemas: Recuperación de contraseña",
                                cuerpo: "Hola, " + nombreUsuario + "\nEsta es su contraseña:" + pass + " \nPor seguridad te recomendamos que la cambies imediatamente al entrar al Sistema",
                                destinatarios: new List<string> { userMail }
                                );
                            return "Tu contraseña fue enviada con exito, por favor revisa tu correo. " + userMail + 
                                "\nPor seguridad te recomendamos que la cambies imediatamente al entrar al Sistema";
                        }
                        return "Lo sentimos, no exite una cuenta de usuario con ese nombre o correo electronico";
                    }
                }
            }
        }

        public bool Login(string usuario, string pass)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM Users WHERE LoginName=@nombreUsuario and Password=@pass";
                    cmd.Parameters.AddWithValue("@nombreUsuario", usuario);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader Leer = cmd.ExecuteReader())
                    {
                        // Si Leer tiene filas quiere decir que encontro al usuario
                        if (Leer.HasRows)
                        {
                            // Agrego los valores a la Clase UsuarioSecionCache que es accesible desde todas las Capas
                            while (Leer.Read())
                            {
                                UsuarioSesionCache.IdUsuario = Leer.GetInt32(0);
                                UsuarioSesionCache.Usuario = Leer.GetString(1);
                                UsuarioSesionCache.Password = Leer.GetString(2);
                                UsuarioSesionCache.Nombre = Leer.GetString(3);
                                UsuarioSesionCache.Apellido = Leer.GetString(4);
                                UsuarioSesionCache.Permiso = Leer.GetString(5);
                                UsuarioSesionCache.Email = Leer.GetString(6);
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        public void VerPermisos()
        {
            if (UsuarioSesionCache.Permiso == Permisos.Administrador)
            {

            }
            else if (UsuarioSesionCache.Permiso == Permisos.Recepcionista)
            {

            }
            else if (UsuarioSesionCache.Permiso == Permisos.Contador)
            {

            }
        }


    }
}
