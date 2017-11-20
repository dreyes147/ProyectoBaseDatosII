using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseDatosII
{
    public class Snippets
    {
        CapaNegocios.ClsReportes reportes = new CapaNegocios.ClsReportes();
        public string select() {
            reportes.inserReporte("1","SELECT","DML");
            return "SELECT columna\nFROM tabla;\n \n";
        }

        public string insert()
        {
            reportes.inserReporte("2", "INSERT","DML");
            return "INSERT INTO nombre_tabla(columnas)\nVALUES( valores );\n \n";
        }
        public string update()
        {
            reportes.inserReporte("3", "UPDATE","DML");
            return "UPDATE nombre_tabla\nSET columna=valor\nWHERE condicion;\n \n";
        }

        public string delete()
        {
            reportes.inserReporte("4", "DELETE","DML");
            return "DELETE FROM nombre_tabla\nWHERE condicion;\n \n";
        }

        public string create()
        {
            reportes.inserReporte("5", "CREATE", "DDL");
            return "CREATE TABLE nombre_tabla (\n      columna1 tipo_de_dato\n      ,columna2 tipo_de_dato\n      ,columna3 tipo_de_dato \n); \n \n";
        }

        public string drop()
        {
            reportes.inserReporte("6", "DROP", "DDL");
            return "DROP TABLE nombre_tabla;\n \n";
        }

        public string alter()
        {
            reportes.inserReporte("7", "ALTER ADD", "DDL");
            return "ALTER TABLE nombre_tabla\nADD nombre_columna tipo_de_dato; \n \n";
        }

        public string alterDrop()
        {
            reportes.inserReporte("8", "ALTER DROP", "DDL");
            return "ALTER TABLE nombre_tabla\nDROP COLUMN nombre_columna; \n \n";
        }

        public string alterAlter()
        {
            reportes.inserReporte("9", "ALTER ALTER", "DDL");
            return "ALTER TABLE nombre_tabla\nALTER COLUMN nombre_columna tipo_de_dato; \n \n";
        }

        public string createIndex()
        {
            reportes.inserReporte("10", "CREATE INDEX", "DDL");
            return "CREATE INDEX index_name ON table_name(column1, column2, column3); \n \n";
        }

        public string createUser()
        {
            reportes.inserReporte("11", "CREATE USER", "DDL");
            return "CREATE USER username WITH PASSWORD = '********'; \n \n";
        }

        public string createFunction()
        {
            reportes.inserReporte("12", "CREATE FUNCTION", "DDL");
            return "CREATE FUNCTION [dbo].[FunctionName] \n( \n @parametro1 tipoDeDato, \n @parametro2 tipoDeDato\n)\n RETURNS tipoDeDato\nAS\nBEGIN\n\nRETURN @parametro1 + @parametro2\n\nEND; \n \n";
        }

        public string createProc()
        {
            reportes.inserReporte("13", "CREATE PROC", "DDL");
            return "Create Procedure Procedure-name\n(\nInput parameters,\n)\nAs\nBegin\n\nSentencia a ejecutar\n\nEnd; \n \n";
        }

        public string createDatabase()
        {
            reportes.inserReporte("14", "CREATE DATABASE", "DDL");
            return "CREATE DATABASE database_name; \n \n";
        }
        //---
        public string alterIndex()
        {
            reportes.inserReporte("15", "ALTER INDEX", "DDL");
            return "ALTER INDEX index_name ON table_name(column1, column2, column3); \n \n";
        }

        public string alterUser()
        {
            reportes.inserReporte("16", "ALTER USER", "DDL");
            return "ALTER USER username WITH PASSWORD = '********'; \n \n";
        }

        public string alterFunction()
        {
            reportes.inserReporte("17", "ALTER FUNCTION", "DDL");
            return "ALTER FUNCTION [dbo].[FunctionName] \n( \n @parametro1 tipoDeDato, \n @parametro2 tipoDeDato\n)\n RETURNS tipoDeDato\nAS\nBEGIN\n\nRETURN @parametro1 + @parametro2\n\nEND; \n \n";
        }

        public string alterProc()
        {
            reportes.inserReporte("18", "ALTER PROC", "DDL");
            return "ALTER PROC Procedure-name\n(\nInput parameters,\n)\nAs\nBegin\n\nSentencia a ejecutar\n\nEnd; \n \n";
        }

        //--
        public string dropIndex()
        {
            reportes.inserReporte("19", "DROP INDEX", "DDL");
            return "DROP INDEX function_name;\n \n";
        }

        public string dropUser()
        {
            reportes.inserReporte("20", "DROP USER", "DDL");
            return "DROP USER User_name;\n \n";
        }

        public string dropFunction()
        {
            reportes.inserReporte("21", "DROP FUNCTION", "DDL");
            return "DROP FUNCTION Function_name;\n \n";
        }

        public string dropProc()
        {
            reportes.inserReporte("22", "DROP PROC", "DDL");
            return "DROP PROC Proc_name;\n \n";
        }

        public string dropDatabase()
        {
            reportes.inserReporte("23", "DROP DATABASE", "DDL");
            return "DROP DATABASE database_name;\n \n";
        }
    }
}
