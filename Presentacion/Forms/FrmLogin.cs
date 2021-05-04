using Negocio.Modelos;
using Negocio.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text== "USUARIO")
            {
                txtUsuario.Clear();
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Clear();
                txtPass.ForeColor = Color.White;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO")
            {
                if (txtPass.Text != "CONTRASEÑA")
                {
                    UsuarioModelo usuario = new UsuarioModelo();
                    bool acceso=usuario.LoginUsuario(txtUsuario.Text,txtPass.Text);
                    if (acceso)
                    {
                        this.Hide();
                        Form frm = new FrmBienvenida();
                        frm.ShowDialog();
                        frm = new FrmMenuInformatica();
                        frm.Show();
                        frm.FormClosed += CerrarSesion;
                        
                    }
                    else
                    {
                        msgError("El Usuario o la Contraseña son incorrectos. \n      Intente de nuevo");
                        txtPass.Clear();
                        txtPass.Focus();
                    }

                }else msgError("Ingrese la Contraseña");

            }else msgError("Ingrese el nombre de Usuario");

        }

        private void msgError(string msg)
        {
            lblErrorMensaje.Text = "      " + msg;
            lblErrorMensaje.Visible = true;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //para que no haga el beep al precionar enter
                e.Handled = true;

                btnAcceder_Click(sender,e);
            }
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Clear();
            txtUsuario.Text = "USUARIO";
            txtPass.Clear();
            txtPass.Text = "CONTRASEÑA";
            txtPass.UseSystemPasswordChar = false;
            lblErrorMensaje.Visible = false;
            this.Show();
            txtUsuario.Focus();

        }

        private void linkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new FrmRecuperarPassword();
            frm.ShowDialog();
        }

        private void ipbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ipbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
