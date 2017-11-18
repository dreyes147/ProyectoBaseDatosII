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
    public partial class frmReporteGeneral : Form
    {
        //Variables Globales
        CapaNegocios.clsCargarReportes enlaceReportes = new CapaNegocios.clsCargarReportes();
        public frmReporteGeneral()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            DataTable oDTResultado = new DataTable();
            oDTResultado =  enlaceReportes.ReporteGeneral();
            dgvReporteGeneral.DataSource = oDTResultado;
        }

    }
}
