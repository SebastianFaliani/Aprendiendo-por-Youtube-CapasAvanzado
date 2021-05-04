using Negocio.Modelos;
using Negocio.Validaciones;
using Soporte.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class FrmModificarPassword : Form
    {
        public FrmModificarPassword()
        {
            InitializeComponent();
        }

        private void FrmModificarPassword_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            CargarDatos();
            ModificarPass();
        }

        private void reset()
        {
            CargarDatos();
            ModificarPass();
        }

        private void CargarDatos()
        {
            lblUsuario.Text = UsuarioSesionCache.Usuario;
            lblNombre.Text = UsuarioSesionCache.Nombre;
            lblApellido.Text = UsuarioSesionCache.Apellido;
            lblEmail.Text = UsuarioSesionCache.Email;
            lblPermiso.Text = UsuarioSesionCache.Permiso;

            txtUsuario.Text = UsuarioSesionCache.Usuario;
            txtNombre.Text = UsuarioSesionCache.Nombre;
            txtApellido.Text = UsuarioSesionCache.Apellido;
            txtEmail.Text = UsuarioSesionCache.Email;
            txtPass.Text = UsuarioSesionCache.Password;
            txtConfirmePass.Text = UsuarioSesionCache.Password;
            txtPassActual.Text = "";

        }

        private void ModificarPass()
        {
            linkLabel2.Text = "Modificar";
            txtPass.Enabled = false;
            txtPass.UseSystemPasswordChar = true;
            txtConfirmePass.Enabled = false;
            txtConfirmePass.UseSystemPasswordChar = true;
        }

        private void ipbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel4.Visible = true;
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            reset();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel2.Text == "Modificar")
            {
                linkLabel2.Text = "Cancelar";
                txtPass.Enabled = true;
                txtPass.Text = "";
                txtConfirmePass.Enabled = true;
                txtConfirmePass.Text = "";

            }
            else if (linkLabel2.Text == "Cancelar")
            {
                reset();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Length >= 5)
            {
                if (txtPass.Text == txtConfirmePass.Text)
                {
                    if (txtPassActual.Text == UsuarioSesionCache.Password)
                    {
                        UsuarioModelo usuarioModelo = new UsuarioModelo();
                        usuarioModelo.Estado = EstadoEntidad.Modificado;
                        usuarioModelo.IdUsuario = UsuarioSesionCache.IdUsuario;
                        usuarioModelo.NombreUsuario = txtUsuario.Text;
                        usuarioModelo.Pass = txtPass.Text;
                        usuarioModelo.Nombre = txtNombre.Text;
                        usuarioModelo.Apellido = txtApellido.Text;
                        usuarioModelo.Permiso = null;
                        usuarioModelo.Email = txtEmail.Text;
                        string result = usuarioModelo.GuardarCambios();
                        MessageBox.Show(result);
                        reset();
                        panel4.Visible = false;


                    }
                    else
                    {
                        MessageBox.Show("Contraseñas Actual Incorrecta, intentelo otra vez");
                    }
                }
                else
                {
                    MessageBox.Show("Las Contraseñas con coinciden, intentelo otra vez");
                }
            }
            else
            {
                MessageBox.Show("La Contraseñas debe tener como minimo 5 caracteres");
            }
        }
    }
}
