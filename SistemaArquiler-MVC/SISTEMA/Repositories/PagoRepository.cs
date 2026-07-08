using Microsoft.EntityFrameworkCore;
using SistemaGestionResidencial.Data;
using SistemaGestionResidencial.Interfaces;
using SistemaGestionResidencial.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestionResidencial.Repositories
{
    public class PagoRepository : Repository<Pago>, IPagoRepository
    {
        public PagoRepository(ResidencialDbContext context) : base(context)
        {
        }

        public override IEnumerable<Pago> ObtenerTodos()
        {
            return _context.Set<Pago>()
                .Include(p => p.Contrato)
                .ToList();
        }

        public override Pago? ObtenerPorId(int id)
        {
            return _context.Set<Pago>()
                .Include(p => p.Contrato)
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Pago> ObtenerPagosPorContrato(int contratoId)
        {
            return _context.Set<Pago>()
                .Include(p => p.Contrato)
                .Where(p => p.ContratoId == contratoId)
                .ToList();
        }

        public bool PagoMesRegistrado(int contratoId, int mes, int anio)
        {
            return _context.Set<Pago>().Any(p => p.ContratoId == contratoId &&
                                                 p.FechaPago.Month == mes &&
                                                 p.FechaPago.Year == anio);
        }
    }
}
