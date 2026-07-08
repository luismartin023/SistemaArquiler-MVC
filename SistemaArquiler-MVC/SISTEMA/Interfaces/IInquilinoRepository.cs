using SistemaGestionResidencial.Models;
using System.Collections.Generic;

namespace SistemaGestionResidencial.Interfaces
{
    public interface IInquilinoRepository : IRepository<Inquilino>
    {
        IEnumerable<Inquilino> BuscarPorNombre(string nombre);
        Inquilino? BuscarPorDocumento(string numeroDocumento);
    }
}
