
using System;
using System.Collections.Generic;

using eDocuments.Entities;
using eDocuments.DataAccess;

namespace eDocuments.BusinessLogic
{
    public class BLPerfil
    {
        public List<BEPerfil> ListarPerfil()
        {
            return new DAPerfil().ListarPerfil();
        }

        public int Registrar(BEPerfil oParametro)
        {
            return new DAPerfil().Registrar(oParametro);
        }

        public int Actualizar(BEPerfil oParametro)
        {
            return new DAPerfil().Actualizar(oParametro);
        }

        public int Eliminar(BEPerfil oParametro)
        {
            return new DAPerfil().Eliminar(oParametro);
        }

        public List<BEPerfil> GetPerfilesSinAsignar(string id)
        {
            return new DAPerfil().GetPerfilesSinAsignar(id);
        }

        public List<BEPerfil> GetPerfilesAsignados(string id)
        {
            return new DAPerfil().GetPerfilesAsignados(id);
        }

        public List<BEPerfil> GetPerfilesSinAsignarDoc(int id)
        {
            return new DAPerfil().GetPerfilesSinAsignarDoc(id);
        }

        public List<BEPerfil> GetPerfilesAsignadosDoc(int id)
        {
            return new DAPerfil().GetPerfilesAsignadosDoc(id);
        }

    }
}
