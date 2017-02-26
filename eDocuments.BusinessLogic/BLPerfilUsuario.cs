
using System;
using System.Collections.Generic;

using eDocuments.Entities;
using eDocuments.DataAccess;

namespace eDocuments.BusinessLogic
{
    public class BLPerfilUsuario
    {
        public List<BEPerfilUsuario> ListarPerfilUsuario(string cod_usuario)
        {
            return new DAPerfilUsuario().ListarPerfilUsuario(cod_usuario);
        }

        public int RegistrarPerfilUsuario(BEPerfilUsuario oParametro)
        {
            return new DAPerfilUsuario().RegistrarPerfilUsuario(oParametro);
        }

        public int EliminarPerfilUsuario(BEPerfilUsuario oParametro)
        {
            return new DAPerfilUsuario().EliminarPerfilUsuario(oParametro);
        }
    }
}
