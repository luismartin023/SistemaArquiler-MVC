using Microsoft.EntityFrameworkCore;
using SistemaGestionResidencial.Data;
using SistemaGestionResidencial.Interfaces;
using SistemaGestionResidencial.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestionResidencial.Repositories
{
    public class ContratoRepository : Repository<Contrato>, IContratoRepository
    {
        public ContratoRepository(ResidencialDbContext context) : base(context)
        {
        }

        public override IEnumerable<Contrato> ObtenerTodos()
        {
            return _context.Set<Contrato>()
                .Include(c => c.Apartamento)
                .Include(c => c.Inquilino)
                .Include(c => c.Pagos)
                .ToList();
        }

        public override Contrato? ObtenerPorId(int id)
        {
            return _context.Set<Contrato>()
                .Include(c => c.Apartamento)
                .Include(c => c.Inquilino)
                .Include(c => c.Pagos)
                .FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Contrato> ObtenerContratosActivos()
        {
            return _context.Set<Contrato>()
                .Include(c => c.Apartamento)
                .Include(c => c.Inquilino)
                .Where(c => c.Estado == "Activo")
                .ToList();
        }

        public bool TieneContratoActivo(int apartamentoId)
        {
            return _context.Set<Contrato>().Any(c => c.ApartamentoId == apartamentoId && c.Estado == "Activo");
        }
    }
}
