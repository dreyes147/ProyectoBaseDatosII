using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos.Clases
{
    public class ClsEjecutarDatos
    {
        public static string query { get; set; }
        public static string nonquery { get; set; }
        public static SqlDataReader Datos { get; set; }
        public static string errorDatos { get; set; }

        public bool ejecutarDatos()
        {
            try
            {
                Conexion.ClsConexionLocal conn = new Conexion.ClsConexionLocal();
                if (conn.AbrirConexion()==true) {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = string.Format(query);
                    command.CommandType = System.Data.CommandType.Text;
                    Datos = command.ExecuteReader();
                    conn.CerrarConexion();
                    
                };
                return true;

            }
            catch (Exception ex)
            {
                errorDatos = ex.Message;
                return false;
            }

        }
    }
}
