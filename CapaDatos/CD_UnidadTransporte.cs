using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_UnidadTransporte
    {
        // Registrar nueva unidad de transporte
        public bool Registrar(UnidadTransporte obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("INSERT INTO UNIDAD_TRANSPORTE (Placa, Marca, CapacidadToneladas, AnioFabricacion, Estado)");
                    query.AppendLine("VALUES (@Placa, @Marca, @CapacidadToneladas, @AnioFabricacion, @Estado);");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@Placa", obj.Placa);
                    cmd.Parameters.AddWithValue("@Marca", obj.Marca ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@CapacidadToneladas", obj.CapacidadToneladas);
                    cmd.Parameters.AddWithValue("@AnioFabricacion", obj.AnioFabricacion);
                    cmd.Parameters.AddWithValue("@Estado", obj.Estado);

                    oconexion.Open();
                    Respuesta = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }

        // Listar todas las unidades de transporte
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

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
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
                catch
                {
                    lista = new List<UnidadTransporte>();
                }
            }

            return lista;
        }

        // Buscar una unidad por placa
        public UnidadTransporte ObtenerPorPlaca(string placa)
        {
            UnidadTransporte obj = null;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT TOP 1 IdUnidad, Placa, Marca, CapacidadToneladas, AnioFabricacion, Estado, FechaRegistro");
                    query.AppendLine("FROM UNIDAD_TRANSPORTE WHERE Placa = @placa");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@placa", placa);

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            obj = new UnidadTransporte()
                            {
                                IdUnidad = Convert.ToInt32(dr["IdUnidad"]),
                                Placa = dr["Placa"].ToString(),
                                Marca = dr["Marca"].ToString(),
                                CapacidadToneladas = Convert.ToDecimal(dr["CapacidadToneladas"]),
                                AnioFabricacion = Convert.ToInt32(dr["AnioFabricacion"]),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"])
                            };
                        }
                    }
                }
                catch
                {
                    obj = null;
                }
            }

            return obj;
        }

        // Actualizar estado de una unidad
        public bool CambiarEstado(int idUnidad, bool estado)
        {
            bool respuesta = false;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE UNIDAD_TRANSPORTE SET Estado = @estado WHERE IdUnidad = @idUnidad");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@idUnidad", idUnidad);

                    oconexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0;
                }
                catch
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }
    }
}
