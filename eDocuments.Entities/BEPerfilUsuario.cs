using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDocuments.Entities
{
    /// <summary>
    /// Asociacion Perfil Documento
    /// </summary>
    public class BEPerfilUsuario : Auditoria
    {
        public string cod_usuario { get; set; }
        public int cod_perfil { get; set; }
        public string gls_perfil { get; set; }
    }
}
