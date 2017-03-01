using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDocuments.Models
{
    public class EstadoModel : Auditoria
    {
        public int cod_estado { get; set;}
        public string gls_estado { get; set; }
    }
}