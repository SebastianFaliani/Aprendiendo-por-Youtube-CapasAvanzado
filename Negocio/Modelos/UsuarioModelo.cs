using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Entidades;
using Datos.Interfaces;
using Datos.Repositorios;
using Negocio.Validaciones;
using Soporte.Cache;

namespace Negocio.Modelos
{
    public class UsuarioModelo
    {
        private IUsuario usuarioRepositorio;

        private int idUsuario;
        private string nombreUsuario;
        private string pass;
        private string nombre;
        private string apellido;
        private string permiso;
        private string email;

        public EstadoEntidad Estado { private get; set; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Permiso { get => permiso; set => permiso = value; }
        public string Email { get => email; set => email = value; }

        public UsuarioModelo()
        {
            usuarioRepositorio = new UsuarioRepositorio();
        }

        public string GuardarCambios()
        {
            string msg = null;
            try
            {
                Usuario usuarioModelo = new Usuario();
                usuarioModelo.IdUsuario = IdUsuario;
                usuarioModelo.NombreUsuario = NombreUsuario;
                usuarioModelo.Pass = Pass;
                usuarioModelo.Nombre = Nombre;
                usuarioModelo.Apellido = Apellido;
                usuarioModelo.Permiso = Permiso;
                usuarioModelo.Email = Email;

                switch (Estado)
                {
                    //****                  IMPORTANTE                  ****//
                    //Si tuvieramos reglas comerciales o calculos se haria acá 

                    case EstadoEntidad.Agregado:
                        usuarioRepositorio.Create(usuarioModelo);
                        msg = "Ha sido Registrado correctamente";
                        break;
                    case EstadoEntidad.Modificado:
                        usuarioRepositorio.Update(usuarioModelo);
                        msg = "Ha sido Modificado correctamente";
                        LoginUsuario(NombreUsuario, Pass);
                        break;
                    case EstadoEntidad.Eliminado:
                        usuarioRepositorio.Delete(usuarioModelo.IdUsuario);
                        msg = "Ha sido Eliminado correctamente";
                        break;
                }
            }
            catch (Exception ex)
            {
                //Guardo en una variable el numero de la exepcion
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                //Verificamos la excepcion dato duplicado
                if (sqlEx != null && sqlEx.Number == 2627)
                {
                    msg = "El Registro esta duplicado";
                }
                else
                {
                    msg = ex.Message;
                }
            }
            return msg;
        }

        public bool LoginUsuario(string usuario, string pass)
        {
            return usuarioRepositorio.Login(usuario,pass);
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

        public string RecuperarPass(string usuario)
        {
            return usuarioRepositorio.RecuperarPassword(usuario);
        }
    }
}
