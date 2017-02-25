﻿
using System;
using System.Collections.Generic;

using eDocuments.Entities;
using Npgsql;
using System.Data;
using eDocuments.Common;
using NpgsqlTypes;

namespace eDocuments.DataAccess
{
    public class DAUsuario
    {
        /// <summary>
        /// Obtiene los datos del usuario que accedio al sistema.
        /// </summary>
        /// <param name="usuario">Codigo de Usuario</param>
        /// <returns>Usuario</returns>
        public BEUsuario ObtenerUsuarioLogin(string usuario)
        {
            BEUsuario oUsuario = new BEUsuario();

            using (NpgsqlConnection ocn = new NpgsqlConnection(Util.getConnection()))
            {
                ocn.Open();
                NpgsqlTransaction tran = ocn.BeginTransaction();
                using (NpgsqlCommand ocmd = new NpgsqlCommand("public.func_obtener_doc_usuario_Login", ocn))
                {
                    ocmd.CommandType = CommandType.StoredProcedure;
                    ocmd.Parameters.Add("@p_cod_usuario", NpgsqlDbType.Varchar).Value = usuario;

                    using (NpgsqlDataReader odr = ocmd.ExecuteReader())
                    {
                        while (odr.Read())
                        {

                            if (!Convert.IsDBNull(odr["cod_usuario"]))
                                oUsuario.cod_usuario = odr["cod_usuario"].ToString();

                            if (!Convert.IsDBNull(odr["ape_paterno"]))
                                oUsuario.ape_paterno = odr["ape_paterno"].ToString();

                            if (!Convert.IsDBNull(odr["ape_materno"]))
                                oUsuario.ape_materno = odr["ape_materno"].ToString();

                            if (!Convert.IsDBNull(odr["nombres"]))
                                oUsuario.nombres = odr["nombres"].ToString();

                            if (!Convert.IsDBNull(odr["cod_area"]))
                                oUsuario.cod_area = Convert.ToInt32(odr["cod_area"]);

                            if (!Convert.IsDBNull(odr["gls_area"]))
                                oUsuario.gls_area = odr["gls_area"].ToString();

                            if (!Convert.IsDBNull(odr["cod_rol"]))
                                oUsuario.cod_rol = Convert.ToInt32(odr["cod_rol"]);

                            if (!Convert.IsDBNull(odr["gls_rol"]))
                                oUsuario.gls_rol = odr["gls_rol"].ToString();

                            if (!Convert.IsDBNull(odr["correo"]))
                                oUsuario.correo = odr["correo"].ToString();

                        }
                        odr.Close();
                    }
                }
                tran.Commit();
                ocn.Close();
            }

            return oUsuario;
        }
    }
}
