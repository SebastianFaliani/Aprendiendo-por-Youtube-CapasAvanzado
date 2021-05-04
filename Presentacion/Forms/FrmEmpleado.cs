using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Modelos;
using Negocio.Validaciones;

namespace Presentacion.Forms
{
    public partial class FrmEmpleado : Form
    {
        private EmpleadoModelo empleado = new EmpleadoModelo();
        public FrmEmpleado()
        {
            InitializeComponent();
            listaEmpleado();
            panel1.Enabled = false;
        }

        private void listaEmpleado()
        {
            try
            {
                dataGridView1.DataSource = empleado.LeerTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = empleado.BuscarId(txtBuscar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            empleado.IdNumero = txtIdNumero.Text;
            empleado.Nombre = txtNombre.Text;
            empleado.Mail = txtMail.Text;
            empleado.Nacimiento = dtNacimiento.Value;

            bool valida = new Helps.Validacion(empleado).Validar();
            if (valida == true)
            {
                string result = empleado.GuardarCambios();
                MessageBox.Show(result);
                listaEmpleado();
                limpiar();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                empleado.Estado = EstadoEntidad.Eliminado;
                empleado.IdPK = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string result = empleado.GuardarCambios();
                MessageBox.Show(result);
                listaEmpleado();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                panel1.Enabled = true;
                empleado.Estado = EstadoEntidad.Modificado;
                empleado.IdPK= Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
                txtIdNumero.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtMail.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dtNacimiento.Value=Convert.ToDateTime( dataGridView1.CurrentRow.Cells[4].Value);
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            empleado.Estado=EstadoEntidad.Agregado;
        }

        private void limpiar()
        {
            panel1.Enabled = false;
            txtIdNumero.Clear();
            txtNombre.Clear();
            txtMail.Clear();
            dtNacimiento.Value = DateTime.Now;
        }

        private void ipbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
