using System;
using System.Collections.Generic;

using eDocuments.ServiceContracts;
using eDocuments.Entities;
using eDocuments.BusinessLogic;

namespace eDocuments.Service
{
    public class DocumentoService : IDocumentoService
    {
        #region Carpeta
        public int EliminarCarpeta(BECarpeta oParametro)
        {
            var BLCarpeta = new BLCarpeta();
            return BLCarpeta.EliminarCarpeta(oParametro);
        }

        public List<BECarpeta> ListarCarpeta()
        {
            var BLCarpeta = new BLCarpeta();
            return BLCarpeta.ListarCarpeta();
        }

        public bool ModificarCarpeta(BECarpeta oParametro)
        {
            var BLCarpeta = new BLCarpeta();
            return BLCarpeta.ModificarCarpeta(oParametro);
        }

        public bool ModificarCarpetaGestion(BECarpeta oParametro)
        {
            var BLCarpeta = new BLCarpeta();
            return BLCarpeta.ModificarCarpetaGestion(oParametro);
        }

        public BECarpeta ObtenerCarpeta(int cod_carpeta)
        {
            var BLCarpeta = new BLCarpeta();
            return BLCarpeta.ObtenerCarpeta(cod_carpeta);
        }

        public int RegistrarCarpeta(BECarpeta oParametro)
        {
            var BLCarpeta = new BLCarpeta();
            return BLCarpeta.RegistrarCarpeta(oParametro);
        }

        #endregion

        #region Documento

        public bool EliminarDocumento(int cod_documento, string cod_usuario)
        {
            var BLDocumento = new BLDocumento();
            return BLDocumento.EliminarDocumento(cod_documento, cod_usuario);
        }

        public string GetNombreArchivo(int cod_documento)
        {
            var BLDocumento = new BLDocumento();
            return BLDocumento.GetNombreArchivo(cod_documento);
        }

        public List<BEDocumento> ListarDocumento(BEDocumento oBusqueda)
        {
            var BLDocumento = new BLDocumento();
            return BLDocumento.ListarDocumento(oBusqueda);
        }

        public List<BEDocumento> ListarDocumentoPorCarpeta(int cod_carpeta)
        {
            var BLDocumento = new BLDocumento();
            return BLDocumento.ListarDocumentoPorCarpeta(cod_carpeta);
        }

        public List<BEDocumento> ListarDocumentoPorCarpetaSegunUsuario(int cod_carpeta, string cod_usuario)
        {
            var BLDocumento = new BLDocumento();
            return BLDocumento.ListarDocumentoPorCarpetaSegunUsuario(cod_carpeta, cod_usuario);
        }

        public List<BEDocumento> ListarDocumentoPorUsuario(string cod_usuario)
        {
            var BLDocumento = new BLDocumento();
            return BLDocumento.ListarDocumentoPorUsuario(cod_usuario);
        }

        public bool ModificarDocumento(BEDocumento oParametro)
        {
            var BLDocumento = new BLDocumento();
            return BLDocumento.ModificarDocumento(oParametro);
        }

        public bool ModificarNombreArchivo(int codigo, string descripcionDocumento, string nombreArchivo, DateTime fechaVigencia, string usuarioModificacion)
        {
            var BLDocumento = new BLDocumento();
            return BLDocumento.ModificarNombreArchivo(codigo, descripcionDocumento, nombreArchivo, fechaVigencia, usuarioModificacion);
        }

        public BEDocumento ObtenerDocumento(int cod_documento)
        {
            var BLDocumento = new BLDocumento();
            return BLDocumento.ObtenerDocumento(cod_documento);
        }

        public BEDocumento ObtenerDocumentoDownload(int cod_documento)
        {
            var BLDocumento = new BLDocumento();
            return BLDocumento.ObtenerDocumentoDownload(cod_documento);
        }

        public int RegistrarDocumento(BEDocumento oParametro)
        {
            var BLDocumento = new BLDocumento();
            return BLDocumento.RegistrarDocumento(oParametro);
        }

        #endregion
    }
}
