using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDocuments.Models
{
    public class PropietarioModel : Auditoria
    {
        public int cod_propietario { get; set; }
        public string gls_propietario { get; set; }
    }
}