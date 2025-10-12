using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    // Clase que representa un cliente en el sistema - POCO (Plain Old C Object)
    public class Cliente
    {

        public Cliente()
        {
            // Constructor por defecto
            this.IdCliente = 0;
            this.NombreCliente = string.Empty;
            this.Direccion = string.Empty;
            this.Correo = string.Empty;
            this.Estado = 0; // 0: Inactivo, 1: Activo
            this.FechaRegistro = DateTime.Now;
        }


        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }

        public string Correo { get; set; }
        public int Estado { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
