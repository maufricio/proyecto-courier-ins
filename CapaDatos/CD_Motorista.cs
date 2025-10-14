using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Motorista
    {

        public List<Motorista> Listar()
        {
            List<Motorista> lista = new List<Motorista>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdMotorista,NombreMotorista,Direccion,Correo,Telefono,PerfilSocial,Estado,FechaRegistro from MOTORISTA");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Motorista()
                            {
                                IdMotorista = Convert.ToInt32(dr["IdMotorista"]),
                                NombreMotorista = dr["NombreMotorista"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                PerfilSocial = dr["PerfilSocial"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                            });

                        }

                    }


                }
                catch (Exception ex)
                {

                    lista = new List<Motorista>();
                }
            }

            return lista;

        }




        public int Registrar(Motorista obj, out string Mensaje)
        {
            int idMotoristagenerado = 0;
            Mensaje = string.Empty;
            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_RegistrarMotorista", oconexion);                    
                    cmd.Parameters.AddWithValue("NombreMotorista", obj.NombreMotorista);
                    cmd.Parameters.AddWithValue("Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("PerfilSocial", obj.PerfilSocial);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.AddWithValue("FechaRegistro", obj.FechaRegistro);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idMotoristagenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                idMotoristagenerado = 0;
                Mensaje = ex.Message;
            }



            return idMotoristagenerado;
        }



        public bool Editar(Motorista obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_ModificarMotorista", oconexion);
                    cmd.Parameters.AddWithValue("IdMotorista", obj.IdMotorista);
                    cmd.Parameters.AddWithValue("NombreMotorista", obj.NombreMotorista);
                    cmd.Parameters.AddWithValue("Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("PerfilSocial", obj.PerfilSocial);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.AddWithValue("FechaRegistro", obj.FechaRegistro);
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


        public bool Eliminar(Motorista obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("delete from MOTORISTA where IdMotorista = @id", oconexion);
                    cmd.Parameters.AddWithValue("@id", obj.IdMotorista);
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
