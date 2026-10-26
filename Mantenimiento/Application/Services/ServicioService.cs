using Application.DTOs;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ServicioService : IServicioService
    {
        public ServicioDetalleDTO ObtenerServicioPorCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public List<ServicioDetalleDTO> ObtenerTodosLosServicios()
        {
            throw new NotImplementedException();
        }

        public void RegistrarServicio(RegistrarServicioDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
