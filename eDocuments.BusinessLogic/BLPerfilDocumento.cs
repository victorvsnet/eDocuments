
using System;
using System.Collections.Generic;

using eDocuments.Entities;
using eDocuments.DataAccess;

namespace eDocuments.BusinessLogic
{
    public class BLPerfilDocumento
    {
        public int RegistrarPerfilDocumento(BEPerfilDocumento oParametro)
        {
            return new DAPerfilDocumento().RegistrarPerfilDocumento(oParametro);
        }

        public int EliminarPerfilDocumento(BEPerfilDocumento oParametro)
        {
            return new DAPerfilDocumento().EliminarPerfilDocumento(oParametro);
        }

       

    }
}
