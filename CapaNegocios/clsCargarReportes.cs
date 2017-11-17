using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocios
{
    public class clsCargarReportes
    {
        //Variables Globales
        DataTable oDTResultado;
        CapaDatos.Clases.ClsReportes enlaceReportes = new CapaDatos.Clases.ClsReportes();

        //metodo para retornar un reporte General
        public DataTable ReporteGeneral()
        {
            oDTResultado = new DataTable();
            return oDTResultado = enlaceReportes.ReportesSnippets();            
        }

        public DataTable ReporteEspecifico(string pInstruccion)
        {
            oDTResultado = new DataTable();
            return oDTResultado = enlaceReportes.ReportesInstrucciones(pInstruccion);
        }
    }
}
