using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseDatosII.Clases
{
    class Tablas
    {
        #region Declaracion de variables
        private string vNombreTabla;
        private string vAliasTabla;
        private string vNombreCampo;
        private string vTipoIndex;
        #endregion

        #region Declaracion de constructor

        public Tablas() {
            vNombreTabla = string.Empty;
            vAliasTabla = string.Empty;
            vNombreCampo = string.Empty;
            vTipoIndex = string.Empty;
        }
        #endregion

        #region Declaracion de propiedades
        public string NombreTabla {
            get
            {
                return vNombreTabla;
            }
            set
            {
                vNombreTabla = value;
            }
        }
        public string AliasTabla
        {
            get
            {
                return vAliasTabla;
            }
            set
            {
                vAliasTabla = value;
            }
        }
        public string NombreCampo
        {
            get
            {
                return vNombreCampo;
            }
            set
            {
                vNombreCampo = value;
            }
        }
        public string TipoIndex
        {
            get
            {
                return vTipoIndex;
            }
            set
            {
                vTipoIndex = value;
            }
        }
        #endregion
    }
}
