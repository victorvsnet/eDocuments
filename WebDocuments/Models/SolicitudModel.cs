using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDocuments.Models
{
    public class SolicitudModel : Auditoria
    {
        public int cod_solicitud { get; set; }
        public string gls_solicitud { get; set; }
        public int cod_estado { get; set; }
        public int cod_documento { get; set; }
    }
}