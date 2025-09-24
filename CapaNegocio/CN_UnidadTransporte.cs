using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_UnidadTransporte
    {
        private CD_UnidadTransporte objcd_unidad = new CD_UnidadTransporte();

        // Listar todas las unidades de transporte
        public List<UnidadTransporte> Listar()
        {
            return objcd_unidad.Listar();
        }

        // Registrar una nueva unidad
        public bool Registrar(UnidadTransporte obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.Placa))
            {
                Mensaje = "La placa es obligatoria";
                return false;
            }

            if (obj.AnioFabricacion <= 0)
            {
                Mensaje = "El año de fabricación no es válido";
                return false;
            }

            return objcd_unidad.Registrar(obj, out Mensaje);
        }

        // Buscar por placa
        public UnidadTransporte ObtenerPorPlaca(string placa)
        {
            if (string.IsNullOrWhiteSpace(placa))
            {
                return null;
            }

            return objcd_unidad.ObtenerPorPlaca(placa);
        }

        // Cambiar estado (activo / inactivo)
        public bool CambiarEstado(int idUnidad, bool nuevoEstado)
        {
            return objcd_unidad.CambiarEstado(idUnidad, nuevoEstado);
        }
    }
}
