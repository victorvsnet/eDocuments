
using System;
using System.Collections.Generic;

using eDocuments.Entities;
using eDocuments.DataAccess;

namespace eDocuments.BusinessLogic
{
    public class BLUsuario
    {
        public BEUsuario ObtenerUsuarioLogin(string usuario)
        {
            return new DAUsuario().ObtenerUsuarioLogin(usuario);
        }

        public List<BEUsuario> ListarUsuarios(string usuario)
        {
            return new DAUsuario().ListarUsuarios(usuario);
        }

        public int Actualizar(BEUsuario oParametro)
        {
            return new DAUsuario().Actualizar(oParametro);
        }

        public int Eliminar(BEUsuario oParametro)
        {
            return new DAUsuario().Eliminar(oParametro);
        }

        public int Registrar(BEUsuario oParametro)
        {
            return new DAUsuario().Registrar(oParametro);
        }
    }
}
