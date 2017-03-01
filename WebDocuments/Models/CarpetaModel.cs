using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDocuments.Models
{
    public class CarpetaModel : Auditoria
    {
        public int cod_carpeta { get; set; }
        public int cod_carpeta_padre { get; set; }
        public string gls_ruta_carpeta { get; set; }
    }
}