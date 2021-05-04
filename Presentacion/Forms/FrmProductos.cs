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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void ipbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
