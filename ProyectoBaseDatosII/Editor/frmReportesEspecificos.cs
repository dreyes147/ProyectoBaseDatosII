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
            cargarDGV("DML");        
        }


        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if(rdbDDL.Checked == true)
            {
                cargarDGV("DDL");
            }
            else if (rdbDML.Checked == true)
            {
                cargarDGV("DML");
            }
        }

        //
        //Metodo para cargar el data grid view
        //
        public void cargarDGV(string pConsulta)
        {
            DataTable vResultado = new DataTable();
            vResultado = enlaceReporte.ReporteEspecifico(pConsulta);
            dgvReportes.DataSource = vResultado;
        }
    }
}
