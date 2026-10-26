using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface ITecnicoRepository
    {
        Tecnico ObtenerTecnicoPorDNI(string dni);
        List<Tecnico> ObtenerTecnicos();
        void RegistrarTecnico(Tecnico tecnico);
    }
}
