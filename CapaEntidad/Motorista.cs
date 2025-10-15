using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Motorista
    {
        public int IdMotorista { get; set; }
        public string NombreMotorista { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string PerfilSocial { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
