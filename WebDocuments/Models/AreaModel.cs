using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDocuments.Models
{
    public class AreaModel : Auditoria
    {
        public int cod_area { get; set; }
        public string gls_area { get; set; }
    }
}