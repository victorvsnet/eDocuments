using eDocuments.BusinessEntity;
using eDocuments.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
