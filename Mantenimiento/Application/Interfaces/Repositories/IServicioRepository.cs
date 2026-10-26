using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface IServicioRepository
    {
        Servicio ObtenerServicioPorCodigo(string codigo);
        void RegistrarServicio(Servicio Servicio);
    }
}
