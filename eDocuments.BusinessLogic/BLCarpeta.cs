
using System;
using System.Collections.Generic;

using eDocuments.Entities;
using eDocuments.DataAccess;

namespace eDocuments.BusinessLogic
{
    public class BLCarpeta
    {
        public int RegistrarCarpeta(BECarpeta oParametro)
        {
            return new DACarpeta().RegistrarCarpeta(oParametro);
        }

        public int EliminarCarpeta(BECarpeta oParametro)
        {
            return new DACarpeta().EliminarCarpeta(oParametro);
        }

        public bool ModificarCarpeta(BECarpeta oParametro)
        {
            return new DACarpeta().ModificarCarpeta(oParametro);
        }

        public bool ModificarCarpetaGestion(BECarpeta oParametro)
        {
            return new DACarpeta().ModificarCarpetaGestion(oParametro);
        }

        public BECarpeta ObtenerCarpeta(int cod_carpeta)
        {
            return new DACarpeta().ObtenerCarpeta(cod_carpeta);
        }

        public List<BECarpeta> ListarCarpeta()
        {
            return new DACarpeta().ListarCarpeta();
        }
    }
}
