using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos.Clases
{
    public class ClsMetodosConexion
    {
        //metodo para cargar datos al combo box de Metodos de conexion
        Conexion.ClsConexion vConexionServidor = new Conexion.ClsConexion();
        Conexion.ClsConexionLocal vConexionLocal = new Conexion.ClsConexionLocal(); 
        public DataTable cargarCboTipoConexion()
        {
            DataTable dtTiposConexion;

            dtTiposConexion = vConexionServidor.Seleccionar("select Id, Descripcion from dbo.MetodosConexion", "BaseDatos");

            return dtTiposConexion;
        }

        //metodo para conectarse por windows Authentication
        public bool conexWinAuthen(string instancia)
        {
            bool EstdConexion;
            vConexionLocal.StrWinAutent(instancia);
            EstdConexion = vConexionLocal.AbrirConexion();
            return EstdConexion;
        }

    }
}
