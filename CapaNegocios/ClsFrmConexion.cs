using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocios
{
    public class ClsFrmConexion
    {
        
        public DataTable cargarCboConexion()
        {
            CapaDatos.Clases.ClsMetodosConexion enlace = new CapaDatos.Clases.ClsMetodosConexion();
            DataTable dtTiposConexion;
            dtTiposConexion = enlace.cargarCboTipoConexion();
            return dtTiposConexion;
        }
    }
}
