using Application.DTOs;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IServicioService
    {
        ServicioDetalleDTO ObtenerServicioPorCodigo(string codigo);
        List<ServicioDetalleDTO> ObtenerTodosLosServicios();
        void RegistrarServicio(RegistrarServicioDTO dto);
    }
}
