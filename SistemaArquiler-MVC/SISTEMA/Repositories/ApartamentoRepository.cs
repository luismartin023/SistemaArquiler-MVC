using Microsoft.EntityFrameworkCore;
using SistemaGestionResidencial.Data;
using SistemaGestionResidencial.Interfaces;
using SistemaGestionResidencial.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestionResidencial.Repositories
{
    public class ApartamentoRepository : Repository<Apartamento>, IApartamentoRepository
    {
        public ApartamentoRepository(ResidencialDbContext context) : base(context)
        {
        }

        public override IEnumerable<Apartamento> ObtenerTodos()
        {
            return _context.Set<Apartamento>()
                .Include(a => a.Contratos)
                .ToList();
        }

        public override Apartamento? ObtenerPorId(int id)
        {
            return _context.Set<Apartamento>()
                .Include(a => a.Contratos)
                .FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Apartamento> ObtenerPorEstado(EstadoApartamento estado)
        {
            return _context.Set<Apartamento>()
                .Include(a => a.Contratos)
                .Where(a => a.Estado == estado)
                .ToList();
        }
    }
}
