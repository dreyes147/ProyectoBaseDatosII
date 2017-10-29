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
        Conexion.ClsConexion conectar = new Conexion.ClsConexion();
        public DataTable cargarCboTipoConexion()
        {
            DataTable dtTiposConexion;

            dtTiposConexion = conectar.Seleccionar("select Id, Descripcion from dbo.MetodosConexion", "BaseDatos");

            return dtTiposConexion;
        }

        //metodo para conectarse por windows Authentication
        //public void conexWinAuthen(string instacia)
        //{
        //    conectar.
        //}

    }
}
