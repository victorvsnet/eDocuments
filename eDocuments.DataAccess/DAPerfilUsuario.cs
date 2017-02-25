
using System;
using System.Collections.Generic;
using System.Data;

using Npgsql;
using NpgsqlTypes;
using eDocuments.Entities;
using eDocuments.Common;

namespace eDocuments.DataAccess
{
    public class DAPerfilUsuario
    {
        /// <summary>
        /// Listado de Perfiles por usuario
        /// </summary>
        /// <returns>Lista de perfiles del usuario</returns>
        public List<BEPerfilUsuario> ListarPerfilUsuario(string codUsuario)
        {
            List<BEPerfilUsuario> oListado = new List<BEPerfilUsuario>();
            BEPerfilUsuario oItem;

            using (NpgsqlConnection cnx = new NpgsqlConnection(Util.getConnection()))
            {
                cnx.Open();
                NpgsqlTransaction tran = cnx.BeginTransaction();
                using (NpgsqlCommand ocmd = new NpgsqlCommand("public.func_listar_perfiles_asignados", cnx))
                {
                    ocmd.CommandType = CommandType.StoredProcedure;                    
                    ocmd.Parameters.Add("@p_cod_usuario", NpgsqlDbType.Varchar).Value = codUsuario;

                    using (NpgsqlDataReader odr = ocmd.ExecuteReader())
                    {
                        while (odr.Read())
                        {
                            oItem = new BEPerfilUsuario();

                            if (!Convert.IsDBNull(odr["cod_perfil"]))
                                oItem.cod_perfil = int.Parse(odr["cod_perfil"].ToString());

                            if (!Convert.IsDBNull(odr["gls_perfil"]))
                                oItem.gls_perfil = Convert.ToString(odr["gls_perfil"]);
                                                        
                            oListado.Add(oItem);
                        }
                        odr.Close();
                    }
                }
                tran.Commit();
                cnx.Close();


                return oListado;
            }
        }

        /// <summary>
        /// Registrar Perfil de usuarios
        /// </summary>        
        public int RegistrarPerfilUsuario(BEPerfilUsuario PerfilUsuario)
        {
            int idRegistro = 0;
            try
            {
                using (NpgsqlConnection ocn = new NpgsqlConnection(Util.getConnection()))
                {
                    ocn.Open();
                    NpgsqlTransaction tran = ocn.BeginTransaction();
                    using (NpgsqlCommand ocmd = new NpgsqlCommand("public.func_registrar_doc_perfil_usuarios", ocn))
                    {
                        ocmd.CommandType = CommandType.StoredProcedure;
                        ocmd.Parameters.Add("@p_cod_usuario", NpgsqlDbType.Varchar).Value = PerfilUsuario.cod_usuario;
                        ocmd.Parameters.Add("@p_cod_perfil", NpgsqlDbType.Integer).Value = PerfilUsuario.cod_perfil;
                        ocmd.Parameters.Add("@p_aud_usr_ingreso", NpgsqlDbType.Varchar).Value = PerfilUsuario.aud_usr_ingreso;

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
        public int EliminarPerfilUsuario(BEPerfilUsuario PerfilUsuario)
        {
            int idRegistro = 0;
            try
            {
                using (NpgsqlConnection ocn = new NpgsqlConnection(Util.getConnection()))
                {
                    ocn.Open();
                    NpgsqlTransaction tran = ocn.BeginTransaction();
                    using (NpgsqlCommand ocmd = new NpgsqlCommand("public.func_delete_doc_perfil_usuarios", ocn))
                    {
                        ocmd.CommandType = CommandType.StoredProcedure;
                        ocmd.Parameters.Add("@p_cod_usuario", NpgsqlDbType.Varchar).Value = PerfilUsuario.cod_usuario;
                        ocmd.Parameters.Add("@p_cod_perfil", NpgsqlDbType.Integer).Value = PerfilUsuario.cod_perfil;
                        ocmd.Parameters.Add("@p_aud_usr_ingreso", NpgsqlDbType.Varchar).Value = PerfilUsuario.aud_usr_modificacion;

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
