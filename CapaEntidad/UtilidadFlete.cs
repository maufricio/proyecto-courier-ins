using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    // Clase para el resumen de utilidad de un flete
    public class UtilidadFlete
    {
        public int IdFlete { get; set; }
        public string NombreCliente { get; set; }
        public string Placa { get; set; }
        public string NombreMotorista { get; set; }
        public decimal ValorFlete { get; set; }
        public decimal TotalGastos { get; set; }
        public decimal UtilidadNeta { get; set; }
        public decimal PorcentajeUtilidad { get; set; }
        public DateTime FechaRegistro { get; set; }
    }

    // Clase para el detalle de gastos por categoría
    public class DetalleGastoFlete
    {
        public int IdFlete { get; set; }
        public string TipoGasto { get; set; }
        public decimal TotalGastosCamion { get; set; }
        public decimal TotalGastosVarios { get; set; }
        public decimal TotalGastosProduccion { get; set; }
    }

    // Clase para el detalle completo de gastos
    public class GastoFlete
    {
        public int IdGasto { get; set; }
        public int IdFlete { get; set; }
        public string TipoGasto { get; set; }
        public string Concepto { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}