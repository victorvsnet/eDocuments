using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDocuments.Entities
{
    /// <summary>
    /// Propiedad de los documentos agregados al sistema.
    /// </summary>
    public class BEDocumento : Auditoria
    {
        public int cod_documento { get; set; }
        public string gls_nombre_documento { get; set; }
        public string gls_nombre_archivo { get; set; }
        public int cod_carpeta { get; set; }
        public int cod_tipo_documento { get; set; }
        public string gls_tipo_documento { get; set; }
        public int cod_propietario { get; set; }
        public string gls_propietario { get; set; }
        public DateTime fec_vigencia { get; set; }
        public string gls_ruta_carpeta { get; set; }
        public int cod_perfil { get; set; }
        public string gls_perfil { get; set; }
        public string cod_usuario { get; set; }
    }
}
