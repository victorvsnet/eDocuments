using System;
using System.Collections.Generic;

using eDocuments.ServiceContracts;
using eDocuments.Entities;
using eDocuments.BusinessLogic;

namespace eDocuments.Service
{
    public class PerfilService : IPerfilService
    {
        #region Perfil

        public int Actualizar(BEPerfil oParametro)
        {
            var BLPerfil = new BLPerfil();
            return BLPerfil.Actualizar(oParametro);
        }

        public int Eliminar(BEPerfil oParametro)
        {
            var BLPerfil = new BLPerfil();
            return BLPerfil.Eliminar(oParametro);
        }

        public List<BEPerfil> GetPerfilesAsignados(string id)
        {
            var BLPerfil = new BLPerfil();
            return BLPerfil.GetPerfilesAsignados(id);
        }

        public List<BEPerfil> GetPerfilesAsignadosDoc(int id)
        {
            var BLPerfil = new BLPerfil();
            return BLPerfil.GetPerfilesAsignadosDoc(id);
        }

        public List<BEPerfil> GetPerfilesSinAsignar(string id)
        {
            var BLPerfil = new BLPerfil();
            return BLPerfil.GetPerfilesSinAsignar(id);
        }

        public List<BEPerfil> GetPerfilesSinAsignarDoc(int id)
        {
            var BLPerfil = new BLPerfil();
            return BLPerfil.GetPerfilesSinAsignarDoc(id);
        }

        public List<BEPerfil> ListarPerfil()
        {
            var BLPerfil = new BLPerfil();
            return BLPerfil.ListarPerfil();
        }

        public int Registrar(BEPerfil oParametro)
        {
            var BLPerfil = new BLPerfil();
            return BLPerfil.Registrar(oParametro);
        }

        #endregion

        #region Perfil Documento

        public int EliminarPerfilDocumento(BEPerfilDocumento oParametro)
        {
            throw new NotImplementedException();
        }

        public int RegistrarPerfilDocumento(BEPerfilDocumento oParametro)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Perfil Usuario

        public int EliminarPerfilUsuario(BEPerfilUsuario oParametro)
        {
            throw new NotImplementedException();
        }

        public List<BEPerfilUsuario> ListarPerfilUsuario(string cod_usuario)
        {
            throw new NotImplementedException();
        }

        public int RegistrarPerfilUsuario(BEPerfilUsuario oParametro)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
