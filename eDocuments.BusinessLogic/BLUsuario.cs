
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
    }
}
