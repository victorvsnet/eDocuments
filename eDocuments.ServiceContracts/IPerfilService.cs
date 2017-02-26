using System;
using System.Collections.Generic;

using System.ServiceModel;
using eDocuments.Entities;

namespace eDocuments.ServiceContracts
{
    [ServiceContract]
    public interface IPerfilService
    {
        #region Perfil
        [OperationContract]
        List<BEPerfil> ListarPerfil();

        [OperationContract]
        int Registrar(BEPerfil oParametro);

        [OperationContract]
        int Actualizar(BEPerfil oParametro);

        [OperationContract]
        int Eliminar(BEPerfil oParametro);

        [OperationContract]
        List<BEPerfil> GetPerfilesSinAsignar(string id);

        [OperationContract]
        List<BEPerfil> GetPerfilesAsignados(string id);

        [OperationContract]
        List<BEPerfil> GetPerfilesSinAsignarDoc(int id);

        [OperationContract]
        List<BEPerfil> GetPerfilesAsignadosDoc(int id);

        #endregion

        #region Perfil Documento

        [OperationContract]
        int RegistrarPerfilDocumento(BEPerfilDocumento oParametro);

        [OperationContract]
        int EliminarPerfilDocumento(BEPerfilDocumento oParametro);

        #endregion

        #region Perfil Usuario

        [OperationContract]
        List<BEPerfilUsuario> ListarPerfilUsuario(string cod_usuario);

        [OperationContract]
        int RegistrarPerfilUsuario(BEPerfilUsuario oParametro);

        [OperationContract]
        int EliminarPerfilUsuario(BEPerfilUsuario oParametro);

        #endregion
    }
}
