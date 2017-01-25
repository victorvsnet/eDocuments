using System;
using System.Collections.Generic;

using System.ServiceModel;
using eDocuments.Entities;

namespace eDocuments.ServiceContracts
{
    [ServiceContract]
    public interface IUsuarioService
    {
        [OperationContract]
        string SayHello(string name);

        [OperationContract]
        BEUsuario ObtenerUsuarioLogin(string usuario);
    }
}
