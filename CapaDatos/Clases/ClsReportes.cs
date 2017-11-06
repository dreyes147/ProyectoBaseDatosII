using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos.Clases
{
    public class ClsReportes
    {
        Conexion.ClsConexion enlaceWeb = new Conexion.ClsConexion();
        public void InsertarRepo(string id, string Descipcion, string TipoSnip)
        {
            string vInstruccion = "INSERT INTO Reportes(IdSnip, Descipcion, TipoSnippet) values(" + id + ", '" + Descipcion + "', '" + TipoSnip + "')";
            enlaceWeb.Ejecutar(vInstruccion, "BaseDatos");
        }

        public DataTable ReportesSnippets(string tipoReporte)
        {
            string vInstruccion = "SELECT TOP (3) count(*) MASUSADO, Descipcion from Reportes group by Descipcion Order by MASUSADO "+ tipoReporte +";";
            DataTable vResultado = enlaceWeb.Seleccionar(vInstruccion, "BaseDatos");
            return vResultado;

        }

        public DataTable ReportesInstrucciones(string tipoInstruccion, string tipoReporte)
        {
            string vInstruccion = " SELECT TOP (3) count(*) MASUSADO, Descipcion from Reportes where TipoSnippet = '"+ tipoInstruccion +"' group by Descipcion Order by MASUSADO "+ tipoReporte +";";
            DataTable vResultado = enlaceWeb.Seleccionar(vInstruccion, "BaseDatos");
            return vResultado;
        }

    }
}
