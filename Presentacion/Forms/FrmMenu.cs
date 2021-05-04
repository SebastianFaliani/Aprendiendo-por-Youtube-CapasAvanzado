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
    public partial class FrmMenu : Form
    {
        private Form vFrmNuevo = null;
        public FrmMenu()
        {
            InitializeComponent();
           
        }

        private void VerSubMenus(Panel submenus)
        {
            if (submenus.Visible == false)
                submenus.Visible = true;
            else
                submenus.Visible = false;
        }

        private void OcultarSubMenus()
        {
            if (pnlMedia.Visible == true) pnlMedia.Visible = false;
            if (pnlRepoduccion.Visible == true) pnlRepoduccion.Visible = false;
            if (pnlHerramienta.Visible == true) pnlHerramienta.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            VerSubMenus(pnlMedia);
        }

        private void btnHerramienta_Click(object sender, EventArgs e)
        {
            VerSubMenus(pnlHerramienta);
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            VerSubMenus(pnlRepoduccion);
        }


        #region SubMenu Media

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
        }

        #endregion

        #region SubMenu Lista de Reproduccion

        private void iconButton10_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
        }
        #endregion

        #region SubMenu Herramientas

        private void iconButton15_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
        }

        #endregion

        private void btnEcualizador_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
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
            
            vFrmNuevo = frmAbrir;

        }


    }
}