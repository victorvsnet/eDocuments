
using System;
using System.Collections.Generic;

using eDocuments.Entities;
using eDocuments.DataAccess;

namespace eDocuments.BusinessLogic
{
    public class BLPropietario
    {
        public List<BEPropietario> ListarPropietario(string propietario)
        {
            return new DAPropietario().ListarPropietario(propietario);
        }

        public int Registrar(BEPropietario oParametro)
        {
            return new DAPropietario().Registrar(oParametro);
        }

        public int Actualizar(BEPropietario oParametro)
        {
            return new DAPropietario().Actualizar(oParametro);
        }

        public int Eliminar(BEPropietario oParametro)
        {
            return new DAPropietario().Eliminar(oParametro);
        }
    }
}
