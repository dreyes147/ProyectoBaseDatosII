using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    public class clsIndex
    {
        public clsIndex() {
        }

        public DataTable ValidarIndex(string pNombreTabla)
        {
            DataTable dtResultado = new DataTable();
            string vSql = string.Empty;
            Conexion.ClsConexionLocal vConexion = new Conexion.ClsConexionLocal();
            try
            {
                vSql = "Exec sp_helpindex '"+ pNombreTabla+"'";
                dtResultado = vConexion.ejecutar(vSql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message,ex);
            }
            return dtResultado; 
        }
    }
}
