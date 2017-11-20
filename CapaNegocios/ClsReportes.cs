using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ClsReportes
    {
        CapaDatos.Clases.ClsReportes enlace = new CapaDatos.Clases.ClsReportes();
        public void inserReporte(string id, string Descripcion, string tipoSnip)
        {
            enlace.InsertarRepo(id, Descripcion, tipoSnip);
        }
    }
}
