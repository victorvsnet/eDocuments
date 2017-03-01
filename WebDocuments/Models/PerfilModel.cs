using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDocuments.Models
{
    public class PerfilModel : Auditoria
    {
        public int cod_perfil { get; set; }
        public string gls_perfil { get; set; }
    }
}