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
using System.Threading;

namespace ProyectoBaseDatosII
{
    public partial class frmServerConnect : Form
    {
        //variables globales
        //SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
        static SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
        System.Data.DataTable table = instance.GetDataSources();
        CapaNegocios.ClsFrmConexion enlace = new CapaNegocios.ClsFrmConexion();
        public frmServerConnect()
        {
            InitializeComponent();
        }

        public void iniciarSplashScreen() {
            Application.Run(new Conexion.SplashScreen());
        }

        private void frmServerConnect_Load(object sender, EventArgs e)
        {
            
            //cargar cbo Instacias
            DataTable dtinstancias = instance.GetDataSources(); 
            cboInstancias2.DataSource = dtinstancias;
            cboInstancias2.DisplayMember = "ServerName";
            cboInstancias2.ValueMember = "ServerName";

            //Cargar cbo Forma de conexion
            DataTable oDT = new DataTable();
            oDT = enlace.cargarCboConexion();
            cboAutentificacion.DataSource = oDT;
            cboAutentificacion.DisplayMember = "Descripcion";
            cboAutentificacion.ValueMember = "Id";

            //Lanza el splashscreen
            Thread c = new Thread(new ThreadStart(iniciarSplashScreen));
            c.Start();
            Thread.Sleep(5000);
            c.Abort();

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            conectar();
        }

        public void conectar() {
            bool vEstCoenxion;
            if (cboAutentificacion.SelectedValue.ToString() == "1")
            {
                vEstCoenxion = enlace.winAuthen(cboInstancias2.Text);
                if (vEstCoenxion)
                {
                    //MessageBox.Show("Conexion Iniciada");

                    this.Hide();
                    Editor.frmEditor editor = new Editor.frmEditor();
                    editor.Show();
                }
                else
                    MessageBox.Show("Conexion Fallida");
            }
            else if (cboAutentificacion.SelectedValue.ToString() == "2")
            {
                vEstCoenxion = enlace.SqlAuthen(cboInstancias2.SelectedValue.ToString(), txtUsuario.Text, txtPassword.Text);
                if (vEstCoenxion)
                {
                    MessageBox.Show("Conexion Iniciada");
                    Editor.frmEditor editor = new Editor.frmEditor();
                    editor.Show();
                }
                else
                    MessageBox.Show("Conexion Fallida");
            }
        }


        private void cboAutentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboAutentificacion.Text)
            {
                case "Windows Authentication":
                txtUsuario.ReadOnly = true;
                txtPassword.ReadOnly = true;
                break;
                default:
                    txtUsuario.ReadOnly = false;
                    txtPassword.ReadOnly = false;
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboInstancias2_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
            {
                conectar();
            }
        }
    }
}
