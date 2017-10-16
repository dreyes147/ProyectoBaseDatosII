using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;


namespace CapaNegocios
{
    public class ClsTreeView
    {
        CapaDatos.Conexion.ClsConexion con = new CapaDatos.Conexion.ClsConexion();
        public DataTable Nodo(int id)
        {
            try
            {
                DataTable vResultado = new DataTable();
                CapaDatos.Clases.ClsTreeView vTreeView = new CapaDatos.Clases.ClsTreeView();
                vResultado = vTreeView.Nodo();
                return vResultado;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
