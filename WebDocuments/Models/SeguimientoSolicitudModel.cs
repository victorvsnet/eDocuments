using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDocuments.Models
{
    public class SeguimientoSolicitudModel : Auditoria
    {
        public int cod_seguimiento { get; set; }
        public int cod_solicitud { get; set; }
        public int cod_estado { get; set; }
        public string gls_observacion { get; set; }
    }
}