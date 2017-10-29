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
        public DataTable DatosTreeview()
        {
            try
            {
                DataTable vResultado = new DataTable();
                CapaDatos.Clases.ClsTreeView vTreeView = new CapaDatos.Clases.ClsTreeView();
                vResultado = vTreeView.DatosTreeview();
                return vResultado;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
