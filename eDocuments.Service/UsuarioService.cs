using System;
using System.Collections.Generic;

using eDocuments.ServiceContracts;
using eDocuments.Entities;
using eDocuments.BusinessLogic;

namespace eDocuments.Service
{
    public class UsuarioService : IUsuarioService
    {
        public BEUsuario ObtenerUsuarioLogin(string usuario)
        {
            var BLUsuario = new BLUsuario();
            return BLUsuario.ObtenerUsuarioLogin(usuario);
        }

        public List<BEUsuario> ListarUsuarios(string usuario)
        {
            var BLUsuario = new BLUsuario();
            return BLUsuario.ListarUsuarios(usuario);
        }

        public int Actualizar(BEUsuario oParametro)
        {
            var BLUsuario = new BLUsuario();
            return BLUsuario.Actualizar(oParametro);
        }

        public int Eliminar(BEUsuario oParametro)
        {
            var BLUsuario = new BLUsuario();
            return BLUsuario.Eliminar(oParametro);
        }

        public int Registrar(BEUsuario oParametro)
        {
            var BLUsuario = new BLUsuario();
            return BLUsuario.Registrar(oParametro);
        }
    }
}
