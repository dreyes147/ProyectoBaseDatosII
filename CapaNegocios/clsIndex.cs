using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class clsIndex
    {
        public clsIndex() { }

        public DataTable ValidarIndex(string pNombreTabla, string pUser)
        {
            DataTable dtResultado = new DataTable();
            CapaDatos.Clases.clsIndex vConexion = new CapaDatos.Clases.clsIndex();
            try
            {
                dtResultado = vConexion.ValidarIndex(pNombreTabla, pUser);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtResultado;
        }

        public void CrearIndex(DataTable pTablas, DataTable pIndices,  string pUser)
        {
            DataTable dtResultado = new DataTable();
            CapaDatos.Clases.clsIndex vConexion = new CapaDatos.Clases.clsIndex();
            try
            {
               vConexion.CrearIndex(pTablas, pIndices, pUser);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
