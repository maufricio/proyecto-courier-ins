using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace CapaDatos
{
    // Estados de los fletes.
    // 1: Programado, 2: En Transcurso, 3: Completado, 4: Con Devolución, 5: Con Queja

    public class CD_Flete
    {
        public bool RegistrarFlete(
            Flete flete,
            out string Mensaje
        )
        {
            Mensaje = string.Empty;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("INSERT INTO FLETE (IdCliente, IdUnidad, IdMotorista, IdEstado, MontoCobro, LugarRecolecta, LugarEntrega, Consideraciones, HoraSalida, HoraDestino)");
                    query.AppendLine("VALUES (@IdCliente, @IdUnidad, @IdMotorista, @IdEstado, @Monto, @LugarRecolecta, @LugarEntrega, @Consideraciones, @HoraSalida, @HoraDestino)");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@IdCliente", flete.oCliente.IdCliente);
                    cmd.Parameters.AddWithValue("@IdUnidad", flete.oTransporte.IdUnidad);
                    cmd.Parameters.AddWithValue("@IdMotorista", flete.oMotorista.IdMotorista);
                    cmd.Parameters.AddWithValue("@IdEstado", flete.oEstado.IdEstado);
                    cmd.Parameters.AddWithValue("@Monto", flete.Monto);
                    cmd.Parameters.AddWithValue("@LugarRecolecta", flete.Lrecolecta);
                    cmd.Parameters.AddWithValue("@LugarEntrega", flete.Lentrega);
                    cmd.Parameters.AddWithValue("@Consideraciones", flete.Consideraciones);
                    cmd.Parameters.AddWithValue("@HoraSalida", flete.Hsalida);
                    cmd.Parameters.AddWithValue("@HoraDestino", flete.Hllegada);


                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex) 
                {
                    Mensaje = "Error al registrar flete: " + ex.Message;
                    //MessageBox.Show("Error al registrar flete: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public List<Flete> ListarFletesProgramadosTop()
        {
            List<Flete> Lista = new List<Flete>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT TOP 5");
                    query.AppendLine("  f.IdFlete,");
                    query.AppendLine("  f.IdCliente,");
                    query.AppendLine("  f.IdUnidad,");
                    query.AppendLine("  f.IdMotorista,");
                    query.AppendLine("  f.IdEstado,");
                    query.AppendLine("  c.NombreCliente,");
                    query.AppendLine("  m.NombreMotorista,");
                    query.AppendLine("  u.Placa,");
                    query.AppendLine("  e.Descripcion,");
                    query.AppendLine("  f.MontoCobro,");
                    query.AppendLine("  f.LugarRecolecta,");
                    query.AppendLine("  f.LugarEntrega,");
                    query.AppendLine("  f.HoraSalida,");
                    query.AppendLine("  f.HoraDestino,");
                    query.AppendLine("  f.Consideraciones");
                    query.AppendLine("FROM FLETE f");
                    query.AppendLine("INNER JOIN CLIENTE c ON f.IdCliente = c.IdCliente");
                    query.AppendLine("INNER JOIN MOTORISTA m ON f.IdMotorista = m.IdMotorista");
                    query.AppendLine("INNER JOIN UNIDAD_TRANSPORTE u ON f.IdUnidad = u.IdUnidad");
                    query.AppendLine("INNER JOIN ESTADO_FLETE e ON f.IdEstado = e.IdEstado");
                    query.AppendLine("WHERE f.IdEstado = 1"); // Asumiendo que '1' es el estado para 'Programado'
                    query.AppendLine("ORDER BY f.HoraSalida ASC");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Flete()
                            {
                                IdFlete = Convert.ToInt32(dr["IdFlete"]),
                                oCliente = new Cliente()
                                {
                                    IdCliente = Convert.ToInt32(dr["IdCliente"]),
                                    NombreCliente = dr["NombreCliente"].ToString()
                                },
                                oMotorista = new Motorista()
                                {
                                    IdMotorista = Convert.ToInt32(dr["IdMotorista"]),
                                    NombreMotorista = dr["NombreMotorista"].ToString()
                                },
                                oTransporte = new Transporte()
                                {
                                    IdUnidad = Convert.ToInt32(dr["IdUnidad"]),
                                    Placa = dr["Placa"].ToString()
                                },
                                oEstado = new Estado()
                                {
                                    IdEstado = Convert.ToInt32(dr["IdEstado"]),
                                    Descripcion = dr["Descripcion"].ToString()
                                },
                                Monto = Convert.ToDecimal(dr["MontoCobro"]),
                                Lrecolecta = dr["LugarRecolecta"].ToString(),
                                Lentrega = dr["LugarEntrega"].ToString(),
                                Hsalida = Convert.ToDateTime(dr["HoraSalida"]),
                                Hllegada = Convert.ToDateTime(dr["HoraDestino"]),
                                Consideraciones = dr["Consideraciones"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Lista = new List<Flete>();
            }
            return Lista;
        }

        public List<Flete> listarFletesEnTranscursoTop()
        {
            List<Flete> Lista = new List<Flete>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    // Traer el top 5 de fletes con estado que estan en transcurso
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT TOP 5");
                    query.AppendLine(
                        "  f.IdFlete," +
                        "  f.IdCliente," +
                        "  f.IdUnidad," +
                        "  f.IdMotorista," +
                        "  f.IdEstado," +
                        "  c.NombreCliente," +
                        "  m.NombreMotorista," +
                        "  u.Placa," +
                        "  e.Descripcion," +
                        "  f.MontoCobro," +
                        "  f.LugarRecolecta," +
                        "  f.LugarEntrega," +
                        "  f.HoraSalida," +
                        "  f.HoraDestino," +
                        "  f.Consideraciones"
                    );
                    query.AppendLine("FROM FLETE f");
                    query.AppendLine("INNER JOIN CLIENTE c ON f.IdCliente = c.IdCliente");
                    query.AppendLine("INNER JOIN MOTORISTA m ON f.IdMotorista = m.IdMotorista");
                    query.AppendLine("INNER JOIN UNIDAD_TRANSPORTE u ON f.IdUnidad = u.IdUnidad");
                    query.AppendLine("INNER JOIN ESTADO_FLETE e ON f.IdEstado = e.IdEstado");
                    query.AppendLine("WHERE f.IdEstado = 2"); // Asumiendo que '2' es el estado para 'En Transcurso'
                    query.AppendLine("ORDER BY f.HoraSalida ASC");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Flete()
                            {
                                IdFlete = Convert.ToInt32(dr["IdFlete"]),
                                oCliente = new Cliente()
                                {
                                    IdCliente = Convert.ToInt32(dr["IdCliente"]),
                                    NombreCliente = dr["NombreCliente"].ToString()
                                },
                                oMotorista = new Motorista()
                                {
                                    IdMotorista = Convert.ToInt32(dr["IdMotorista"]),
                                    NombreMotorista = dr["NombreMotorista"].ToString()
                                },
                                oTransporte = new Transporte()
                                {
                                    IdUnidad = Convert.ToInt32(dr["IdUnidad"]),
                                    Placa = dr["Placa"].ToString()
                                },
                                oEstado = new Estado()
                                {
                                    IdEstado = Convert.ToInt32(dr["IdEstado"]),
                                    Descripcion = dr["Descripcion"].ToString()
                                },
                                Monto = Convert.ToDecimal(dr["MontoCobro"]),
                                Lrecolecta = dr["LugarRecolecta"].ToString(),
                                Lentrega = dr["LugarEntrega"].ToString(),
                                Hsalida = Convert.ToDateTime(dr["HoraSalida"]),
                                Hllegada = Convert.ToDateTime(dr["HoraDestino"]),
                                Consideraciones = dr["Consideraciones"].ToString()
                            });
                        }
                    }
                }
            } catch(Exception ex)
            {
                Lista = new List<Flete>();
            }

            return Lista;
        }



        public List<Flete> Listar()
        {
            List<Flete> Lista = new List<Flete>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT");
                    query.AppendLine("  f.IdFlete,");
                    query.AppendLine("  f.IdCliente,");
                    query.AppendLine("  f.IdUnidad,");
                    query.AppendLine("  f.IdMotorista,");
                    query.AppendLine("  f.IdEstado,");
                    query.AppendLine("  c.NombreCliente,");
                    query.AppendLine("  m.NombreMotorista,");
                    query.AppendLine("  u.Placa,");
                    query.AppendLine("  e.Descripcion,");
                    query.AppendLine("  f.MontoCobro,");
                    query.AppendLine("  f.LugarRecolecta,");
                    query.AppendLine("  f.LugarEntrega,");
                    query.AppendLine("  f.HoraSalida,");
                    query.AppendLine("  f.HoraDestino,");
                    query.AppendLine("  f.Consideraciones");
                    query.AppendLine("FROM FLETE f");
                    query.AppendLine("INNER JOIN CLIENTE c ON f.IdCliente = c.IdCliente");
                    query.AppendLine("INNER JOIN MOTORISTA m ON f.IdMotorista = m.IdMotorista");
                    query.AppendLine("INNER JOIN UNIDAD_TRANSPORTE u ON f.IdUnidad = u.IdUnidad");
                    query.AppendLine("INNER JOIN ESTADO_FLETE e ON f.IdEstado = e.IdEstado");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);                    
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Flete()
                            {
                                IdFlete = Convert.ToInt32(dr["IdFlete"]),
                                oCliente = new Cliente()
                                {
                                    IdCliente = Convert.ToInt32(dr["IdCliente"]),
                                    NombreCliente = dr["NombreCliente"].ToString()
                                },
                                oMotorista = new Motorista()
                                {
                                    IdMotorista = Convert.ToInt32(dr["IdMotorista"]),
                                    NombreMotorista = dr["NombreMotorista"].ToString()
                                },
                                oTransporte = new Transporte()
                                {
                                    IdUnidad = Convert.ToInt32(dr["IdUnidad"]),
                                    Placa = dr["Placa"].ToString()
                                },
                                oEstado = new Estado()
                                {
                                    IdEstado = Convert.ToInt32(dr["IdEstado"]),
                                    Descripcion = dr["Descripcion"].ToString()
                                },
                                Monto = Convert.ToDecimal(dr["MontoCobro"]),
                                Lrecolecta = dr["LugarRecolecta"].ToString(),
                                Lentrega = dr["LugarEntrega"].ToString(),
                                Hsalida = Convert.ToDateTime(dr["HoraSalida"]),
                                Hllegada = Convert.ToDateTime(dr["HoraDestino"]),
                                Consideraciones = dr["Consideraciones"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Lista = new List<Flete>();
            }
            return Lista;
        }


        public bool Editar(Flete obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE FLETE SET");
                    query.AppendLine("  IdCliente = @IdCliente,");
                    query.AppendLine("  IdUnidad = @IdUnidad,");
                    query.AppendLine("  IdMotorista = @IdMotorista,");
                    query.AppendLine("  IdEstado = @IdEstado,");
                    query.AppendLine("  MontoCobro = @MontoCobro,");
                    query.AppendLine("  LugarRecolecta = @LugarRecolecta,");
                    query.AppendLine("  LugarEntrega = @LugarEntrega,");
                    query.AppendLine("  HoraSalida = @HoraSalida,");
                    query.AppendLine("  HoraDestino = @HoraDestino,");
                    query.AppendLine("  Consideraciones = @Consideraciones");
                    query.AppendLine("WHERE IdFlete = @IdFlete");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@IdFlete", obj.IdFlete);
                    cmd.Parameters.AddWithValue("@IdCliente", obj.oCliente.IdCliente);
                    cmd.Parameters.AddWithValue("@IdUnidad", obj.oTransporte.IdUnidad);
                    cmd.Parameters.AddWithValue("@IdMotorista", obj.oMotorista.IdMotorista);
                    cmd.Parameters.AddWithValue("@IdEstado", obj.oEstado.IdEstado);
                    cmd.Parameters.AddWithValue("@MontoCobro", obj.Monto);
                    cmd.Parameters.AddWithValue("@LugarRecolecta", obj.Lrecolecta);
                    cmd.Parameters.AddWithValue("@LugarEntrega", obj.Lentrega);
                    cmd.Parameters.AddWithValue("@HoraSalida", obj.Hsalida);
                    cmd.Parameters.AddWithValue("@HoraDestino", obj.Hllegada);
                    cmd.Parameters.AddWithValue("@Consideraciones", obj.Consideraciones);

                    oconexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    respuesta = filasAfectadas > 0;
                    Mensaje = respuesta ? "Flete editado correctamente." : "No se pudo editar el flete.";
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        public bool Eliminar(Flete obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("DELETE FROM FLETE WHERE IdFlete = @IdFlete");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@IdFlete", obj.IdFlete);

                    oconexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    respuesta = filasAfectadas > 0;
                    Mensaje = respuesta ? "Flete eliminado correctamente." : "No se pudo eliminar el flete.";
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

