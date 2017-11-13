using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CapaDatos.Conexion
{

    public class ClsConexionLocal
    {
        //Variables Globales
        public static string query { get; set; }
        public static string nonquery { get; set; }
        public static DataTable Datos { get; set; }
        public static string errorDatos { get; set; }

        public static SqlConnection oCN { get; set; }

        public void StrWinAutent(string instancia) //string para la conexion con auntentificacion de windows
        {
            oCN = new SqlConnection("Data Source = " + instancia + ";Initial Catalog=master; Integrated Security = True");
        }

        public void StrSQLAutent(string instancia, string usuario, string contraseña) //string para la conexion con la autentificacion de SQL
        {
            oCN = new SqlConnection("Data Source=" + instancia + ";Initial Catalog=master; Persist Security Info=True;User ID=" + usuario + ";Password=" + contraseña );
        }

        public bool AbrirConexion()
        {
            try
            {
                oCN.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message, ex);
            }
        }

        public bool CerrarConexion()
        {
            try
            {
                if (oCN.State == ConnectionState.Closed)
                {
                    return true;
                }
                oCN.Close();
                return true;
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                oCN.Close();
            }
        }


        public DataTable ejecutar(String pSelect)
        {
            SqlCommand cSelect = new SqlCommand();
            DataTable oDT = new DataTable();
            SqlDataAdapter oMYSQLDA = new SqlDataAdapter(cSelect);

            try
            {
                cSelect.CommandText = pSelect;
                cSelect.Connection = oCN;

                if (AbrirConexion())
                {
                    oMYSQLDA.Fill(oDT);
                }
                CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message,ex);
            }
            return oDT;
        }

        public bool ejecutarInsert(String txtInsert)

        {

            SqlCommand cInsert = new SqlCommand(txtInsert);

            try

            {

                cInsert.Connection = oCN;

                cInsert.CommandType = CommandType.Text;

                if (AbrirConexion())

                {

                    cInsert.ExecuteNonQuery();

                }

                CerrarConexion();

                return true;

            }

            catch (Exception e)

            {

                throw e;

            }

        }

        public void Abrir()
        {
            try
            {
                oCN.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Cerrar()
        {
            try
            {
                if (oCN.State != ConnectionState.Closed)
                {
                    oCN.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public bool ejecutarDatos()
        {
            SqlDataAdapter vAdapter;
            
            try
            {
                if (AbrirConexion() == true)
                {
                    SqlCommand command = new SqlCommand(query, oCN);
                    command.CommandType = System.Data.CommandType.Text;
                    //Datos = command.ExecuteReader();
                    vAdapter = new SqlDataAdapter(command);
                    Datos = new DataTable();
                    vAdapter.Fill(Datos);
                    CerrarConexion();
                    return true;
                }
                else {
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                CerrarConexion();
                errorDatos = ex.Message;
                return false;
            }

        }

    }

}
