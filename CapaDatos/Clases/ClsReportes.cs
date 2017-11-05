using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    public class ClsReportes
    {
        Conexion.ClsConexion enlaceWeb = new Conexion.ClsConexion();
        public void InsertarRepo(string id, string Tipo)
        {
            string vInstruccion = "Insert Into ReporteSnip(Id_Snip, Descripcion) values(" + id + ", '" + Tipo + "')";
            enlaceWeb.Ejecutar(vInstruccion, "BaseDatos");
        }
    }
}
