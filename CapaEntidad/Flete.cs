using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Flete
    {
        public int IdFlete { get; set; }
        public Cliente oCliente { get; set; }
        public Transporte oTransporte { get; set; }
        public Motorista oMotorista { get; set; }
        public Estado oEstado { get; set; }
        public decimal Monto { get; set; }
        public string Lrecolecta { get; set; }
        public string Lentrega { get; set; }
        public DateTime Hsalida { get; set; }
        public DateTime Hllegada { get; set; }
        public string Consideraciones { get; set; }
    }
}
