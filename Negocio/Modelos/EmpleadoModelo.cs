using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interfaces;
using Datos.Entidades;
using Datos.Repositorios;
using Negocio.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace Negocio.Modelos
{
    public class EmpleadoModelo :IDisposable
    {
        private int idPK;
        private string idNumero;
        private string nombre;
        private string mail;
        private DateTime nacimiento;
        private int edad;

        private IEmpleado empleadoRepositorio;
        public EstadoEntidad Estado { private get; set; }

        private List<EmpleadoModelo> listaEmpleado;
        // ESTO SE USARA EN
        //PROPIEDADES /MODELO DE VISTA/ VALIDACIONES DE DATOS
        public int IdPK { get => idPK; set => idPK = value; }
        [Required(ErrorMessage ="El campo Numero de Identificacion es requerido")]
        [RegularExpression("([0-9]+)",ErrorMessage = "El campo Numero de Identificacion Solo deben ser numero")]
        [StringLength(maximumLength:10,MinimumLength=10,ErrorMessage = "El campo Numero de Identificacion Debe ser de 10 digitos")]
        public string IdNumero { get => idNumero; set => idNumero = value; }
        [Required]
        [RegularExpression("^[a-zA-Z ]+$",ErrorMessage ="El campo nombre deben ser solo numeros")]
        [StringLength(maximumLength:100,MinimumLength =3)]
        public string Nombre { get => nombre; set => nombre = value; }
        [Required]
        [EmailAddress]
        public string Mail { get => mail; set => mail = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
        public int Edad { get => edad; private set => edad = value; }

        public EmpleadoModelo()
        {
            empleadoRepositorio = new EmpleadoRepositorio();
        }

        public string GuardarCambios()
        {
            string msg=null;
            try
            {
                Empleado empleadoModelo = new Empleado();
                empleadoModelo.IdPK = idPK;
                empleadoModelo.IdNumero = idNumero;
                empleadoModelo.Nombre = nombre;
                empleadoModelo.Mail = mail;
                empleadoModelo.Nacimiento = nacimiento;

                switch (Estado)
                {
                    //****                  IMPORTANTE                  ****//
                    //Si tuvieramos reglas comerciales o calculos se haria acá 
                    
                    case EstadoEntidad.Agregado:
                        empleadoRepositorio.Create(empleadoModelo);
                        msg = "Ha sido Registrado correctamente";
                        break;
                    case EstadoEntidad.Modificado:
                        empleadoRepositorio.Update(empleadoModelo);
                        msg = "Ha sido Modificado correctamente";
                        break;
                    case EstadoEntidad.Eliminado:
                        empleadoRepositorio.Delete(empleadoModelo.IdPK);
                        msg = "Ha sido Eliminado correctamente";
                        break;
                }
            }
            catch (Exception ex)
            {
                //Guardo en una variable el numero de la exepcion
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                //Verificamos la excepcion dato duplicado
                if(sqlEx!=null && sqlEx.Number == 2627)
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

        public List<EmpleadoModelo> LeerTodo()
        {
            var empleadoModelo = empleadoRepositorio.ReadAll();
            listaEmpleado = new List<EmpleadoModelo>();
            foreach (Empleado item in empleadoModelo)
            {
                listaEmpleado.Add(new EmpleadoModelo
                {
                    IdPK = item.IdPK,
                    IdNumero=item.IdNumero,
                    Nombre=item.Nombre,
                    Mail=item.Mail,
                    Nacimiento=item.Nacimiento,
                    Edad=CalcularEdad(item.Nacimiento)
                });
            }
            return listaEmpleado;

        }

        public int CalcularEdad(DateTime nacimiento)
        {
            DateTime Hoy = DateTime.Now;
            return Convert.ToInt32(Hoy.Year - nacimiento.Year);
        }

        public IEnumerable<EmpleadoModelo> BuscarId(string filtro)
        {
            //Buscar exacto
            //return LeerTodo().FindAll(e => e.IdNumero == filtro);
            
            //Buscar que contenga
            return listaEmpleado.FindAll(e => e.idNumero.Contains(filtro) || e.Nombre.Contains(filtro));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
