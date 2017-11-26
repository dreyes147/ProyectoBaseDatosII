using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBaseDatosII.Editor
{
    public partial class frmRepIndices : Form
    {
        CapaNegocios.clsCargarReportes Enlace = new CapaNegocios.clsCargarReportes();
        public frmRepIndices()
        {
            InitializeComponent();
        }

        private void frmRepIndices_Load(object sender, EventArgs e)
        {
            dgvReportes.DataSource = Enlace.ReporteIndeices();
        }
    }
}
