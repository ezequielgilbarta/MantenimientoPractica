using Application.Interfaces.Repositories;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class TecnicoRepository : ITecnicoRepository
    {
        public static TecnicoRepository Instance { get; } = new TecnicoRepository();
        private TecnicoRepository() 
        {

        }
        private readonly List<Tecnico> _tecnicos = new List<Tecnico>();

        public Tecnico ObtenerTecnicoPorDNI(string dni)
        {
            return _tecnicos.FirstOrDefault(t => t.DNI.Equals(dni, StringComparison.OrdinalIgnoreCase));
        }

        public List<Tecnico> ObtenerTecnicos()
        {
            return _tecnicos;
        }

        public void RegistrarTecnico(Tecnico tecnico)
        {
            _tecnicos.Add(tecnico);
        }
    }
}
