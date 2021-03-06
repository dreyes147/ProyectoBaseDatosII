﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    public class clsIndex
    {
        public clsIndex() {
        }

        public DataTable ValidarIndex(string pNombreTabla, string pUser)
        {            
            DataTable dtResultado = new DataTable();
            string vSql = string.Empty;
            Conexion.ClsConexionLocal vConexion = new Conexion.ClsConexionLocal();
            try
            {
                vSql = pUser + " Exec sp_helpindex '"+ pNombreTabla+"'";
                dtResultado = vConexion.ejecutar(vSql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message,ex);
            }
            return dtResultado; 
        }

        public void CrearIndex(DataTable pTablas, DataTable pIndices, string pUser)
        {
            ClsReportes ClsRepo = new ClsReportes();
            DataTable dtResultado = new DataTable();
            string vSql = string.Empty;
            Conexion.ClsConexionLocal vConexion = new Conexion.ClsConexionLocal();
            int vContador = 0;
            DateTime vFecha;
            string vNomTabla;
            try
            {
                foreach (DataRow vRows in pTablas.Rows)
                {
                    vSql = string.Empty;
                    foreach (DataRow vRow in pIndices.Select("NombreTabla = '" + vRows["NombreTabla"].ToString() + "'"))
                    {
                        if (vContador == 0)
                        {
                            vFecha = DateTime.Now;
                            if (vRow["TipoIndex"].ToString() == "C")
                            {
                                vSql += "CREATE CLUSTERED INDEX [ClusteredIndex" + String.Format("{0:ddMMyyyyHH:mm:ss.ff}", vFecha) + "] ON dbo." + vRow["NombreTabla"].ToString() + " (";
                                //Variable aqui
                                vNomTabla = vRow["NombreTabla"].ToString();
                            }
                            else
                            {
                                vSql += "CREATE NONCLUSTERED INDEX [noClusteredIndex" + String.Format("{0:ddMMyyyyHH:mm:ss.ff}", vFecha) + "] ON dbo." + vRow["NombreTabla"].ToString() + " (";
                                //Variable aqui
                                vNomTabla = vRow["NombreTabla"].ToString();
                            }
                            ClsRepo.repoIndices(vNomTabla);
                        }
                        vSql += vRow["NombreCampo"].ToString() + ",";
                        vContador++;
                    }
                    vContador = 0;
                    vSql = vSql.TrimEnd(Convert.ToChar(","));
                    vSql += ")";
                    vConexion.ejecutarInsert(pUser + " " + vSql);
                }                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }        
        }
    }
}
