using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Tecnico
    {
        public Tecnico(string dni, string nombre, string telefono, string direccion, string especialidad) 
        {
            DNI = dni;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
            Especialidad = especialidad;
        }

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Especialidad { get; set; }
    }
}
