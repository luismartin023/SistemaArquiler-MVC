using SistemaGestionResidencial.Models;
using System.Collections.Generic;

namespace SistemaGestionResidencial.Interfaces
{
    public interface IApartamentoRepository : IRepository<Apartamento>
    {
        IEnumerable<Apartamento> ObtenerPorEstado(EstadoApartamento estado);
    }
}
