using System;
using System.Collections.Generic;

using System.ServiceModel;
using eDocuments.Entities;

namespace eDocuments.ServiceContracts
{
    [ServiceContract]
    public interface IPropietarioService
    {
        [OperationContract]
        List<BEPropietario> Listar();
    }
}
