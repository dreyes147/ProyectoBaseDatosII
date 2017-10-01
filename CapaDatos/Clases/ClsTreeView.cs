using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Clases
{
    public class ClsTreeView
    {
        public DataTable Nodo(int id)
        {
            try
            {
                DataTable vResultado = new DataTable();
                string sql = "Select Id, nvarchar=Nombre +' '+ apellido from Empleado where Id_Jefe =" + id;
                Conexion.ClsConexion vConexion = new Conexion.ClsConexion();
                vResultado = vConexion.Seleccionar(sql, "BaseDatos");
                return vResultado;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
