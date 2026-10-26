using Application.DTOs;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    internal static class TecnicoMapper
    {
        public static TecnicoDTO ToDTO(this Tecnico t) 
        {
            return new TecnicoDTO(t.DNI, t.Nombre, t.Telefono, t.Direccion, t.Especialidad);
        }

        public static Tecnico ToEntity(this TecnicoDTO d)
        {
            return new Tecnico(d.DNI, d.Nombre, d.Telefono, d.Direccion, d.Especialidad);
        }
    }
}
