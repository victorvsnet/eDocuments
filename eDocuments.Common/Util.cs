using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDocuments.Common
{
    public static class Util
    {
        /// <summary>
        /// Obtiene la cadena de conexion de base de datos configurada en el archivo Web.config del App Web
        /// </summary>
        /// <returns>Cadena de Conexion</returns>
        public static string getConnection()
        {
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
    }
}
