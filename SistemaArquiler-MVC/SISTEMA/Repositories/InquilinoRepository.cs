using Microsoft.EntityFrameworkCore;
using SistemaGestionResidencial.Data;
using SistemaGestionResidencial.Interfaces;
using SistemaGestionResidencial.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestionResidencial.Repositories
{
    public class InquilinoRepository : Repository<Inquilino>, IInquilinoRepository
    {
        public InquilinoRepository(ResidencialDbContext context) : base(context)
        {
        }

        public override IEnumerable<Inquilino> ObtenerTodos()
        {
            return _context.Set<Inquilino>()
                .Include(i => i.Contratos)
                .ToList();
        }

        public override Inquilino? ObtenerPorId(int id)
        {
            return _context.Set<Inquilino>()
                .Include(i => i.Contratos)
                .FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<Inquilino> BuscarPorNombre(string nombre)
        {
            return _context.Set<Inquilino>()
                .Include(i => i.Contratos)
                .Where(i => i.Nombre.Contains(nombre) || i.Apellido.Contains(nombre))
                .ToList();
        }

        public Inquilino? BuscarPorDocumento(string numeroDocumento)
        {
            return _context.Set<Inquilino>()
                .Include(i => i.Contratos)
                .FirstOrDefault(i => i.NumeroDocumento == numeroDocumento);
        }
    }
}
