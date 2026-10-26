using Application.Interfaces.Repositories;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ServicioRepository : IServicioRepository
    {
        public Servicio ObtenerServicioPorCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public void RegistrarServicio(Servicio Servicio)
        {
            throw new NotImplementedException();
        }
    }
}
