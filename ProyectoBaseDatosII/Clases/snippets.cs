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
            return "ALTER TABLE nombre_tabla\nADD nombre_columna tipo_de_dato; \n \n";
        }

        public string alterDrop()
        {
            return "ALTER TABLE nombre_tabla\nDROP COLUMN nombre_columna; \n \n";
        }

        public string alterAlter()
        {
            return "ALTER TABLE nombre_tabla\nALTER COLUMN nombre_columna tipo_de_dato; \n \n";
        }


    }
}
