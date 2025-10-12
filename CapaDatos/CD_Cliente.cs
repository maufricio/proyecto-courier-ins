using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Cliente
    {

        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    string sql = "SELECT IdCliente, NombreCliente, Direccion, Estado, FechaRegistro, correo FROM CLIENTE";
                    SqlCommand cmd = new SqlCommand(sql, oconexion);
                    cmd.CommandType = CommandType.Text; // Esto le dice a ADO.NET que es una consulta de texto simple
                    oconexion.Open();


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int clienteId = Convert.ToInt32(dr["IdCliente"]);
                            string nombreCliente = dr["NombreCliente"].ToString();
                            string dirCliente = dr["Direccion"].ToString();
                            int estado = Convert.ToBoolean(dr["Estado"]) ? 1 : 0;
                            DateTime fechaRegistro = DateTime.Parse(dr["FechaRegistro"].ToString());
                            string correo = dr["correo"].ToString();

                            lista.Add(new Cliente()
                            {
                                IdCliente = clienteId,
                                NombreCliente = nombreCliente,
                                Direccion = dirCliente,
                                Estado = estado,
                                FechaRegistro = fechaRegistro,
                                Correo = correo
                            });

                        }

                    }


                }
                catch (Exception ex)
                {

                    lista = new List<Cliente>();
                    Console.WriteLine(ex.Message.ToString());
                }
            } // Automaticamente cierra las conexiones con la base de datos para evitar fugas de memoria

            return lista;

        }




        public int Registrar(Cliente obj, out string Mensaje)
        {
            int idClienteGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand(
                            "INSERT INTO CLIENTE (NombreCliente, Direccion, correo, Estado, FechaRegistro)" +
                            "VALUES (@NombreCliente, @Direccion, @Correo, @Estado, @FechaRegistro); " +
                            "SELECT SCOPE_IDENTITY();",
                            oconexion
                    );

                    cmd.Parameters.AddWithValue("@NombreCliente", obj.NombreCliente);
                    cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("@Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("@Estado", obj.Estado);
                    cmd.Parameters.AddWithValue("@FechaRegistro", obj.FechaRegistro);

                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    // Recupera el ID generado automáticamente después de insertar el registro a la base de datos.
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        idClienteGenerado = Convert.ToInt32(result);
                        Mensaje = "Cliente registrado correctamente";
                    }
                    else
                    {
                        idClienteGenerado = 0;
                        Mensaje = "No se pudo registrar el cliente";
                    }
                }
            } catch (Exception ex)
            {
                idClienteGenerado = 0;
                Mensaje = ex.Message;
            }

            return idClienteGenerado;
        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using(SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE CLIENTE SET NombreCliente = @NombreCliente, Direccion = @Direccion, Estado = @Estado WHERE IdCliente = @IdCliente",
                        oconexion
                    );

                    cmd.Parameters.AddWithValue("@IdCliente", obj.IdCliente);
                    cmd.Parameters.AddWithValue("@NombreCliente", obj.NombreCliente);
                    cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("@Estado", obj.Estado);

                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;

                    Mensaje = respuesta ? "Cliente editado correctamente" : "No se pudo editar el cliente";

                    return respuesta;
                }
            } catch(Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return false;
        }

        public bool Eliminar(int idCliente, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM CLIENTE WHERE IdCliente = @IdCliente",
                        oconexion
                    );
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                    Mensaje = respuesta ? "Cliente eliminado correctamente" : "No se pudo eliminar el cliente";
                    return respuesta;
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return false;
        }

    }
}
