using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Clases
{
    public class ClsTreeView
    {
        public DataTable DatosTreeview()
        {
            DataTable vResultado = new DataTable();
            string sql = "";
            try
            {
                sql = "DECLARE @id INT,";
                sql = sql + " @count INT,";
                sql = sql + " @vBaseDatos VARCHAR(50),";
                sql = sql + " @vQuery NVARCHAR(1024),";
                sql = sql + " @vParametros NVARCHAR(255),";
                sql = sql + " @vValorParametro VARCHAR(1)";
                sql = sql + " DECLARE @vDatos TABLE( Codigo INT,";
                sql = sql + "                        CodigoPadre INT,";
                sql = sql + "                        Descripcion VARCHAR(50))";
                sql = sql + " SET @id=1";
                sql = sql + " SET @vQuery = ''";
                sql = sql + " SET @vParametros = '@vTipo VARCHAR(1)'";
                sql = sql + " SET @vValorParametro= 'U'";
                sql = sql + " SELECT @count = COUNT(1) FROM sys.databases WHERE database_id >=5";
                sql = sql + " WHILE @id<=@count";
                sql = sql + " BEGIN";
                sql = sql + " SELECT @vBaseDatos = name ";
                sql = sql + " FROM (SELECT  name,RANK()OVER (ORDER BY name ASC)AS RANK FROM sys.databases  WHERE database_id >=5)  TBS ";
                sql = sql + " WHERE RANK=@id";
                sql = sql + " INSERT INTO  @vDatos(Codigo,CodigoPadre,Descripcion)";
                sql = sql + " VALUES (@id,0,@vBaseDatos)";
                sql = sql + " SET  @vQuery = 'SELECT 0, ' + CONVERT(VARCHAR(1000),@id) + ', name FROM ' + @vBaseDatos + '.sys.objects WHERE type = @vTipo' ";
                sql = sql + " INSERT INTO  @vDatos(Codigo,CodigoPadre,Descripcion)";
                sql = sql + " EXEC sp_executesql @vQuery, @vParametros, @vValorParametro";
                sql = sql + " SET @id=@id+1";
                sql = sql + " END";
                sql = sql + " SELECT Codigo,";
                sql = sql + "		 CodigoPadre,";
                sql = sql + "        Descripcion";
                sql = sql + " FROM @vDatos";
                Conexion.ClsConexionLocal vConexion = new Conexion.ClsConexionLocal();
                vResultado = vConexion.ejecutar(sql);
                return vResultado;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex); 
            }
        }
    }
}
