using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CalculosUtil
    {
        public int IdGasto { get; set; }
        public int IdFlete { get; set; } //foreign key
        public string TipoGasto { get; set; }
        public string Concepto { get; set; }
        public decimal Monto { get; set; }
        public int Cantidad { get; set; } // Para items que se compran por cantidad

        // Constructor
        public CalculosUtil()
        {
            IdGasto = 0;
            Cantidad = 1;
            Monto = 0;
        }
    }
}
