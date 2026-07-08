using Microsoft.EntityFrameworkCore;
using SistemaGestionResidencial.Data;
using SistemaGestionResidencial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestionResidencial.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ResidencialDbContext _context;

        public Repository(ResidencialDbContext context)
        {
            _context = context;
        }

        public virtual IEnumerable<T> ObtenerTodos()
        {
            return _context.Set<T>().ToList();
        }

        public virtual T? ObtenerPorId(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual void Agregar(T entidad)
        {
            _context.Set<T>().Add(entidad);
            _context.SaveChanges();
        }

        public virtual void Actualizar(T entidad)
        {
            _context.Set<T>().Update(entidad);
            _context.SaveChanges();
        }

        public virtual void Eliminar(int id)
        {
            var entidad = _context.Set<T>().Find(id);
            if (entidad != null)
            {
                _context.Set<T>().Remove(entidad);
                _context.SaveChanges();
            }
        }
    }
}
