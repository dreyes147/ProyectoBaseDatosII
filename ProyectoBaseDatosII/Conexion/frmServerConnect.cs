﻿using System;
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
        //variables globales
        SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
        CapaNegocios.ClsFrmConexion enlace = new CapaNegocios.ClsFrmConexion();
        public frmServerConnect()
        {
            InitializeComponent();
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
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            bool vEstCoenxion;
            if (cboAutentificacion.SelectedValue.ToString() == "1")
            {
                vEstCoenxion = enlace.winAuthen(cboInstancias2.SelectedValue.ToString());
                if (vEstCoenxion)
                {
                    MessageBox.Show("Conexion Iniciada");
                }
                else
                MessageBox.Show("Conexion Fallida");
            }
        }
    }
}
