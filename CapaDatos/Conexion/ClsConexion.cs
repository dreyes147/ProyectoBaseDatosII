using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos.Conexion
{
    public class ClsConexion
    {
        SqlConnection vConnection;
        SqlCommand vcmd;
        SqlDataAdapter vAdapter;


        public ClsConexion()
        {
        }

        private void AbrirConexion(string pNombreInstancia)
        {
            string vInstancia = string.Empty;
            try
            {
                vInstancia = ConfigurationManager.ConnectionStrings[pNombreInstancia].ConnectionString;
                vConnection = new SqlConnection(vInstancia);
                vConnection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }


        private void CerrarConexion()
        {
            string vInstancia = string.Empty;
            try
            {
                vConnection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public DataTable Seleccionar(string pInstruccion, string pNombreBaseDatos)
        {
            DataTable dtResultado = new DataTable();
            try
            {
                AbrirConexion(pNombreBaseDatos);
                vcmd = new SqlCommand(pInstruccion, vConnection);
                vAdapter = new SqlDataAdapter(vcmd);
                vAdapter.Fill(dtResultado);
                CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtResultado;
        }



        public DataTable Ejecutar(string pInstruccion, string pNombreBaseDatos)
        {
            DataTable dtResultado = new DataTable();
            try
            {
                AbrirConexion(pNombreBaseDatos);
                vcmd = new SqlCommand(pInstruccion, vConnection);
                vcmd.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtResultado;
        }

        
    }
}
