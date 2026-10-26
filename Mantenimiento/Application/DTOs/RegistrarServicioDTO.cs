using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class RegistrarServicioDTO
    {
        public RegistrarServicioDTO(string codigo, string descripcion, string direccion, string tecnicoDNI, string ciudadCodigo) 
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Direccion = direccion;
            TecnicoDNI = tecnicoDNI;
            CiudadCodigo = ciudadCodigo;
        }

        public string Codigo { get; private set; }
        public string Descripcion {  get; private set; }
        public string Direccion {  get; private set; }
        public string TecnicoDNI { get; private set; }
        public string CiudadCodigo { get; private set; }
    }
}
