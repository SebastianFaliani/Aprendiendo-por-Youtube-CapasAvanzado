using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Interfaces;
using Negocio;
using Negocio.Modelos;


namespace Presentacion.Forms
{
    public partial class FrmRecuperarPassword : Form
    {
        
        public FrmRecuperarPassword()
        {
            InitializeComponent();
        }

     

        private void ipbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRecuperarPassword_Load(object sender, EventArgs e)
        {
           
           
            this.CenterToScreen();

        }


 

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            UsuarioModelo usuario = new UsuarioModelo();
            string result = usuario.RecuperarPass(txtUsuarioMail.Text);
            lblResultado.Text = result;
        }

    }
}
