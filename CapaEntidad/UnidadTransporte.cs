using System;

namespace CapaEntidad
{
    public class UnidadTransporte
    {
        public int IdUnidad { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public decimal CapacidadToneladas { get; set; }
        public int AnioFabricacion { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
