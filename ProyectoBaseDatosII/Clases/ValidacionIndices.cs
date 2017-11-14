using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using gudusoft.gsqlparser;
using System.Data;

namespace ProyectoBaseDatosII.Clases
{
    class ValidacionIndices
    {
        #region Delcaración de Variables
        DataSet dsDatos;
        List<Tablas> vTablas;
        #endregion

        public ValidacionIndices()
        {
            vTablas = new List<Tablas>();
            dsDatos = new DataSet();
        }

        #region Declaración de Método

        public Boolean ValidarIndice(string pConsulta)
        {
            TGSqlParser sqlparser = new TGSqlParser(TDbVendor.DbVMssql);
            string xmlData = string.Empty;
            string vId = string.Empty;
            int vContador = 0;
            int vValorAnterior = 0;
            Tablas vCampo;
            List<Tablas> vCampos = new List<Tablas>();
            try
            {

                sqlparser.SqlText.Text = "SELECT *,a.hola FROM Customers c inner join hola a on a.sd=c.sd WHERE c.CustomerName='foo' and a.sd=1";

                Console.ReadLine();
                int result = sqlparser.Parse();
                xmlData = sqlparser.XmlText;
                System.IO.StringReader xmlSR = new System.IO.StringReader(xmlData);
                dsDatos.ReadXml(xmlSR);
                foreach (DataRow vRow in dsDatos.Tables["attr"].Select("expression_Id>=0"))
                {
                    if (vContador != 0)
                    {
                        if (vValorAnterior != Convert.ToInt32(vRow["expression_Id"].ToString()))
                        {
                            vId = vId + vRow["attr_Id"].ToString() + ",";
                            if (vContador == 1)
                            {
                                vId = vId + vRow["attr_Id"].ToString() + ",";
                            }
                        }
                    }
                    else if (dsDatos.Tables["attr"].Select("expression_Id>=0").Length == 1)
                    {
                        vId = vId + vRow["attr_Id"].ToString() + ",";
                    }

                    vValorAnterior = Convert.ToInt32(vRow["expression_Id"].ToString());
                    vContador++;
                }
                vContador = 0;
                vId = vId.TrimEnd(Convert.ToChar(","));
                foreach (string vItem in vId.Split(Convert.ToChar(",")))
                {
                    vCampo = new Tablas();

                    foreach (DataRow vRow in dsDatos.Tables["sourcetoken"].Select("attr_Id = " + vItem))
                    {
                        if (vRow["dbobjtype"].ToString() == "field" || vRow["dbobjtype"].ToString() == "table alias")
                        {
                            if (vRow["dbobjtype"].ToString() == "field")
                            {
                                vCampo.NombreCampo = vRow["sourcetoken_Text"].ToString();
                            }
                            else
                            {
                                vCampo.AliasTabla = vRow["sourcetoken_Text"].ToString();
                            }
                        }
                    }
                    vCampos.Add(vCampo);
                }
                ExtraerTablas();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }

        private void ExtraerTablas()
        {
            string vId = string.Empty;
            int vContador = 0;
            Tablas vTabla;

            try
            {
                foreach (DataRow vRow in dsDatos.Tables["attr"].Select("simpletable_Id>=0"))
                {
                    vId = vId + vRow["attr_Id"].ToString() + ",";
                }
                vId = vId.TrimEnd(Convert.ToChar(","));

                foreach (string vItem in vId.Split(Convert.ToChar(",")))
                {
                    vTabla = new Tablas();

                    foreach (DataRow vRow in dsDatos.Tables["sourcetoken"].Select("attr_Id = " + vItem + " or aliasclause_Id =" + vContador.ToString()))
                    {
                        if (vRow["dbobjtype"].ToString() == "table" || vRow["dbobjtype"].ToString() == "table alias")
                        {
                            if (vRow["dbobjtype"].ToString() == "table")
                            {
                                vTabla.NombreTabla = vRow["sourcetoken_Text"].ToString();
                            }
                            else
                            {
                                vTabla.AliasTabla = vRow["sourcetoken_Text"].ToString();
                            }
                        }
                    }
                    vTablas.Add(vTabla);
                    vContador++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
