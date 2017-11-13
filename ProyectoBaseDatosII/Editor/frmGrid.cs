using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBaseDatosII
{
    public partial class radGrid : Form
    {
        

        public radGrid()
        {
            //
            InitializeComponent();
        }

        private void dataGridView_Load(object sender, EventArgs e)
        {
            gridView.DataSource = CapaNegocios.ClsEnviarQuerys.Datos;
            
        }
    }
}
