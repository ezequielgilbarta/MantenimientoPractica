using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ServicioDetalleDTO
    {
        public ServicioDetalleDTO(string codigo, string descripcion, string direccion, string tecnicoNombre, string ciudadNombre) 
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Direccion = direccion;
            TecnicoNombre = tecnicoNombre;
            CiudadNombre = ciudadNombre;
        }

        public string Codigo { get; private set; }
        public string Descripcion { get; private set; }
        public string Direccion { get; private set; }
        public string TecnicoNombre { get; private set; }
        public string CiudadNombre { get; private set; }
    }
}
