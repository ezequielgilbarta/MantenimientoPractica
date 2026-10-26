using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class TecnicoDTO
    {
        public TecnicoDTO(string dni, string nombre, string telefono, string direccion, string especialidad) 
        {
            DNI = dni;
            Nombre = nombre;
            Telefono = telefono;
            Direccion= direccion;
            Especialidad = especialidad;
        }
        public string DNI { get; private set; }
        public string Nombre { get; private set; }
        public string Telefono { get; private set; }
        public string Direccion {  get; private set; }
        public string Especialidad { get; private set; }

    }
}
