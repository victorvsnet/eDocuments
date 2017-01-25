﻿using System;

namespace eDocuments.Entities
{
    public class BEUsuario : Auditoria
    {
        public string cod_usuario { get; set; }
        public int cod_area { get; set; }
        public int cod_rol { get; set; }
        public string gls_area { get; set; }
        public string gls_rol { get; set; }
        public string ape_paterno { get; set; }
        public string ape_materno { get; set; }
        public string nombres { get; set; }
        public string correo { get; set; }
    }
}
