using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ProyectoBaseDatosII.Editor
{
    public partial class frmReportesEspecificos : Form
    {
        //Variables Globales
        DataTable oDTResultado;
        CapaNegocios.clsCargarReportes enlaceReporte = new CapaNegocios.clsCargarReportes();
        public frmReportesEspecificos()
        {
            InitializeComponent();
        }

        private void frmReportesEspecificos_Load(object sender, EventArgs e)
        {
            oDTResultado = new DataTable();
            if (rdbDDL.Checked == true)
            {                
                 oDTResultado = enlaceReporte.ReporteEspecifico("DDL");
                dgvReportes.DataSource = oDTResultado;
            }
            else
            {
                oDTResultado = enlaceReporte.ReporteEspecifico("DML");
                dgvReportes.DataSource = oDTResultado;
            }
        }
    }
}
