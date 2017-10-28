using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace ProyectoBaseDatosII
{
    public partial class frmServerConnect : Form
    {
        public frmServerConnect()
        {
            InitializeComponent();
        }

        private void frmServerConnect_Load(object sender, EventArgs e)
        {
            //cargar cbo Instacias
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable dtinstancias = instance.GetDataSources(); 
            cboInstancias2.DataSource = dtinstancias;
            cboInstancias2.DisplayMember = "ServerName";
            cboInstancias2.ValueMember = "ServerName";

            //Cargar cbo Forma de conexion
            CapaNegocios.ClsFrmConexion enlace = new CapaNegocios.ClsFrmConexion();
            DataTable oDT = new DataTable();
            oDT = enlace.cargarCboConexion();
            cboAutentificacion.DataSource = oDT;
            cboAutentificacion.DisplayMember = "Descripcion";
            cboAutentificacion.ValueMember = "Id";
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

        }
    }
}
