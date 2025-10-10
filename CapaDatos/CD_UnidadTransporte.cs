using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using CapaEntidad;

namespace CapaDatos
{
    public class CD_UnidadTransporte
    {
        public List<UnidadTransporte> Listar()
        {
            List<UnidadTransporte> lista = new List<UnidadTransporte>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdUnidad, Placa, Marca, CapacidadToneladas, AnioFabricacion, Estado, FechaRegistro");
                    query.AppendLine("FROM UNIDAD_TRANSPORTE");
                    query.AppendLine("ORDER BY FechaRegistro DESC");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new UnidadTransporte()
                            {
                                IdUnidad = Convert.ToInt32(dr["IdUnidad"]),
                                Placa = dr["Placa"].ToString(),
                                Marca = dr["Marca"].ToString(),
                                CapacidadToneladas = Convert.ToDecimal(dr["CapacidadToneladas"]),
                                AnioFabricacion = Convert.ToInt32(dr["AnioFabricacion"]),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<UnidadTransporte>();
                    Console.WriteLine(ex.Message.ToString());
                }
            }

            return lista;
        }

        public int Registrar(UnidadTransporte obj, out string Mensaje)
        {
            int idUnidadGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarUnidadTransporte", oconexion);
                    cmd.Parameters.AddWithValue("Placa", obj.Placa);
                    cmd.Parameters.AddWithValue("Marca", obj.Marca);
                    cmd.Parameters.AddWithValue("CapacidadToneladas", obj.CapacidadToneladas);
                    cmd.Parameters.AddWithValue("AnioFabricacion", obj.AnioFabricacion);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idUnidadGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idUnidadGenerado = 0;
                Mensaje = ex.Message;
            }

            return idUnidadGenerado;
        }

        public bool Editar(UnidadTransporte obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ModificarUnidadTransporte", oconexion);
                    cmd.Parameters.AddWithValue("IdUnidad", obj.IdUnidad);
                    cmd.Parameters.AddWithValue("Placa", obj.Placa);
                    cmd.Parameters.AddWithValue("Marca", obj.Marca);
                    cmd.Parameters.AddWithValue("CapacidadToneladas", obj.CapacidadToneladas);
                    cmd.Parameters.AddWithValue("AnioFabricacion", obj.AnioFabricacion);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        public bool Eliminar(UnidadTransporte obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM UNIDAD_TRANSPORTE WHERE IdUnidad = @id", oconexion);
                    cmd.Parameters.AddWithValue("@id", obj.IdUnidad);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }
    }
}