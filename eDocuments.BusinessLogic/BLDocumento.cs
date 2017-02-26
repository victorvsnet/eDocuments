
using System;
using System.Collections.Generic;

using eDocuments.Entities;
using eDocuments.DataAccess;

namespace eDocuments.BusinessLogic
{
    public class BLDocumento
    {
        public int RegistrarDocumento(BEDocumento oParametro)
        {
            return new DADocumento().RegistrarDocumento(oParametro);
        }

        public bool ModificarDocumento(BEDocumento oParametro)
        {
            return new DADocumento().ModificarDocumento(oParametro);
        }

        public bool ModificarNombreArchivo(int codigo, string descripcionDocumento, string nombreArchivo, DateTime fechaVigencia, string usuarioModificacion)
        {
            return new DADocumento().ModificarNombreArchivo(codigo, descripcionDocumento, nombreArchivo, fechaVigencia, usuarioModificacion);
        }

        public BEDocumento ObtenerDocumento(int cod_documento)
        {
            return new DADocumento().ObtenerDocumento(cod_documento);
        }

        public BEDocumento ObtenerDocumentoDownload(int cod_documento)
        {
            return new DADocumento().ObtenerDocumentoDownload(cod_documento);
        }

        public List<BEDocumento> ListarDocumento(BEDocumento oBusqueda)
        {
            return new DADocumento().ListarDocumento(oBusqueda);
        }

        public List<BEDocumento> ListarDocumentoPorCarpeta(int cod_carpeta)
        {
            return new DADocumento().ListarDocumentoPorCarpeta(cod_carpeta);
        }

        public List<BEDocumento> ListarDocumentoPorCarpetaSegunUsuario(int cod_carpeta, string cod_usuario)
        {
            return new DADocumento().ListarDocumentoPorCarpetaSegunUsuario(cod_carpeta, cod_usuario);
        }

        public List<BEDocumento> ListarDocumentoPorUsuario(string cod_usuario)
        {
            return new DADocumento().ListarDocumentoPorUsuario(cod_usuario);
        }

        public string GetNombreArchivo(int cod_documento)
        {
            return new DADocumento().GetNombreArchivo(cod_documento);
        }

        public bool EliminarDocumento(int cod_documento, string cod_usuario)
        {
            return new DADocumento().EliminarDocumento(cod_documento, cod_usuario);
        }
    }
}
