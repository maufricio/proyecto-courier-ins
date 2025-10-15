using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {

        private CD_Cliente clienteRepositorio = new CD_Cliente();


        public List<Cliente> Listar()
        {
            return clienteRepositorio.Listar();
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.NombreCliente == "")
            {
                Mensaje += "Nombre de cliente requerido para ingresar.\n";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Dirección del cliente requerido para ingresar.\n";
            }

            if(obj.Correo == "")
            {
                Mensaje += "Es necesario ingresar el correo del cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                obj.FechaRegistro = DateTime.Now; // Asigna la fecha y hora actual al registrar un nuevo cliente
                return clienteRepositorio.Registrar(obj, out Mensaje); // Si todo está bien, llama al método de la capa de datos para registrar el cliente
            }


        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.NombreCliente == "")
            {
                Mensaje += "Nombre de cliente requerido para ingresar.\n";
            }
            if (obj.Direccion == "")
            {
                Mensaje += "Dirección del cliente requerido para ingresar.\n";
            }
            if (obj.Correo == "")
            {
                Mensaje += "Es necesario ingresar el correo del cliente\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return clienteRepositorio.Editar(obj, out Mensaje); // Si todo está bien, llama al método de la capa de datos para registrar el cliente
            }
        }

        public bool Eliminar(int id, out string Mensaje)
        {
            return clienteRepositorio.Eliminar(id, out Mensaje);
        }

    }
}
