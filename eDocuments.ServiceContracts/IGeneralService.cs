using System;
using System.Collections.Generic;

using System.ServiceModel;
using eDocuments.Entities;

namespace eDocuments.ServiceContracts
{
    [ServiceContract]
    public interface IGeneralService
    {
        [OperationContract]
        List<BEArea> ListarArea();

        [OperationContract]
        List<BERol> ListarRol();

        [OperationContract]
        List<BETipoDocumento> ListarTipoDocumento();

        [OperationContract]
        List<BEEstado> ListarEstado();

    }
}
