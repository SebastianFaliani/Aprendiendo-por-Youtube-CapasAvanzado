using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using Soporte.Cache;

namespace Presentacion.Forms
{
    public partial class FrmMenuInformatica : Form
    {
        Image newLogo;
        private IconButton Boton;
        private Panel leftBorderBtn;

        public FrmMenuInformatica()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 35);
            pnlVertical.Controls.Add(leftBorderBtn);
        }

        private void FrmMenuInformatica_Load(object sender, EventArgs e)
        {
            ipxMaximizar_Click(sender, e);
            CargarDatosUsuario();

            //Administrar Permisos de Usuarios
            if (UsuarioSesionCache.Permiso == Permisos.Administrador)
            {

            }
            else if (UsuarioSesionCache.Permiso == Permisos.Recepcionista)
            {
                iconButton3.Enabled = false;
                iconButton4.Enabled = false;
                iconButton5.Enabled = false;
                iconButton6.Enabled = false;
                iconButton7.Enabled = false;
                iconButton8.Enabled = false;
            }
            else if (UsuarioSesionCache.Permiso == Permisos.Contador)
            {
                iconButton5.Enabled = false;
                iconButton7.Enabled = false;
                iconButton8.Enabled = false;
            }
        }



        private void CargarDatosUsuario()
        {
            lblPermiso.Text = UsuarioSesionCache.Permiso;
            lblUsuario.Text = UsuarioSesionCache.Nombre + " " + UsuarioSesionCache.Apellido;
            lblUsuarioMail.Text = UsuarioSesionCache.Email;
        }

        #region Boton de Cerrar - Maximizar - Minimizar - Restaurar
        private void ipxRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1300, 650);
            this.Location = new Point(Lx, Ly);
            ipxRestaurar.Visible = false;
            ipxMaximizar.Visible = true;

        }

        private void ipbMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int Lx, Ly;
        private void ipxMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            Lx = this.Location.X;
            Ly = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            ipxRestaurar.Visible = true;
            ipxMaximizar.Visible = false;

        }

        private void ipbCerrar_Click_1(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void Cerrar()
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar la sesion?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #endregion

        #region Botones del Menu
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();

                Boton = (IconButton)senderBtn;
                Boton.BackColor = Color.FromArgb(45, 45, 48);
                Boton.ForeColor = Color.White;
                Boton.TextAlign = ContentAlignment.MiddleCenter;
                Boton.IconColor = Color.White;
                Boton.ImageAlign = ContentAlignment.MiddleRight;
                Boton.TextImageRelation = TextImageRelation.TextBeforeImage;

                leftBorderBtn.BackColor = Color.White;
                leftBorderBtn.Location = new Point(0, Boton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmProductos());
            ActivateButton(sender);
            MostrarLogo();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEmpleado());
            ActivateButton(sender);
            MostrarLogo();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        #endregion

        #region Efecto del Menu Desplegable
        private void btnDesplegable_Click(object sender, EventArgs e)
        {
            if (pnlVertical.Width == 220)
            {
                pnlVertical.Width = 68;
            }
            else
            {
                pnlVertical.Width = 220;
            }
        }

        #endregion

        #region Mover Formulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void AbrirFormulario(Form formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }

        private void DisableButton()
        {
            if (Boton != null)
            {
                Boton.BackColor = Color.FromArgb(0, 122, 204);
                
                Boton.ImageAlign = ContentAlignment.MiddleLeft;
                Boton.TextImageRelation = TextImageRelation.ImageBeforeText;
                Boton.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void pcxInicio_Click(object sender, EventArgs e)
        {
            Reinicio();
        }

        private void Reinicio()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            pcxInicio.IconChar = IconChar.Home;
            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reinicio();
            AbrirFormulario(new FrmModificarPassword());
            MostrarLogo();
        }

        private void MostrarLogo()
        {
            this.pictureBox3.Image = global::Presentacion.Properties.Resources.Pañol;
            this.pnlContenedor.Controls.Add(pictureBox3);
        }

    }
}
