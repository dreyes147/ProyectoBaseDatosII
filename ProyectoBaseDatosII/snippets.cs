using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseDatosII
{
    public class Snippets
    {
        public string select() {
            return "SELECT columna\nFROM tabla;\n \n";
        }

        public string insert()
        {
            return "INSERT INTO ( columnas )\nVALUES( valores );\n \n";
        }
        public string update()
        {
            return "UPDATE nombre_tabla\nSET columna=valor\nWHERE condicion;\n \n";
        }

        public string delete()
        {
            return "DELETE FROM nombre_tabla\nWHERE condicion;\n \n";
        }

        public string create()
        {
            return "CREATE TABLE nombre_tabla (\n      columna1 tipo_de_dato,\n      columna2 tipo_de_dato,\n      columna3 tipo_de_dato \n); \n";
        }

        public string drop()
        {
            return "DROP TABLE nombre_tabla;\n \n";
        }

        public string alter()
        {
            return "ALTER TABLE nombre_tabla\nADD nombre_columna tipo_de_dato";
        }


    }
}
