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
        //Variables
        CapaDatos.Clases.ClsMetodosConexion enlace = new CapaDatos.Clases.ClsMetodosConexion();

        //metodo para devolver los datos de la base de datos
        public DataTable cargarCboConexion()
        {
            DataTable dtTiposConexion;
            dtTiposConexion = enlace.cargarCboTipoConexion();
            return dtTiposConexion;
        }
        // metodo para conectarse a la base de datos local por medio de windows Authentication
        public bool winAuthen(string instancia)
        {
            bool vEstConexion;
            vEstConexion = enlace.conexWinAuthen(instancia);
            return vEstConexion;
        }

        //metodo para conectarse por Sql Authentication
        public bool SqlAuthen(string instancia, string usuario, string contrasena)
        {
            bool vEstdConexion;
            vEstdConexion = enlace.conexSqlAuthen(instancia, usuario, contrasena);
            return vEstdConexion;
        }
    }
}
