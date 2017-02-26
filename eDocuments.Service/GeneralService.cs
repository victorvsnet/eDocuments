using System;
using System.Collections.Generic;

using eDocuments.ServiceContracts;
using eDocuments.Entities;
using eDocuments.BusinessLogic;

namespace eDocuments.Service
{
    public class GeneralService : IGeneralService
    {
        public List<BEArea> ListarArea()
        {
            var BLArea = new BLArea();
            return BLArea.ListarArea();
        }

        public List<BEEstado> ListarEstado()
        {
            var BLEstado = new BLEstado();
            return BLEstado.ListarEstado();
        }

        public List<BERol> ListarRol()
        {
            var BLRol = new BLRol();
            return BLRol.ListarRol();
        }

        public List<BETipoDocumento> ListarTipoDocumento()
        {
            var BLTipoDocumento = new BLTipoDocumento();
            return BLTipoDocumento.ListarTipoDocumento();
        }
    }
}
