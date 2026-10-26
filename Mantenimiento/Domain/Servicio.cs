using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Servicio
    {
        public Servicio(string codigo, string descripcion, string direccion, string tecnicoDNI, string ciudadCodigo) 
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Direccion = direccion;
            TecnicoDNI = tecnicoDNI;
            CiudadCodigo = ciudadCodigo;
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string TecnicoDNI { get; set; }
        public string CiudadCodigo { get; set; }
    }
}
