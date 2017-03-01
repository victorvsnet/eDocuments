using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDocuments.Models
{
    public class PerfilDocumentoModel : Auditoria
    {
        public int cod_perfil { get; set; }
        public int cod_documento { get; set; }
    }
}