using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDocuments.Models
{
    public class RolModel : Auditoria
    {
        public int cod_rol { get; set; }
        public string gls_rol { get; set; }
    }
}