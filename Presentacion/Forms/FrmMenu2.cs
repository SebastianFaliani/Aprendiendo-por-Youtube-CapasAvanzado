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
using FontAwesome.Sharp;

namespace Presentacion.Forms
{
    public partial class FrmMenu2 : Form
    {
        private IconButton currenBtn;
        private Panel leftBorderBtn;
        private Form vFrmNuevo;
        public FrmMenu2()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Metodo
        private void ActivateButton(object senderBtn,Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currenBtn = (IconButton)senderBtn;
                currenBtn.BackColor = Color.FromArgb(19, 116, 173);
                currenBtn.ForeColor = color;
                currenBtn.TextAlign = ContentAlignment.MiddleCenter;
                currenBtn.IconColor = color;
                currenBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currenBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currenBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                pcxInicio.IconChar = currenBtn.IconChar;
                lblInicio.Text = currenBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currenBtn != null)
            {
                currenBtn.BackColor = Color.FromArgb(2,54, 88);
                currenBtn.ForeColor = Color.White;
                currenBtn.TextAlign = ContentAlignment.MiddleLeft;
                currenBtn.IconColor = Color.White;
                currenBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currenBtn.ImageAlign = ContentAlignment.MiddleLeft;


            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
            AbrirFormulario(new FrmEmpleado());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            vFrmNuevo.Close();
            Reinicio();
        }

        private void Reinicio()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            pcxInicio.IconChar = IconChar.Home;
            lblInicio.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormulario(Form frmAbrir)
        {
            if (vFrmNuevo != null)
            {
                vFrmNuevo.Close();
            }
            frmAbrir.TopLevel = false;
            frmAbrir.FormBorderStyle = FormBorderStyle.None;
            frmAbrir.Dock = DockStyle.Fill;
            pnlEscritorio.Controls.Add(frmAbrir);
            pnlEscritorio.Tag = frmAbrir;
            frmAbrir.BringToFront();
            frmAbrir.Show();
            lblInicio.Text = frmAbrir.Text;
            vFrmNuevo = frmAbrir;
          
        }

        private void ipbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ipxMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void ipbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
