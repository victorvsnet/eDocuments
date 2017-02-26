
using System;
using System.Collections.Generic;

using eDocuments.Entities;
using eDocuments.DataAccess;

namespace eDocuments.BusinessLogic
{
    public class BLTipoDocumento
    {
        public List<BETipoDocumento> ListarTipoDocumento()
        {
            return new DATipoDocumento().ListarTipoDocumento();
        }
    }
}
