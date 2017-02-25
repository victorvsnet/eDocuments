using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDocuments.BusinessEntity
{
    public abstract class Auditoria
    {
        public int cod_estado_registro { get; set; }
        public string aud_usr_ingreso { get; set; }
        public DateTime aud_fec_ingreso { get; set; }
        public string aud_usr_modificacion { get; set; }
        public DateTime aud_fec_modificacion { get; set; }
    }
}
