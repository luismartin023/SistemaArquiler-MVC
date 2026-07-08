using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaGestionResidencial.Interfaces;
using SistemaGestionResidencial.Models;

namespace SistemaGestionResidencial.Vistas
{
    public partial class DashboardAdminForm : Form
    {
        private Label lblTitulo;
        private Label lblTotalApartamentos;
        private Label lblApartamentosDisponibles;
        private Label lblContratosActivos;
        private Label lblPagosMes;
        private Label lblTotalApartamentosValor;
        private Label lblApartamentosDisponiblesValor;
        private Label lblContratosActivosValor;
        private Label lblPagosMesValor;
        private Panel panelMetricas;
        private Panel panelGraficos;

        private readonly IApartamentoRepository _apartamentoRepository;
        private readonly IContratoRepository _contratoRepository;
        private readonly IPagoRepository _pagoRepository;

        public DashboardAdminForm(IApartamentoRepository apartamentoRepository, IContratoRepository contratoRepository, IPagoRepository pagoRepository)
        {
            _apartamentoRepository = apartamentoRepository;
            _contratoRepository = contratoRepository;
            _pagoRepository = pagoRepository;
            InitializeComponent();
            CargarMetricas();
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblTotalApartamentos = new Label();
            lblApartamentosDisponibles = new Label();
            lblContratosActivos = new Label();
            lblPagosMes = new Label();
            lblTotalApartamentosValor = new Label();
            lblApartamentosDisponiblesValor = new Label();
            lblContratosActivosValor = new Label();
            lblPagosMesValor = new Label();
            panelMetricas = new Panel();
            panelGraficos = new Panel();

            SuspendLayout();

            // Form
            this.Text = "Dashboard Admin";
            this.Size = new Size(920, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(248, 249, 250);
            this.AutoScroll = true;

            // lblTitulo
            lblTitulo.Text = "🏢 SISTEMA DE GESTIÓN RESIDENCIAL";
            lblTitulo.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(45, 52, 54);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Size = new Size(800, 50);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // panelMetricas
            panelMetricas.Location = new Point(30, 80);
            panelMetricas.Size = new Size(840, 150);
            panelMetricas.BackColor = Color.White;
            panelMetricas.BorderStyle = BorderStyle.FixedSingle;

            // Metrica 1: Total Apartamentos
            lblTotalApartamentos.Text = "🏢 Total Apartamentos";
            lblTotalApartamentos.Font = new Font("Segoe UI", 10);
            lblTotalApartamentos.ForeColor = Color.FromArgb(127, 140, 141);
            lblTotalApartamentos.Location = new Point(20, 20);
            lblTotalApartamentos.Size = new Size(180, 25);
            panelMetricas.Controls.Add(lblTotalApartamentos);

            lblTotalApartamentosValor.Text = "0";
            lblTotalApartamentosValor.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            lblTotalApartamentosValor.ForeColor = Color.FromArgb(52, 152, 219);
            lblTotalApartamentosValor.Location = new Point(20, 50);
            lblTotalApartamentosValor.Size = new Size(180, 40);
            panelMetricas.Controls.Add(lblTotalApartamentosValor);

            // Metrica 2: Apartamentos Disponibles
            lblApartamentosDisponibles.Text = "✅ Disponibles";
            lblApartamentosDisponibles.Font = new Font("Segoe UI", 10);
            lblApartamentosDisponibles.ForeColor = Color.FromArgb(127, 140, 141);
            lblApartamentosDisponibles.Location = new Point(220, 20);
            lblApartamentosDisponibles.Size = new Size(180, 25);
            panelMetricas.Controls.Add(lblApartamentosDisponibles);

            lblApartamentosDisponiblesValor.Text = "0";
            lblApartamentosDisponiblesValor.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            lblApartamentosDisponiblesValor.ForeColor = Color.FromArgb(46, 204, 113);
            lblApartamentosDisponiblesValor.Location = new Point(220, 50);
            lblApartamentosDisponiblesValor.Size = new Size(180, 40);
            panelMetricas.Controls.Add(lblApartamentosDisponiblesValor);

            // Metrica 3: Contratos Activos
            lblContratosActivos.Text = "📄 Contratos Activos";
            lblContratosActivos.Font = new Font("Segoe UI", 10);
            lblContratosActivos.ForeColor = Color.FromArgb(127, 140, 141);
            lblContratosActivos.Location = new Point(420, 20);
            lblContratosActivos.Size = new Size(180, 25);
            panelMetricas.Controls.Add(lblContratosActivos);

            lblContratosActivosValor.Text = "0";
            lblContratosActivosValor.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            lblContratosActivosValor.ForeColor = Color.FromArgb(241, 196, 15);
            lblContratosActivosValor.Location = new Point(420, 50);
            lblContratosActivosValor.Size = new Size(180, 40);
            panelMetricas.Controls.Add(lblContratosActivosValor);

            // Metrica 4: Pagos del Mes
            lblPagosMes.Text = "💰 Pagos del Mes";
            lblPagosMes.Font = new Font("Segoe UI", 10);
            lblPagosMes.ForeColor = Color.FromArgb(127, 140, 141);
            lblPagosMes.Location = new Point(620, 20);
            lblPagosMes.Size = new Size(180, 25);
            panelMetricas.Controls.Add(lblPagosMes);

            lblPagosMesValor.Text = "0";
            lblPagosMesValor.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            lblPagosMesValor.ForeColor = Color.FromArgb(155, 89, 182);
            lblPagosMesValor.Location = new Point(620, 50);
            lblPagosMesValor.Size = new Size(180, 40);
            panelMetricas.Controls.Add(lblPagosMesValor);

            // Agregar controles al form
            Controls.Add(panelMetricas);
            Controls.Add(lblTitulo);

            ResumeLayout(false);
            PerformLayout();
        }

        private void CargarMetricas()
        {
            try
            {
                // Total Apartamentos
                var totalApartamentos = _apartamentoRepository.ObtenerTodos().Count();
                lblTotalApartamentosValor.Text = totalApartamentos.ToString();

                // Apartamentos Disponibles
                var disponibles = _apartamentoRepository.ObtenerPorEstado(EstadoApartamento.Disponible).Count();
                lblApartamentosDisponiblesValor.Text = disponibles.ToString();

                // Contratos Activos
                var contratosActivos = _contratoRepository.ObtenerContratosActivos().Count();
                lblContratosActivosValor.Text = contratosActivos.ToString();

                // Pagos del Mes
                var pagosMes = _pagoRepository.ObtenerTodos()
                    .Where(p => p.FechaPago.Month == DateTime.Now.Month && p.FechaPago.Year == DateTime.Now.Year)
                    .Sum(p => p.Monto);
                lblPagosMesValor.Text = pagosMes.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar métricas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
