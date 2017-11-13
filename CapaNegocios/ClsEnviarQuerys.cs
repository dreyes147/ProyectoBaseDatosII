using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaNegocios
{
    public class ClsEnviarQuerys
    {
        public static string query { get; set; }
        public static string nonQuery { get; set; }
        public static DataTable Datos { get; set; }
        public static string error { get; set; }

        public bool enviar() {
            CapaDatos.Conexion.ClsConexionLocal.query = query;
            CapaDatos.Conexion.ClsConexionLocal ejecutar = new CapaDatos.Conexion.ClsConexionLocal();
            if (ejecutar.ejecutarDatos() == true)
            {
                Datos = CapaDatos.Conexion.ClsConexionLocal.Datos;
                return true;
            }
            else
            {
               
                error = CapaDatos.Conexion.ClsConexionLocal.errorDatos;
                return false;
            }


        }

        public bool enviarSinRetorno()
        {
            CapaDatos.Conexion.ClsConexionLocal.nonquery = nonQuery;
            CapaDatos.Conexion.ClsConexionLocal ejecutar = new CapaDatos.Conexion.ClsConexionLocal();
            if (ejecutar.ejecutarDatosSinRetorno() == true)
            {
                return true;
            }
            else
            {
                error = CapaDatos.Conexion.ClsConexionLocal.errorDatos;
                return false;
            }


        }


    }
}
