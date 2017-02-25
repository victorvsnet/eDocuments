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
        BEUsuario ObtenerUsuarioLogin(string usuario);

        [OperationContract]
        List<BEUsuario> ListarUsuarios(string usuario);

        [OperationContract]
        int Actualizar(BEUsuario oParametro);

        [OperationContract]
        int Eliminar(BEUsuario oParametro);

        /*prueba*/
        [OperationContract]
        int Registrar(BEUsuario oParametro);
        
    }
}
