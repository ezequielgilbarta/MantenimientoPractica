using Application.DTOs;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    internal static class ServicioMapper
    {
        public static ServicioDetalleDTO ToDetalleDTO(this Servicio s, Tecnico tecnico, Ciudad ciudad) 
        {
            return new ServicioDetalleDTO(
                s.Codigo,
                s.Descripcion,
                s.Direccion,
                tecnico != null ? tecnico.Nombre : "(técnico no encontrado)",
                ciudad != null ? ciudad.Nombre : "(ciudad no encontrada)"
            );
        }

        public static Servicio ToEntity(this RegistrarServicioDTO d)
        {
            return new Servicio(d.Codigo, d.Descripcion, d.Direccion, d.TecnicoDNI, d.CiudadCodigo);
        }
    }
}
