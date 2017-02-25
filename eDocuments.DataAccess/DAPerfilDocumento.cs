
using System;
using System.Collections.Generic;
using System.Data;

using Npgsql;
using NpgsqlTypes;
using eDocuments.Entities;
using eDocuments.Common;

namespace eDocuments.DataAccess
{
    public class DAPerfilDocumento
    {
        /// <summary>
        /// Registrar Perfil de documentos
        /// </summary>        
        public int RegistrarPerfilDocumento(BEPerfilDocumento PerfilDocumento)
        {
            int idRegistro = 0;
            try
            {
                using (NpgsqlConnection ocn = new NpgsqlConnection(Util.getConnection()))
                {
                    ocn.Open();
                    NpgsqlTransaction tran = ocn.BeginTransaction();
                    using (NpgsqlCommand ocmd = new NpgsqlCommand("public.func_registrar_doc_perfil_documentos", ocn))
                    {
                        ocmd.CommandType = CommandType.StoredProcedure;
                        ocmd.Parameters.Add("@p_cod_documento", NpgsqlDbType.Integer).Value = PerfilDocumento.cod_documento;
                        ocmd.Parameters.Add("@p_cod_perfil", NpgsqlDbType.Integer).Value = PerfilDocumento.cod_perfil;
                        ocmd.Parameters.Add("@p_aud_usr_ingreso", NpgsqlDbType.Varchar).Value = PerfilDocumento.aud_usr_ingreso;

                        using (NpgsqlDataReader odr = ocmd.ExecuteReader())
                        {
                            while (odr.Read())
                                idRegistro = Convert.ToInt32(odr[0]);
                        }

                    }
                    tran.Commit();
                    ocn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //estadoIngreso = false;
            }
            return idRegistro;
        }

        /// <summary>
        /// Eliminar Perfil de usuarios
        /// </summary>        
        public int EliminarPerfilDocumento(BEPerfilDocumento PerfilDocumento)
        {
            int idRegistro = 0;
            try
            {
                using (NpgsqlConnection ocn = new NpgsqlConnection(Util.getConnection()))
                {
                    ocn.Open();
                    NpgsqlTransaction tran = ocn.BeginTransaction();
                    using (NpgsqlCommand ocmd = new NpgsqlCommand("public.func_delete_doc_perfil_documentos", ocn))
                    {
                        ocmd.CommandType = CommandType.StoredProcedure;
                        ocmd.Parameters.Add("@p_cod_documento", NpgsqlDbType.Integer).Value = PerfilDocumento.cod_documento;
                        ocmd.Parameters.Add("@p_cod_perfil", NpgsqlDbType.Integer).Value = PerfilDocumento.cod_perfil;
                        ocmd.Parameters.Add("@p_aud_usr_ingreso", NpgsqlDbType.Varchar).Value = PerfilDocumento.aud_usr_modificacion;

                        using (NpgsqlDataReader odr = ocmd.ExecuteReader())
                        {
                            while (odr.Read())
                                idRegistro = Convert.ToInt32(odr[0]);
                        }

                    }
                    tran.Commit();
                    ocn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //estadoIngreso = false;
            }
            return idRegistro;
        }

    }
}
