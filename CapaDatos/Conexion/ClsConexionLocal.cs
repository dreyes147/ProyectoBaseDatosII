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
        private SqlConnection oCN = new SqlConnection();

        private void StrWinAutent(string instancia) //string para la conexion con auntentificacion de windows
        {
            oCN = new SqlConnection("Data Source = " + instancia + "; Integrated Security = True");
        }

        private void StrSQLAutent(string instancia, string usuario, string contraseña) //string para la conexion con la autentificacion de SQL
        {
            oCN = new SqlConnection("Data Source=" + instancia + ";Persist Security Info=True;User ID=" + usuario + ";Password=" + contraseña + "");
        }


        private bool AbrirConexion()

        {

            try

            {

                oCN.Open();

                return true;

            }

            catch (Exception)

            {

                return false;

            }



        }

        private bool CerrarConexion()

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



        public DataTable ejecutar(String txtSelect)

        {

            SqlCommand cSelect = new SqlCommand();

            DataTable oDT = new DataTable();

            SqlDataAdapter oMYSQLDA = new SqlDataAdapter(cSelect);

            try

            {

                cSelect.CommandText = txtSelect;

                cSelect.Connection = oCN;

            }

            catch (Exception)

            {

                throw;

            }

            if (AbrirConexion())

            {

                oMYSQLDA.Fill(oDT);

            }

            CerrarConexion();



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

    }

}
