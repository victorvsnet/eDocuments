﻿using System;
using System.Collections.Generic;

using System.ServiceModel;
using eDocuments.Entities;

namespace eDocuments.ServiceContracts
{
    [ServiceContract]
    public interface IDocumentoService
    {
        #region Carpetas
        [OperationContract]
        int RegistrarCarpeta(BECarpeta oParametro);

        [OperationContract]
        int EliminarCarpeta(BECarpeta oParametro);

        [OperationContract]
        bool ModificarCarpeta(BECarpeta oParametro);

        [OperationContract]
        bool ModificarCarpetaGestion(BECarpeta oParametro);

        [OperationContract]
        BECarpeta ObtenerCarpeta(int cod_carpeta);

        #endregion

        #region Documentos
        List<BECarpeta> ListarCarpeta();

        [OperationContract]
        int RegistrarDocumento(BEDocumento oParametro);

        [OperationContract]
        bool ModificarDocumento(BEDocumento oParametro);

        [OperationContract]
        bool ModificarNombreArchivo(int codigo, string descripcionDocumento, string nombreArchivo, DateTime fechaVigencia, string usuarioModificacion);

        [OperationContract]
        BEDocumento ObtenerDocumento(int cod_documento);

        [OperationContract]
        BEDocumento ObtenerDocumentoDownload(int cod_documento);

        [OperationContract]
        List<BEDocumento> ListarDocumento(BEDocumento oBusqueda);

        [OperationContract]
        List<BEDocumento> ListarDocumentoPorCarpeta(int cod_carpeta);

        [OperationContract]
        List<BEDocumento> ListarDocumentoPorCarpetaSegunUsuario(int cod_carpeta, string cod_usuario);

        [OperationContract]
        List<BEDocumento> ListarDocumentoPorUsuario(string cod_usuario);

        [OperationContract]
        string GetNombreArchivo(int cod_documento);

        [OperationContract]
        bool EliminarDocumento(int cod_documento, string cod_usuario);

        #endregion

    }
}
