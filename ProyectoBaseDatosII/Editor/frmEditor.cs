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

        string[] arregloDMLBasico = new string[4];
        string[] arregloSelect = new string[2];
        string[] arregloInsert = new string[3];
        string[] arregloUpdate = new string[3];
        string[] arregloDelete = new string[2];

        int posicion = 0;

        string[] arregloDDLBasico = new string[3];
        string[] arregloCreate = new string[3];
        string[] arregloDrop = new string[1];
        string[] arregloAlter = new string[5];

        string[] arregloTodos = new string[32];

        List<string> bases = new List<string>();

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
                        vNodoPadre.ImageIndex = 0;
                        foreach (DataRow vItem in dtDatosTreeview.Select("CodigoPadre = " + vRow["Codigo"].ToString()))
                        {
                            vNodoHijo = new TreeNode(vItem["Descripcion"].ToString());
                            vNodoHijo.ImageIndex = 1;
                            vNodoPadre.Nodes.Add(vNodoHijo);
                        }
                        vNodoRaiz.Nodes.Add(vNodoPadre);
                        string[] soloNombre = vNodoPadre.ToString().Split();
                        bases.Add(soloNombre[1]);
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
                    colorLetras();
                }
            }
        }

        #endregion

        #region Declaración de Eventos

        private void frmEditor_Load(object sender, EventArgs e)
        {
            /*
            this.Size = SystemInformation.PrimaryMonitorSize;
            radEditor.Size = SystemInformation.PrimaryMonitorSize;
            */
            cbDatos.Items.Add("Select");
            cbDatos.Items.Add("Insert");
            cbDatos.Items.Add("Update");
            cbDatos.Items.Add("Delete");

            cbDDL.Items.Add("Create");
            cbDDL.Items.Add("Create Index");
            cbDDL.Items.Add("Create User");
            cbDDL.Items.Add("Create Function");
            cbDDL.Items.Add("Create Proc");
            cbDDL.Items.Add("Create Database");
            cbDDL.Items.Add("Alter Add");
            cbDDL.Items.Add("Alter Drop");
            cbDDL.Items.Add("Alter Alter");
            cbDDL.Items.Add("Alter Index");
            cbDDL.Items.Add("Alter User");
            cbDDL.Items.Add("Alter Function");
            cbDDL.Items.Add("Alter Proc");
            cbDDL.Items.Add("Drop");
            cbDDL.Items.Add("Drop Index");
            cbDDL.Items.Add("Drop User");
            cbDDL.Items.Add("Drop Function");
            cbDDL.Items.Add("Drop Proc");
            cbDDL.Items.Add("Drop Database");


            arregloDMLBasico[0] = "select";
            arregloDMLBasico[1] = "insert";
            arregloDMLBasico[2] = "update";
            arregloDMLBasico[3] = "delete";

            arregloSelect[0] = "from";
            arregloSelect[1] = "where";

            arregloInsert[0] = "into";
            arregloInsert[1] = "values";

            arregloUpdate[0] = "set";
            arregloUpdate[1] = "where";

            arregloDelete[0] = "from";
            arregloDelete[1] = "where";

            arregloDDLBasico[0] = "create";
            arregloDDLBasico[1] = "drop";
            arregloDDLBasico[2] = "alter";

            arregloCreate[0] = "table";
            arregloCreate[1] = "(";
            arregloCreate[2] = ")";

            arregloDrop[0] = "table";

            arregloAlter[0] = "table";
            arregloAlter[1] = "add";
            arregloAlter[2] = "drop";
            arregloAlter[3] = "column";
            arregloAlter[4] = "alter";

            arregloTodos[0] = "select";
            arregloTodos[1] = "insert";
            arregloTodos[2] = "update";
            arregloTodos[3] = "delete";
            arregloTodos[4] = "from";
            arregloTodos[5] = "where";
            arregloTodos[6] = "into";
            arregloTodos[7] = "values";
            arregloTodos[8] = "set";
            arregloTodos[9] = "create";
            arregloTodos[10] = "drop";
            arregloTodos[11] = "alter";
            arregloTodos[12] = "add";
            arregloTodos[13] = "column";
            arregloTodos[14] = "on";
            arregloTodos[15] = "index";
            arregloTodos[16] = "user";
            arregloTodos[17] = "proc";
            arregloTodos[18] = "procedure";
            arregloTodos[19] = "database";
            arregloTodos[20] = "function";
            arregloTodos[21] = "returns";
            arregloTodos[22] = "as";
            arregloTodos[23] = "begin";
            arregloTodos[24] = "end";
            arregloTodos[25] = "return";
            arregloTodos[26] = "case";
            arregloTodos[27] = "when";
            arregloTodos[28] = "then";
            arregloTodos[29] = "else";
            arregloTodos[30] = "declare";
            arregloTodos[31] = "exec";


            try
            {
                timer1.Interval = 10;
                timer1.Start();
                tlblFecha.Text = DateTime.Now.ToShortDateString();
                CargarTreeView();

                for (int i = 0; i < bases.Count; i++)
                {
                    cbBasesDeDatos.Items.Add(bases[i].Trim());
                }
                //MessageBox.Show(bases.Count.ToString());
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
            Application.Exit();
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
            try
            {
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
                colorLetras();
            }
            catch (Exception)
            {
                MessageBox.Show("Teclas de acceso rapido\n ctrl + m = DML \n ctrl + d = DDL");
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

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F5))
            {
                ejecutar();

            }

            if (Convert.ToInt32(e.KeyData) != Convert.ToInt32(Keys.Enter) && Convert.ToInt32(e.KeyData) != Convert.ToInt32(Keys.Space))
            {

                colorLetras();

            }
        }

        private void colorLetras()
        {
            /*
            posicion = rtbEditor.SelectionStart;
            this.rtbEditor.Select(0, rtbEditor.Text.Length);
            this.rtbEditor.SelectionColor = Color.Black;
            this.rtbEditor.Select(posicion, 0);

            string[] texto = rtbEditor.Text.Trim().Split();
            int inicio = 0;

            foreach (string z in texto)
            {
                foreach (string x in arregloTodos)
                {
                    if (z.Length != 0)
                    {
                        if (z.Trim().Equals(x, StringComparison.InvariantCultureIgnoreCase))
                        {
                            inicio = rtbEditor.Text.IndexOf(z, inicio);
                            rtbEditor.Select(inicio, z.Length);
                            if (rtbEditor.SelectionColor != Color.Blue)
                            {
                                rtbEditor.SelectionColor = Color.Blue;
                                rtbEditor.Select(posicion, 0);
                                inicio = inicio + 1;
                            }
                            
                        }
                    }
                }
            }
            */
        }//fin del metodo colorLetras


        private void cbDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            Snippets snip = new Snippets();
            try
            {
                switch (cbDDL.SelectedItem.ToString())
                {
                    case "Create":
                        rtbEditor.Text += snip.create();
                        break;
                    case "Create Index":
                        rtbEditor.Text += snip.createIndex();
                        break;
                    case "Create User":
                        rtbEditor.Text += snip.createUser();
                        break;
                    case "Create Function":
                        rtbEditor.Text += snip.createFunction();
                        break;
                    case "Create Proc":
                        rtbEditor.Text += snip.createProc();
                        break;
                    case "Create Database":
                        rtbEditor.Text += snip.createDatabase();
                        break;
                    case "Alter Add":
                        rtbEditor.Text += snip.alter();
                        break;
                    case "Alter Drop":
                        rtbEditor.Text += snip.alterDrop();
                        break;
                    case "Alter Alter":
                        rtbEditor.Text += snip.alterAlter();
                        break;
                    case "Alter Index":
                        rtbEditor.Text += snip.alterIndex();
                        break;
                    case "Alter User":
                        rtbEditor.Text += snip.alterUser();
                        break;
                    case "Alter Function":
                        rtbEditor.Text += snip.alterFunction();
                        break;
                    case "Alter Proc":
                        rtbEditor.Text += snip.alterProc();
                        break;
                    case "Drop":
                        rtbEditor.Text += snip.drop();
                        break;
                    case "Drop Index":
                        rtbEditor.Text += snip.dropIndex();
                        break;
                    case "Drop User":
                        rtbEditor.Text += snip.dropUser();
                        break;
                    case "Drop Function":
                        rtbEditor.Text += snip.dropFunction();
                        break;
                    case "Drop Proc":
                        rtbEditor.Text += snip.dropProc();
                        break;
                    case "Drop Database":
                        rtbEditor.Text += snip.dropDatabase();
                        break;
                    default:
                        break;
                }
                colorLetras();
            }
            catch (Exception)
            {
                MessageBox.Show("Teclas de acceso rapido\n ctrl + m = DML \n ctrl + d = DDL");
            }


        }

        #endregion

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            ejecutar();
        }

        public void ejecutar()
        {
            lbNumTiempoReal.Text = "0";
            lbNumTiempoEstimado.Text = "0";
            Random r = new Random(DateTime.Now.Millisecond);
            double aleatorio = r.NextDouble();
            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            //medicion del tiempo de ejecucion
            Clases.ValidacionIndices vValidacion = new Clases.ValidacionIndices();
            string vIndices = string.Empty;

            if (cbBasesDeDatos.Text != "")
            {
                int cont = 0;
                string[] arregloQuerys = rtbEditor.Text.ToLower().Split(';');
                if (rtbEditor.SelectedText != "".Trim())
                {
                    arregloQuerys = rtbEditor.SelectedText.ToLower().Split(';');
                }
                if ((arregloQuerys.Length - 1) > 0)
                {
                    for (int i = 0; i < arregloQuerys.Length - 1; i++)
                    {

                        if (arregloQuerys[i].Contains(arregloDMLBasico[0]) == true)
                        {
                            if (arregloQuerys[i].Contains(arregloSelect[0]) == true)
                            {
                                cont += 1;
                                //Enviar consulta
                                CapaNegocios.ClsEnviarQuerys.query = "use " + cbBasesDeDatos.Text + "; " + arregloQuerys[i];
                                vIndices = vValidacion.ValidarIndice(arregloQuerys[i], "use " + cbBasesDeDatos.Text);
                                CapaNegocios.ClsEnviarQuerys comando = new CapaNegocios.ClsEnviarQuerys();

                                if (comando.enviar() == true && vIndices == string.Empty)
                                {
                                    radGrid m = new radGrid();
                                    m.Show();
                                    stop = new TimeSpan(DateTime.Now.Ticks);
                                    lbNumTiempoReal.Text = Convert.ToString(Math.Round(stop.Subtract(start).TotalSeconds, 3));
                                    lbNumTiempoEstimado.Text = Convert.ToString(Convert.ToDouble(lbNumTiempoReal.Text) + Math.Round(aleatorio, 3));
                                }
                                else
                                {
                                    MessageBox.Show(CapaNegocios.ClsEnviarQuerys.error + "\n" + vIndices);
                                    if (comando.enviar() == true)
                                    {

                                        if (MessageBox.Show("¿Desea crear los índices de forma automática?", "información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            vValidacion.CrearIndex("use " + cbBasesDeDatos.Text);
                                        }
                                    }
                                }


                            }
                            else
                            {
                                MessageBox.Show("Debe agregar 'FROM' en la sentencia select");
                            }
                        }//fin de if select

                        if (arregloQuerys[i].Contains(arregloDMLBasico[1]) == true)
                        {
                            if (arregloQuerys[i].Contains(arregloInsert[0]) == true)
                            {
                                if (arregloQuerys[i].Contains(arregloInsert[1]) == true)
                                {
                                    cont += 1;
                                    //Enviar consulta
                                    CapaNegocios.ClsEnviarQuerys.nonQuery = "use " + cbBasesDeDatos.Text + "; " + arregloQuerys[i];
                                    CapaNegocios.ClsEnviarQuerys comando = new CapaNegocios.ClsEnviarQuerys();

                                    if (comando.enviarSinRetorno() == true)
                                    {
                                        stop = new TimeSpan(DateTime.Now.Ticks);
                                        lbNumTiempoReal.Text = Convert.ToString(Math.Round(stop.Subtract(start).TotalSeconds, 3));
                                        lbNumTiempoEstimado.Text = Convert.ToString(Convert.ToDouble(lbNumTiempoReal.Text) + Math.Round(aleatorio, 3));
                                        MessageBox.Show("Sentencia Ejecutada\n" + CapaNegocios.ClsEnviarQuerys.num + " filas afectadas");
                                    }
                                    else
                                    {
                                        MessageBox.Show(CapaNegocios.ClsEnviarQuerys.error);
                                    }



                                }
                                else
                                {
                                    MessageBox.Show("Debe agregar 'VALUES' en la sentencia insert");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Debe agregar 'INTO' en la sentencia insert");
                            }
                        }//fin de if insert

                        if (arregloQuerys[i].Contains(arregloDMLBasico[2]) == true)
                        {
                            if (arregloQuerys[i].Contains(arregloUpdate[0]) == true)
                            {
                                if (arregloQuerys[i].Contains(arregloUpdate[1]) == true)
                                {
                                    cont += 1;
                                    //Enviar sentencia
                                    CapaNegocios.ClsEnviarQuerys.nonQuery = "use " + cbBasesDeDatos.Text + "; " + arregloQuerys[i];
                                    CapaNegocios.ClsEnviarQuerys comando = new CapaNegocios.ClsEnviarQuerys();

                                    if (comando.enviarSinRetorno() == true)
                                    {
                                        stop = new TimeSpan(DateTime.Now.Ticks);
                                        lbNumTiempoReal.Text = Convert.ToString(Math.Round(stop.Subtract(start).TotalSeconds, 3));
                                        lbNumTiempoEstimado.Text = Convert.ToString(Convert.ToDouble(lbNumTiempoReal.Text) + Math.Round(aleatorio, 3));
                                        MessageBox.Show("Sentencia Ejecutada\n" + CapaNegocios.ClsEnviarQuerys.num + " filas afectadas");
                                    }
                                    else
                                    {
                                        MessageBox.Show(CapaNegocios.ClsEnviarQuerys.error);
                                    }


                                }
                                else
                                {
                                    MessageBox.Show("Debe agregar 'WHERE' en la sentencia update");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe agregar 'SET' en la sentencia update");
                            }
                        }//fin de if update

                        if (arregloQuerys[i].Contains(arregloDMLBasico[3]) == true)
                        {
                            if (arregloQuerys[i].Contains(arregloDelete[0]) == true)
                            {
                                if (arregloQuerys[i].Contains(arregloDelete[1]) == true)
                                {
                                    cont += 1;
                                    //Enviar consulta
                                    CapaNegocios.ClsEnviarQuerys.nonQuery = "use " + cbBasesDeDatos.Text + "; " + arregloQuerys[i];
                                    CapaNegocios.ClsEnviarQuerys comando = new CapaNegocios.ClsEnviarQuerys();

                                    if (comando.enviarSinRetorno() == true)
                                    {
                                        stop = new TimeSpan(DateTime.Now.Ticks);
                                        lbNumTiempoReal.Text = Convert.ToString(Math.Round(stop.Subtract(start).TotalSeconds, 3));
                                        lbNumTiempoEstimado.Text = Convert.ToString(Convert.ToDouble(lbNumTiempoReal.Text) + Math.Round(aleatorio, 3));
                                        MessageBox.Show("Sentencia Ejecutada\n" + CapaNegocios.ClsEnviarQuerys.num + " filas afectadas");
                                    }
                                    else
                                    {
                                        MessageBox.Show(CapaNegocios.ClsEnviarQuerys.error);
                                    }


                                }
                                else
                                {
                                    MessageBox.Show("Debe agregar 'WHERE' en la sentencia delete");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe agregar 'FROM' en la sentencia delete");
                            }
                        }//fin del if delete

                        if (arregloQuerys[i].Contains(arregloDDLBasico[0]) == true)
                        {
                            if (arregloQuerys[i].Contains(arregloCreate[0]) == true)
                            {
                                if (arregloQuerys[i].Contains(arregloCreate[1]) == true)
                                {
                                    if (arregloQuerys[i].Contains(arregloCreate[2]) == true)
                                    {
                                        cont += 1;
                                        //Enviar consulta
                                        CapaNegocios.ClsEnviarQuerys.nonQuery = "use " + cbBasesDeDatos.Text + "; " + arregloQuerys[i];
                                        CapaNegocios.ClsEnviarQuerys comando = new CapaNegocios.ClsEnviarQuerys();

                                        if (comando.enviarSinRetorno() == true)
                                        {
                                            stop = new TimeSpan(DateTime.Now.Ticks);
                                            lbNumTiempoReal.Text = Convert.ToString(Math.Round(stop.Subtract(start).TotalSeconds, 3));
                                            lbNumTiempoEstimado.Text = Convert.ToString(Convert.ToDouble(lbNumTiempoReal.Text) + Math.Round(aleatorio, 3));
                                            MessageBox.Show("Sentencia Ejecutada Satisfactoriamente");
                                        }
                                        else
                                        {
                                            MessageBox.Show(CapaNegocios.ClsEnviarQuerys.error);
                                        }


                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe agregar ')' en la sentencia Create");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe agregar '(' en la sentencia Create");
                                }
                            }
                            else if (arregloQuerys[i].Contains("index") == true || arregloQuerys[i].Contains("user") == true || arregloQuerys[i].Contains("function") == true || arregloQuerys[i].Contains("proc") == true || arregloQuerys[i].Contains("database") == true || arregloQuerys[i].Contains("procedure") == true)
                            {
                                cont += 1;
                                //Enviar consulta
                                CapaNegocios.ClsEnviarQuerys.nonQuery = "use " + cbBasesDeDatos.Text + "; " + arregloQuerys[i];
                                CapaNegocios.ClsEnviarQuerys comando = new CapaNegocios.ClsEnviarQuerys();

                                if (comando.enviarSinRetorno() == true)
                                {
                                    stop = new TimeSpan(DateTime.Now.Ticks);
                                    lbNumTiempoReal.Text = Convert.ToString(Math.Round(stop.Subtract(start).TotalSeconds, 3));
                                    lbNumTiempoEstimado.Text = Convert.ToString(Convert.ToDouble(lbNumTiempoReal.Text) + Math.Round(aleatorio, 3));
                                    MessageBox.Show("Sentencia Ejecutada Satisfactoriamente");
                                }
                                else
                                {
                                    MessageBox.Show(CapaNegocios.ClsEnviarQuerys.error);
                                }

                            }
                            else {
                                MessageBox.Show("Puede colocar algunas de las siguientes opciones en la sentencia Alter: \nTABLE \nUSER \nINDEX \nFUNCTION \nPROC \nDATABASE");
                            }
                        }//fin del if create

                        if (arregloQuerys[i].Contains(arregloDDLBasico[1]) == true)
                        {
                            if (arregloQuerys[i].Contains(arregloDrop[0]) == true)
                            {
                                cont += 1;
                                //Enviar consulta
                                CapaNegocios.ClsEnviarQuerys.nonQuery = "use " + cbBasesDeDatos.Text + "; " + arregloQuerys[i];
                                CapaNegocios.ClsEnviarQuerys comando = new CapaNegocios.ClsEnviarQuerys();

                                if (comando.enviarSinRetorno() == true)
                                {
                                    stop = new TimeSpan(DateTime.Now.Ticks);
                                    lbNumTiempoReal.Text = Convert.ToString(Math.Round(stop.Subtract(start).TotalSeconds, 3));
                                    lbNumTiempoEstimado.Text = Convert.ToString(Convert.ToDouble(lbNumTiempoReal.Text) + Math.Round(aleatorio, 3));
                                    MessageBox.Show("Sentencia Ejecutada Satisfactoriamente");
                                }
                                else
                                {
                                    MessageBox.Show(CapaNegocios.ClsEnviarQuerys.error);
                                }

                            }
                            else if (arregloQuerys[i].Contains("index") == true || arregloQuerys[i].Contains("user") == true || arregloQuerys[i].Contains("function") == true || arregloQuerys[i].Contains("proc") == true || arregloQuerys[i].Contains("database") == true || arregloQuerys[i].Contains("procedure") == true)
                            {
                                cont += 1;
                                //Enviar consulta
                                CapaNegocios.ClsEnviarQuerys.nonQuery = "use " + cbBasesDeDatos.Text + "; " + arregloQuerys[i];
                                CapaNegocios.ClsEnviarQuerys comando = new CapaNegocios.ClsEnviarQuerys();

                                if (comando.enviarSinRetorno() == true)
                                {
                                    stop = new TimeSpan(DateTime.Now.Ticks);
                                    lbNumTiempoReal.Text = Convert.ToString(Math.Round(stop.Subtract(start).TotalSeconds, 3));
                                    lbNumTiempoEstimado.Text = Convert.ToString(Convert.ToDouble(lbNumTiempoReal.Text) + Math.Round(aleatorio, 3));
                                    MessageBox.Show("Sentencia Ejecutada Satisfactoriamente");
                                }
                                else
                                {
                                    MessageBox.Show(CapaNegocios.ClsEnviarQuerys.error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Puede colocar algunas de las siguientes opciones en la sentencia Alter: \nTABLE \nUSER \nINDEX \nFUNCTION \nPROC \nDATABASE");
                            }
                        }//fin del if de drop

                        if (arregloQuerys[i].Contains(arregloDDLBasico[2]) == true)
                        {
                            string[] arregloAux = arregloQuerys[i].Split();
                            if (arregloQuerys[i].Contains(arregloAlter[0]) == true)
                            {
                                if (arregloQuerys[i].Contains(arregloAlter[1]) == true)
                                {
                                    cont += 1;
                                    //Enviar Sentencia
                                    CapaNegocios.ClsEnviarQuerys.nonQuery = "use " + cbBasesDeDatos.Text + "; " + arregloQuerys[i];
                                    CapaNegocios.ClsEnviarQuerys comando = new CapaNegocios.ClsEnviarQuerys();

                                    if (comando.enviarSinRetorno() == true)
                                    {
                                        stop = new TimeSpan(DateTime.Now.Ticks);
                                        lbNumTiempoReal.Text = Convert.ToString(Math.Round(stop.Subtract(start).TotalSeconds, 3));
                                        lbNumTiempoEstimado.Text = Convert.ToString(Convert.ToDouble(lbNumTiempoReal.Text) + Math.Round(aleatorio, 3));
                                        MessageBox.Show("Sentencia Ejecutada Satisfactoriamente");
                                    }
                                    else
                                    {
                                        MessageBox.Show(CapaNegocios.ClsEnviarQuerys.error);
                                    }


                                }
                                else if (arregloQuerys[i].Contains(arregloAlter[2]) == true)
                                {
                                    if (arregloQuerys[i].Contains(arregloAlter[3]) == true)
                                    {
                                        //Enviar Sentencia
                                        CapaNegocios.ClsEnviarQuerys.nonQuery = "use " + cbBasesDeDatos.Text + "; " + arregloQuerys[i];
                                        CapaNegocios.ClsEnviarQuerys comando = new CapaNegocios.ClsEnviarQuerys();

                                        if (comando.enviarSinRetorno() == true)
                                        {
                                            stop = new TimeSpan(DateTime.Now.Ticks);
                                            lbNumTiempoReal.Text = Convert.ToString(Math.Round(stop.Subtract(start).TotalSeconds, 3));
                                            lbNumTiempoEstimado.Text = Convert.ToString(Convert.ToDouble(lbNumTiempoReal.Text) + Math.Round(aleatorio, 3));
                                            MessageBox.Show("Sentencia Ejecutada Satisfactoriamente");
                                        }
                                        else
                                        {
                                            MessageBox.Show(CapaNegocios.ClsEnviarQuerys.error);
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe agregar la palabra 'COLUMN' en la setencia alter");
                                    }
                                }
                                else
                                    try
                                    {
                                        if (arregloAux[3].Contains(arregloAlter[4]) == true)
                                        {
                                            if (arregloQuerys[i].Contains(arregloAlter[3]) == true)
                                            {
                                                cont += 1;
                                                //Enviar Sentencia
                                                CapaNegocios.ClsEnviarQuerys.nonQuery = "use " + cbBasesDeDatos.Text + "; " + arregloQuerys[i];
                                                CapaNegocios.ClsEnviarQuerys comando = new CapaNegocios.ClsEnviarQuerys();

                                                if (comando.enviarSinRetorno() == true)
                                                {
                                                    stop = new TimeSpan(DateTime.Now.Ticks);
                                                    lbNumTiempoReal.Text = Convert.ToString(Math.Round(stop.Subtract(start).TotalSeconds, 3));
                                                    lbNumTiempoEstimado.Text = Convert.ToString(Convert.ToDouble(lbNumTiempoReal.Text) + Math.Round(aleatorio, 3));
                                                    MessageBox.Show("Sentencia Ejecutada Satisfactoriamente");
                                                }
                                                else
                                                {
                                                    MessageBox.Show(CapaNegocios.ClsEnviarQuerys.error);
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("Debe agregar la palabra 'COLUMN' en la setencia alter");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Debe colocar algunas de las siguientes opciones en la sentencia Alter: \nADD \nDROP \nALTER ");
                                        }
                                    }
                                    catch (Exception)
                                    {

                                        MessageBox.Show("Debe colocar algunas de las siguientes opciones en la sentencia Alter: \nADD \nDROP \nALTER ");
                                    }

                            }
                            else if (arregloQuerys[i].Contains("index") == true || arregloQuerys[i].Contains("user") == true || arregloQuerys[i].Contains("function") == true || arregloQuerys[i].Contains("proc") == true || arregloQuerys[i].Contains("procedure") == true)
                            {
                                cont += 1;
                                //Enviar consulta
                                CapaNegocios.ClsEnviarQuerys.nonQuery = "use " + cbBasesDeDatos.Text + "; " + arregloQuerys[i];
                                CapaNegocios.ClsEnviarQuerys comando = new CapaNegocios.ClsEnviarQuerys();

                                if (comando.enviarSinRetorno() == true)
                                {
                                    stop = new TimeSpan(DateTime.Now.Ticks);
                                    lbNumTiempoReal.Text = Convert.ToString(Math.Round(stop.Subtract(start).TotalSeconds, 3));
                                    lbNumTiempoEstimado.Text = Convert.ToString(Convert.ToDouble(lbNumTiempoReal.Text) + Math.Round(aleatorio, 3));
                                    MessageBox.Show("Sentencia Ejecutada Satisfactoriamente");
                                }
                                else
                                {
                                    MessageBox.Show(CapaNegocios.ClsEnviarQuerys.error);
                                }
                            }
                            else {
                                MessageBox.Show("Puede colocar algunas de las siguientes opciones en la sentencia Alter: \nTABLE \nADD \nDROP \nALTER \nUSER \nINDEX \nFUNCTION \nPROC");
                            }
                        }//fin del if de alter

                    }//fin del for
                    if (cont == 0)
                    {
                        MessageBox.Show("Verifique la sintaxis de su sentencia", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Recuerde terminar su sentencia SQL con ; ");
                }//fin del if de validar si hay algo que ejecutar
            }
            else
            {
                MessageBox.Show("Debe elegir la base de datos donde desea ejecutar el comando");
            }

            lbNumDiferencia.Text = Convert.ToString(Convert.ToDouble(lbNumTiempoEstimado.Text) - Convert.ToDouble(lbNumTiempoReal.Text));

        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrvDatos_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnEjecutar_Click_1(object sender, EventArgs e)
        {
            ejecutar();
        }

        private void cbBasesDeDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gENERALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteGeneral frmReportes = new frmReporteGeneral();
            frmReportes.Show();
        }

        private void dDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportesEspecificos frmReportes = new frmReportesEspecificos();
            frmReportes.Show();
        }

        private void btnRefreshTrv_Click_1(object sender, EventArgs e)
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
    }
}
