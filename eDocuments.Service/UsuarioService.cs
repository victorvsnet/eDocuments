using System;
using System.Collections.Generic;

using eDocuments.ServiceContracts;
using eDocuments.Entities;
using eDocuments.BusinessLogic;

namespace eDocuments.Service
{
    public class UsuarioService : IUsuarioService
    {
        public string SayHello(string name)
        {
            return string.Format("Hi: {0}", name);
        }

        public BEUsuario ObtenerUsuarioLogin(string usuario)
        {
            var BLUsuario = new BLUsuario();
            return BLUsuario.ObtenerUsuarioLogin(usuario);
        }
    }
}
