using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using SistemaGestionResidencial.Vistas;
using SistemaGestionResidencial.Services;
using SistemaGestionResidencial.Data;

namespace SistemaGestionResidencial
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configurar Dependency Injection
            var services = new ServiceCollection();
            string connectionString = "Data Source=residencial.db";
            DependencyInjection.ConfigureServices(services, connectionString);

            ServiceProvider = services.BuildServiceProvider();

            // Iniciar aplicación con LoginForm
            var loginForm = ServiceProvider.GetRequiredService<LoginForm>();
            Application.Run(loginForm);
        }
    }
}