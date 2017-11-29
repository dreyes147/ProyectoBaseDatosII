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

                //sql = "   DECLARE @id INT,";
                //sql = sql + "      @count INT,";
                //sql = sql + "      @vBaseDatos VARCHAR(50),";
                //sql = sql + "      @vQuery NVARCHAR(1024),";
                //sql = sql + "      @vParametros NVARCHAR(255),";
                //sql = sql + "      @vValorParametro VARCHAR(1),";
                //sql = sql + "      @vContador INT,";
                //sql = sql + "      @vCodigoPadre INT,";
                //sql = sql + "      @vCantidadTablas INT,";
                //sql = sql + "      @vNombreTabla VARCHAR(50)";
                //sql = sql + " DECLARE @vDatos TABLE(Codigo INT IDENTITY(1, 1),";
                //sql = sql + "                        CodigoPadre INT,";
                //sql = sql + "                       Descripcion VARCHAR(50))";
                //sql = sql + " DECLARE @vTablas TABLE(Codigo INT,";
                //sql = sql + "                       CodigoPadre INT,";
                //sql = sql + "                       Descripcion VARCHAR(50))";
                //sql = sql + " DECLARE @vColumnas TABLE(CodigoPadre INT,";
                //sql = sql + "                            Tabla VARCHAR(50),";
                //sql = sql + "                            Columna VARCHAR(50))";
                //sql = sql + " SET @vContador = 1";
                //sql = sql + " SET @id = 1";
                //sql = sql + " SET @vQuery = ''";
                //sql = sql + " SET @vParametros = '@vTipo VARCHAR(1)'";
                //sql = sql + " SET @vValorParametro = 'U'";
                //sql = sql + " SELECT @count = COUNT(1) FROM sys.databases WHERE database_id >= 5";
                //sql = sql + " WHILE @id<= @count";
                //sql = sql + " BEGIN";
                //sql = sql + "    SELECT @vBaseDatos = name";
                //sql = sql + "    FROM(SELECT  name, RANK()OVER(ORDER BY name ASC)AS RANK FROM sys.databases  WHERE database_id >= 5)  TBS";
                //sql = sql + "    WHERE RANK = @id";
                //sql = sql + "    INSERT INTO  @vDatos(CodigoPadre, Descripcion)";
                //sql = sql + "    VALUES(0, @vBaseDatos)";
                //sql = sql + "    SET @vQuery = 'SELECT ' + CONVERT(VARCHAR(100),@@IDENTITY) + ', name FROM ' + @vBaseDatos + '.sys.objects WHERE type = @vTipo'";
                //sql = sql + "    INSERT INTO  @vDatos(CodigoPadre, Descripcion)";
                //sql = sql + "    EXEC sp_executesql @vQuery, @vParametros, @vValorParametro";
                //sql = sql + "    INSERT INTO @vTablas(Codigo, CodigoPadre, Descripcion)";
                //sql = sql + "                    select Codigo, CodigoPadre, Descripcion from @vDatos where CodigoPadre <> 0";
                //sql = sql + "       SELECT @vCantidadTablas = COUNT(1) FROM @vTablas";
                //sql = sql + "           WHILE @vContador<= @vCantidadTablas";
                //sql = sql + "               BEGIN";
                //sql = sql + "                   DELETE @vColumnas";
                //sql = sql + "                   SELECT @vNombreTabla = Descripcion,@vCodigoPadre = Codigo";
                //sql = sql + "                   FROM(SELECT  Descripcion, Codigo, RANK()OVER(ORDER BY Descripcion ASC)AS RANK FROM @vTablas)  TBS";
                //sql = sql + "                  WHERE RANK = @vContador";
                //sql = sql + "                   SET @vQuery = 'SELECT' + char(39) + CONVERT(VARCHAR(20), @vCodigoPadre) + Char(39) + ', TABLE_NAME, COLUMN_NAME FROM ' + @vBaseDatos + '.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = ' + CHAR(39) + @vNombreTabla + CHAR(39)";
                //sql = sql + "                   INSERT INTO @vColumnas";
                //sql = sql + "                   EXEC(@vQuery)";
                //sql = sql + "                   INSERT INTO @vDatos(CodigoPadre, Descripcion)";
                //sql = sql + "                   SELECT A.CodigoPadre,";
                //sql = sql + "   						A.Columna";
                //sql = sql + "                   FROM    @vColumnas A";
                //sql = sql + "                  SET @vContador += 1";
                //sql = sql + "            END";
                //sql = sql + "     SET @id = @id + 1";
                //sql = sql + "  END";
                //sql = sql + "  SELECT  Codigo,";
                //sql = sql + "  		CodigoPadre,";
                //sql = sql + "  		Descripcion";
                //sql = sql + "  FROM @vDatos";








                //sql = " DECLARE @id INT,";
                //sql = sql + "       @count INT,";
                //sql = sql + "       @vBaseDatos VARCHAR(50),";
                //sql = sql + "       @vQuery NVARCHAR(1024),";
                //sql = sql + "       @vParametros NVARCHAR(255),";
                //sql = sql + "       @vValorParametro VARCHAR(1),";
                //sql = sql + "       @vContador INT,";
                //sql = sql + "       @vCantidadTablas INT,";
                //sql = sql + "       @vNombreTabla VARCHAR(50)";
                //sql = sql + " DECLARE @vDatos TABLE(Codigo INT IDENTITY(1, 1),";
                //sql = sql + "                         CodigoPadre INT,";
                //sql = sql + "                        Descripcion VARCHAR(50))";
                //sql = sql + " DECLARE @vTablas TABLE(CodigoPadre INT,";
                //sql = sql + "                         Descripcion VARCHAR(50))";
                //sql = sql + " DECLARE @vColumnas TABLE(Tabla VARCHAR(50),";
                //sql = sql + "                         Columna VARCHAR(50))";
                //sql = sql + " SET @vContador = 1";
                //sql = sql + " SET @id = 1";
                //sql = sql + " SET @vQuery = ''";
                //sql = sql + " SET @vParametros = '@vTipo VARCHAR(1)'";
                //sql = sql + " SET @vValorParametro = 'U'";
                //sql = sql + " SELECT @count = COUNT(1) FROM sys.databases WHERE database_id >= 5";
                //sql = sql + " WHILE @id<= @count";
                //sql = sql + " BEGIN";
                //sql = sql + "     SELECT @vBaseDatos = name";
                //sql = sql + "     FROM(SELECT  name, RANK()OVER(ORDER BY name ASC)AS RANK FROM sys.databases  WHERE database_id >= 5)  TBS";
                //sql = sql + "     WHERE RANK = @id";
                //sql = sql + "     INSERT INTO  @vDatos(CodigoPadre, Descripcion)";
                //sql = sql + "     VALUES(0, @vBaseDatos)";
                //sql = sql + "     SET @vQuery = 'SELECT ' + CONVERT(VARCHAR(100),@@IDENTITY) + ', name FROM ' + @vBaseDatos + '.sys.objects WHERE type = @vTipo'";
                //sql = sql + "     INSERT INTO  @vDatos(CodigoPadre, Descripcion)";
                //sql = sql + "     EXEC sp_executesql @vQuery, @vParametros, @vValorParametro";
                //sql = sql + "     INSERT INTO @vTablas(CodigoPadre, Descripcion)";
                //sql = sql + "     EXEC sp_executesql @vQuery, @vParametros, @vValorParametro";
                //sql = sql + "     SELECT @vCantidadTablas = COUNT(1) FROM @vTablas";
                //sql = sql + "         WHILE @vContador<= @vCantidadTablas";
                //sql = sql + "             BEGIN";
                //sql = sql + "                 DELETE @vColumnas";
                //sql = sql + "                 SELECT @vNombreTabla = Descripcion";
                //sql = sql + "                 FROM(SELECT  Descripcion, RANK()OVER(ORDER BY Descripcion ASC)AS RANK FROM @vTablas)  TBS";
                //sql = sql + "                WHERE RANK = @vContador";
                //sql = sql + "                 SET @vQuery = 'SELECT TABLE_NAME, COLUMN_NAME FROM ' + @vBaseDatos + '.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = ' + CHAR(39) + @vNombreTabla + CHAR(39)";
                //sql = sql + "                 INSERT INTO @vColumnas";
                //sql = sql + "                 EXEC(@vQuery)";
                //sql = sql + "                 INSERT INTO @vDatos(CodigoPadre, Descripcion)";
                //sql = sql + "                 SELECT B.Codigo,";
                //sql = sql + " 						A.Columna";
                //sql = sql + "                 FROM    @vColumnas A";
                //sql = sql + "                         INNER JOIN @vDatos B ON";
                //sql = sql + "                         A.Tabla = B.Descripcion";
                //sql = sql + "                 SET @vContador += 1";
                //sql = sql + "             END";
                //sql = sql + "     SET @id = @id + 1";
                //sql = sql + " END";
                //sql = sql + " SELECT  Codigo,";
                //sql = sql + " 		CodigoPadre,";
                //sql = sql + " 		Descripcion";
                //sql = sql + " FROM @vDatos";

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
