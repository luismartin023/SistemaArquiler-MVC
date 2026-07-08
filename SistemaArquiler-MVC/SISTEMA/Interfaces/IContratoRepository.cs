using SistemaGestionResidencial.Models;
using System.Collections.Generic;

namespace SistemaGestionResidencial.Interfaces
{
    public interface IContratoRepository : IRepository<Contrato>
    {
        IEnumerable<Contrato> ObtenerContratosActivos();
        bool TieneContratoActivo(int apartamentoId);
    }
}
