using System;
using System.Collections.Generic;

using eDocuments.ServiceContracts;
using eDocuments.Entities;
using eDocuments.BusinessLogic;

namespace eDocuments.Service
{
    public class DocumentoService : IDocumentoService
    {
        public List<BEDocumento> Listar()
        {
            return new List<BEDocumento>();
        }
    }
}
