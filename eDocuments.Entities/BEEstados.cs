using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDocuments.Entities
{
    public class BEEstados : Auditoria
    {
        public int cod_estado { get; set; }
        public string gls_estado { get; set; }
    }
}
