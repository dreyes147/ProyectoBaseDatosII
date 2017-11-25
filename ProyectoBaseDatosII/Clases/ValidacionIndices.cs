using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using gudusoft.gsqlparser;
using System.Data;
using System.ComponentModel;

namespace ProyectoBaseDatosII.Clases
{
    class ValidacionIndices
    {
        #region Delcaración de Variables
        DataSet dsDatos;
        List<Tablas> vTablas;
        List<Tablas> vIndeces;
        #endregion

        public ValidacionIndices()
        {
            vTablas = new List<Tablas>();
            dsDatos = new DataSet();
            vIndeces = new List<Tablas>();
        }

        #region Declaración de Método

        public string ValidarIndice(string pConsulta, string pUser)
        {
            TGSqlParser sqlparser = new TGSqlParser(TDbVendor.DbVMssql);
            string xmlData = string.Empty;
            string vId = string.Empty;
            string vResultado = string.Empty;
            int vContador = 0;
            int vValorAnterior = 0;
            Tablas vCampo;
            List<Tablas> vCampos = new List<Tablas>();
            try
            {

                sqlparser.SqlText.Text = pConsulta;

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
                vResultado = ConsultarIndex(vCampos, pUser);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return vResultado;
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

        private string ConsultarIndex(List<Tablas> pCampos,string pUser)
        {
            CapaNegocios.clsIndex vNegocioIndex = new CapaNegocios.clsIndex();
            DataTable dtIndex = new DataTable();
            List<Tablas> vDatos;
            bool vBandera = false;
            string vResultado = string.Empty;
            bool vIndexCluster = false;
            Tablas vIndex;
            try
            {
                foreach (Tablas vItem in vTablas)
                {
                   
                    dtIndex = vNegocioIndex.ValidarIndex(vItem.NombreTabla, pUser);
                    if (dtIndex.Rows.Count > 0)
                    {
                        vDatos = (from x in pCampos
                                  where x.AliasTabla == vItem.AliasTabla
                                  select x).ToList();
                        if (dtIndex.Select("index_description='clustered located on PRIMARY'").Length > 0)
                        {
                            vIndexCluster = true;
                        }
                        else
                        {
                            vIndexCluster = false;
                        }
                        foreach (Tablas vItems in vDatos)
                        {
                            foreach (DataRow vRow in dtIndex.Rows)
                            {
                                foreach (string vNombreCol in vRow["index_Keys"].ToString().Split(Convert.ToChar(",")))
                                {
                                    if (vItems.NombreCampo.ToUpper() == vNombreCol.ToUpper())
                                    {
                                        vBandera = true;
                                    }
                                }
                            }
                            if (!vBandera)
                            {
                                vResultado += " El campo " + vItems.NombreCampo + " de la tabla " + vItem.NombreTabla +
                                    "no está contenido en ningún índice\n";

                                vIndex = new Tablas();
                                vIndex.NombreTabla = vItem.NombreTabla;
                                vIndex.NombreCampo = vItems.NombreCampo;
                                if (vIndexCluster)
                                {
                                    vIndex.TipoIndex = "NC";
                                }
                                else
                                {
                                    vIndex.TipoIndex = "C";
                                }
                                vIndeces.Add(vIndex);
                            }
                            vBandera = false;
                        } 
                    }
                    else
                    {
                        vResultado += "La tabla " + vItem.NombreTabla + " no contiene un índice\n";
                        vDatos = (from x in pCampos
                                  where x.AliasTabla == vItem.AliasTabla
                                  select x).ToList();

                        foreach (Tablas vItems in vDatos)
                        {
                            vIndex = new Tablas()
                            {
                                NombreTabla = vItem.NombreTabla,
                                NombreCampo = vItems.NombreCampo,
                                TipoIndex = "C"
                            };
                            vIndeces.Add(vIndex);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return vResultado;
        }

        public void CrearIndex(string pUser)
        {
            DataTable dtTablas = new DataTable();
            DataTable dtIndex = new DataTable();
            CapaNegocios.clsIndex vNegocios = new CapaNegocios.clsIndex();
            try
            {
                dtTablas = ConvertToDataTable(vTablas);
                dtIndex = ConvertToDataTable(vIndeces);
                vNegocios.CrearIndex(dtTablas, dtIndex, pUser);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message,ex);
            }
        }

        private DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        #endregion
    }
}
