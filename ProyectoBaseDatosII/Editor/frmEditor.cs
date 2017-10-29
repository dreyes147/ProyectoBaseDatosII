using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ProyectoBaseDatosII.Editor
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        #region Declaración de Variables

        int vCaracter;
        string vFileDialog;

        #endregion

        #region Declaración de Métodos

        public void CargarTreeView()
        {  
            CapaNegocios.ClsTreeView vNegocioTreeview = new CapaNegocios.ClsTreeView();
            DataTable dtDatosTreeview = new DataTable();
            TreeNode vNodoRaiz;
            TreeNode vNodoPadre;
            TreeNode vNodoHijo;
            try
            {
                TrvDatos.Nodes.Clear(); //Se limpia el tree
                dtDatosTreeview = vNegocioTreeview.DatosTreeview();
                if (dtDatosTreeview.Rows.Count != 0)
                {
                    vNodoRaiz = new TreeNode("Bases de Datos"); //se utiliza para que el nodo padre tenga un nombre
                    foreach (DataRow vRow in dtDatosTreeview.Select("CodigoPadre = 0")) //se recorren todas las linea de la tabla 
                    {
                        vNodoPadre = new TreeNode(vRow["Descripcion"].ToString());
                        foreach (DataRow vItem in dtDatosTreeview.Select("CodigoPadre = " + vRow["Codigo"].ToString())) {
                            vNodoHijo = new TreeNode(vItem["Descripcion"].ToString());
                            vNodoPadre.Nodes.Add(vNodoHijo);
                        }
                        vNodoRaiz.Nodes.Add(vNodoPadre);
                    }
                    TrvDatos.Nodes.Add(vNodoRaiz); 
                }
                else MessageBox.Show("No hay Elementos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        //metodo para abrir documentos
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Filter = "Query|*.sql";    // Se define el tipo de dato a guardar

            if (oFD.ShowDialog() == DialogResult.OK)  //si se selecciona OK
            {
                vFileDialog = oFD.FileName;   // guardamos en la variable el documento seleccionado

                using (StreamReader sReader = new StreamReader(vFileDialog))
                {
                    rtbEditor.Text = sReader.ReadToEnd();  // se escribe el documento
                }
            }
        }

        #endregion

        #region Declaración de Eventos

        private void frmEditor_Load(object sender, EventArgs e)
        {
            cbDatos.Items.Add("Select");
            cbDatos.Items.Add("Insert");
            cbDatos.Items.Add("Update");
            cbDatos.Items.Add("Delete");

            cbDDL.Items.Add("Create");
            cbDDL.Items.Add("Drop");
            cbDDL.Items.Add("Alter");

            try
            {
                timer1.Interval = 10;
                timer1.Start();
                tlblFecha.Text = DateTime.Now.ToShortDateString();
                //CargarTreeView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnRefreshTrv_Click(object sender, EventArgs e)
        {
            try
            {
                CargarTreeView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void ptbNumeros_Paint(object sender, PaintEventArgs e)
        {
            int vAltura = rtbEditor.GetPositionFromCharIndex(0).Y;
            try
            {
                vCaracter = 0;
                if (rtbEditor.Lines.Length > 0)
                {
                    for (int i = 0; i < rtbEditor.Lines.Length; i++)
                    {
                        e.Graphics.DrawString(Convert.ToString(i + 1), rtbEditor.Font, Brushes.Blue, ptbNumeros.Width - (e.Graphics.MeasureString(Convert.ToString(i + 1), rtbEditor.Font).Width + 10), vAltura);
                        vCaracter += rtbEditor.Lines[i].Length + 1;
                        vAltura = rtbEditor.GetPositionFromCharIndex(vCaracter).Y;
                    }
                }
                else
                {
                    e.Graphics.DrawString("1", rtbEditor.Font, Brushes.Blue, rtbEditor.Width - (e.Graphics.MeasureString("1", rtbEditor.Font).Width + 10), vAltura);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                ptbNumeros.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //metodos para guardar documentos
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sFD = new SaveFileDialog();
            sFD.Filter = "Query|*.sql";     //se definen los tipos de datos

            if (vFileDialog != null)  // si el archivo ya existe
            {
                using (StreamWriter sWriter = new StreamWriter(vFileDialog))
                {
                    sWriter.Write(rtbEditor.Text); // se sobreescribe
                }
            }
            else // si el archivo no existe
            {
                if (sFD.ShowDialog() == DialogResult.OK)
                {
                    vFileDialog = sFD.FileName;  //se le asigna un nombre
                    using (StreamWriter sWriter = new StreamWriter(sFD.FileName))
                    {
                        sWriter.Write(rtbEditor.Text); //lo guarda el archivo con el nombre asignado con anterioridad
                    }
                }
            }
        }


        //metodo para cerrar el editor
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // metodo para crear un archivo nuevo
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            vFileDialog = null;
        }

        private void cbDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Snippets snip = new Snippets();

            switch (cbDatos.SelectedItem.ToString())
            {
                case "Select":
                    rtbEditor.Text += snip.select();
                    break;
                case "Insert":
                    rtbEditor.Text += snip.insert();
                    break;
                case "Update":
                    rtbEditor.Text += snip.update();
                    break;
                case "Delete":
                    rtbEditor.Text += snip.delete();
                    break;
                default:
                    break;
            }

        }

        private void rtbEditor_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.M))
            {
                cbDatos.DroppedDown = true;
                //MessageBox.Show("Se ha pulsado la combinación de teclas Control+N");

            }

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.D))
            {
                cbDDL.DroppedDown = true;

            }
        }

        private void cbDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            Snippets snip = new Snippets();

            switch (cbDDL.SelectedItem.ToString())
            {
                case "Create":
                    rtbEditor.Text += snip.create();
                    break;
                case "Drop":
                    rtbEditor.Text += snip.drop();
                    break;
                case "Alter":
                    rtbEditor.Text += snip.alter();
                    break;
                default:
                    break;
            }
        }

        #endregion

    }
}
