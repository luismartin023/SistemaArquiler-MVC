using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaGestionResidencial.Data;
using SistemaGestionResidencial.Interfaces;
using SistemaGestionResidencial.Repositories;
using SistemaGestionResidencial.Controllers;
using SistemaGestionResidencial.Vistas;

namespace SistemaGestionResidencial.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureServices(IServiceCollection services, string connectionString)
        {
            // DbContext
            services.AddDbContext<ResidencialDbContext>(options =>
                options.UseSqlite(connectionString));

            // Repositories
            services.AddScoped<IRepository<Apartamento>, ApartamentoRepository>();
            services.AddScoped<IApartamentoRepository, ApartamentoRepository>();
            services.AddScoped<IRepository<Inquilino>, InquilinoRepository>();
            services.AddScoped<IInquilinoRepository, InquilinoRepository>();
            services.AddScoped<IRepository<Contrato>, ContratoRepository>();
            services.AddScoped<IContratoRepository, ContratoRepository>();
            services.AddScoped<IRepository<Pago>, PagoRepository>();
            services.AddScoped<IPagoRepository, PagoRepository>();

            // Controllers
            services.AddScoped<ApartamentoController>();
            services.AddScoped<InquilinoController>();
            services.AddScoped<ContratoController>();
            services.AddScoped<PagoController>();
            services.AddScoped<AuthController>();
            services.AddScoped<DashboardController>();

            // Forms (Vistas)
            services.AddScoped<LoginForm>();
            services.AddScoped<MainForm>();
            services.AddScoped<ApartamentoForm>();
            services.AddScoped<InquilinoForm>();
            services.AddScoped<ContratoForm>();
            services.AddScoped<PagoForm>();
            services.AddScoped<DashboardAdminForm>();
            services.AddScoped<DashboardRecepcionistaForm>();
            services.AddScoped<DashboardUsuarioForm>();
            services.AddScoped<CambiarPasswordForm>();

            return services;
        }
    }
}
