using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Transporte
    {
        public int IdUnidad { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Capacidad { get; set; }
        public string Afabricacion { get; set; }
        public bool Estado { get; set; }
    }
}
