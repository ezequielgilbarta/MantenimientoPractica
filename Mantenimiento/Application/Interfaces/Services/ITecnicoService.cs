using Application.DTOs;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface ITecnicoService
    {
        List<TecnicoDTO> ObtenerTodosLosTecnicos();
        void RegistrarTecnico(TecnicoDTO dto);
    }
}
