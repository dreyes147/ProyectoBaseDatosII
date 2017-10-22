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
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable instancias = instance.GetDataSources();
            
            cboInstancias2.DataSource = instancias;
            cboInstancias2.DisplayMember = "ServerName";
            cboInstancias2.ValueMember = "ServerName";
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

        }
    }
}
