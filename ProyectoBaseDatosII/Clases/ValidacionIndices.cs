using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using gudusoft.gsqlparser;


namespace ProyectoBaseDatosII.Clases
{
    class ValidacionIndices
    {
        #region Delcaración de Variables

        #endregion

        #region Declaración de Método

        public Boolean ValidarIndice(string pConsulta) {

            TGSqlParser sqlparser = new TGSqlParser(TDbVendor.DbVMssql);
            try
            {
                
                sqlparser.SqlText.Text = "SELECT * FROM Customers c INNER JOIN Addresses a ON a.id = c.id WHERE c.CustomerName='foo'";
                sqlparser.OnTableToken += new TOnTableTokenEvent(OnTableTokenHandler);

                int result = sqlparser.Parse();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;


            void OnTableTokenHandler(object o, gudusoft.gsqlparser.TSourceToken st, gudusoft.gsqlparser.TCustomSqlStatement stmt)
            {
                if ((st.DBObjType == TDBObjType.ttObjTable))
                {
                    Console.WriteLine("Table: {0}", st.AsText);
                }
            }
        }


        //public string ValidarIndice(string pConsulta)
        //{
        //    string vConsulta = pConsulta;
        //    string vMensaje = string.Empty;
        //    string vSelect;
        //    string vFrom;
        //    string[] vSelects;
        //    string[] vTablasCampos;
        //    TGSqlParser sqlparser = new TGSqlParser(EDbVendor.dbvmssql);
        //    try
        //    {
        //        if (!vConsulta.ToUpper().Contains("CREATE"))
        //        {
        //            if (!vConsulta.ToUpper().Contains("DROP"))
        //            {
        //                if (!vConsulta.ToUpper().Contains("DELETE"))
        //                {
        //                    if (!vConsulta.ToUpper().Contains("UPDATE"))
        //                    {
        //                        if (vConsulta.ToUpper().Contains("SELECT"))
        //                        {
        //                            vConsulta = vConsulta.Replace("Select", "SELECT");
        //                            vConsulta = vConsulta.Replace("select", "SELECT");
        //                            vSelects = vConsulta.Split(Convert.ToChar("SELECT"));
        //                            foreach (string vItem in vSelects)
        //                            {
        //                                vSelect = string.Empty;
        //                                vSelect = vItem;
        //                                vSelect = vSelect.Replace("From", "FROM");
        //                                vSelect = vSelect.Replace("from", "FROM");
        //                                vTablasCampos = vSelect.Split(Convert.ToChar("FROM"));


        //                                if (vTablasCampos[1].ToUpper().Contains("JOIN"))
        //                                {

        //                                }
        //                                else
        //                                {

        //                                }

        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    return vMensaje;
        //}

        #endregion
    }
}
