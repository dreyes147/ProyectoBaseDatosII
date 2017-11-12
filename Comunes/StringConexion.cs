using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes
{
    public class StringConexion
    {
        #region Declaracion de Variables
        private static string vStringConexion { get; set; }
        #endregion

        #region Declaracion de Constructor
        public StringConexion(string pConexion)
        {
            vStringConexion = pConexion;
        }
        #endregion
    }
}
