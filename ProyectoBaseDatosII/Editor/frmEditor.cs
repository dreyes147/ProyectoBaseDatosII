﻿using System;
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
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        #region Declaración de Variables

        int vCaracter;

        #endregion

        #region Declaración de Métodos

        public void CargarTreeView()
        {
            try
            {
                TrvDatos.Nodes.Clear(); //Se limpia el tree
                CapaNegocios.ClsTreeView tw = new CapaNegocios.ClsTreeView();
                DataTable dt = (DataTable)tw.Nodo(0);
                TreeNode padre = null;
                TreeNode hijo = null;
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows) //se recorren todas las linea de la tabla 
                    {
                        padre = new TreeNode(dr.ItemArray[1].ToString()); //se utiliza para que el nodo padre tenga un nombre
                        DataTable dthijo = (DataTable)tw.Nodo(int.Parse(dr.ItemArray[0].ToString())); // se llaman a los nodos hijos
                        foreach (DataRow dr2 in dthijo.Rows) // se recorre la tabla
                        {
                            hijo = new TreeNode(dr2.ItemArray[1].ToString());
                            padre.Nodes.Add(hijo); // se le asignan los nodos hijos al nodo padre
                        }
                        TrvDatos.Nodes.Add(padre); // se agrega el nodo padre con todos los hijos
                    }
                }
                else MessageBox.Show("No hay Elementos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion

        #region Declaración de Eventos

        private void frmEditor_Load(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval = 10;
                timer1.Start();
                tlblFecha.Text = DateTime.Now.ToShortDateString();
                CargarTreeView();
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

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            
        }



        
    }
}
