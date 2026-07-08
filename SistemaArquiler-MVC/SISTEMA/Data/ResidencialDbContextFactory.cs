using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SistemaGestionResidencial.Data;

namespace SistemaGestionResidencial.Data
{
    public class ResidencialDbContextFactory : IDesignTimeDbContextFactory<ResidencialDbContext>
    {
        public ResidencialDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ResidencialDbContext>();
            optionsBuilder.UseSqlite("Data Source=residencial.db");
            return new ResidencialDbContext(optionsBuilder.Options);
        }
    }
}
