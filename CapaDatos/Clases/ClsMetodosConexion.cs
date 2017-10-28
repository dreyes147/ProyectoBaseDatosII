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
        Conexion.ClsConexion conectar = new Conexion.ClsConexion();
        public DataTable cargarCboTipoConexion()
        {
            DataTable dtTiposConexion;

            dtTiposConexion = conectar.Seleccionar("select Id, Descripcion from MetodosConexion;", "BASEDATOS");

            return dtTiposConexion;
        }
    }
}
