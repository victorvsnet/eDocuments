using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDocuments.Models
{
    public class TipoDocumentoModel : Auditoria
    {
        public int cod_tipo_documento { get; set; }
        public string gls_tipo_documento { get; set; }
    }
}