using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CapaDatos.Clases
{
    public class ClsReportes
    {
        Conexion.ClsConexion enlaceWeb = new Conexion.ClsConexion();
        //Metodo para insertar los Snippets
        public void InsertarRepo(string id, string Descipcion, string TipoSnip)
        {
            try
            {
                string vInstruccion = "INSERT INTO Reportes(IdSnip, Descipcion, TipoSnippet) values("+ id +", '"+ Descipcion +"', '"+ TipoSnip +"')";
                enlaceWeb.Ejecutar(vInstruccion, "BaseDatos");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable ReportesSnippets()
        {
            string vInstruccion = "SELECT TOP (3) count(*) Cantidad, Descipcion from Reportes group by Descipcion Order by Cantidad;";
            DataTable vResultado = enlaceWeb.Seleccionar(vInstruccion, "BaseDatos");
            return vResultado;

        }

        public DataTable ReportesInstrucciones(string tipoInstruccion)
        {
            
            string vInstruccion = " SELECT TOP (8) count(*) Cantidad, Descipcion from Reportes where TipoSnippet = '"+ tipoInstruccion +"' group by Descipcion Order by Cantidad;";
            DataTable vResultado = enlaceWeb.Seleccionar(vInstruccion, "BaseDatos");
            return vResultado;
        }

    }
}
