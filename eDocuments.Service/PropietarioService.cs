using System;
using System.Collections.Generic;

using eDocuments.ServiceContracts;
using eDocuments.Entities;
using eDocuments.BusinessLogic;

namespace eDocuments.Service
{
    public class PropietarioService : IPropietarioService
    {
        public int Actualizar(BEPropietario oParametro)
        {
            var BLPropietario = new BLPropietario();
            return BLPropietario.Actualizar(oParametro);
        }

        public int Eliminar(BEPropietario oParametro)
        {
            var BLPropietario = new BLPropietario();
            return BLPropietario.Eliminar(oParametro);
        }

        public List<BEPropietario> ListarPropietario(string propietario)
        {
            var BLPropietario = new BLPropietario();
            return BLPropietario.ListarPropietario(propietario);
        }

        public int Registrar(BEPropietario oParametro)
        {
            var BLPropietario = new BLPropietario();
            return BLPropietario.Registrar(oParametro);
        }
    }
}
