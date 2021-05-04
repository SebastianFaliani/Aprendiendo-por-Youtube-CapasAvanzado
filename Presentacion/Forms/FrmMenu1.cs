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
    public partial class FrmMenu1 : Form
    {
        private Form activeForm;
    
        public FrmMenu1()
        {
            InitializeComponent();
        
        }

        private void AbrirFormHijo(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panelCentral.Controls.Add(form);
            this.panelCentral.Tag = form;
            form.BringToFront();
            form.Show();
            lblTitulo.Text = form.Text;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Forms.FrmEmpleado());
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
        }
    }
}
