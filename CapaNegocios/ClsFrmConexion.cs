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
        //metodo para devolver los datos de la base de datos
        public DataTable cargarCboConexion()
        {
            CapaDatos.Clases.ClsMetodosConexion enlace = new CapaDatos.Clases.ClsMetodosConexion();
            DataTable dtTiposConexion;
            dtTiposConexion = enlace.cargarCboTipoConexion();
            return dtTiposConexion;
        }
        // metodo para conectarse a la base de datos local por medio de windows Authentication
        public void winAuthen(string instancia)
        {

        }
    }
}
