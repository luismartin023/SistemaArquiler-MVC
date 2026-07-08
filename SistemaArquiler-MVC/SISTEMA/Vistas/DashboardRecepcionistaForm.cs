using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaGestionResidencial.Interfaces;
using SistemaGestionResidencial.Models;

namespace SistemaGestionResidencial.Vistas
{
    public partial class DashboardRecepcionistaForm : Form
    {
        private Label lblTitulo;
        private Label lblPagosPendientes;
        private Label lblContratosProximosVencer;
        private Label lblPagosPendientesValor;
        private Label lblContratosProximosVencerValor;
        private Panel panelMetricas;
        private Panel panelAcciones;

        private readonly IContratoRepository _contratoRepository;
        private readonly IPagoRepository _pagoRepository;

        public DashboardRecepcionistaForm(IContratoRepository contratoRepository, IPagoRepository pagoRepository)
        {
            _contratoRepository = contratoRepository;
            _pagoRepository = pagoRepository;
            InitializeComponent();
            CargarMetricas();
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblPagosPendientes = new Label();
            lblContratosProximosVencer = new Label();
            lblPagosPendientesValor = new Label();
            lblContratosProximosVencerValor = new Label();
            panelMetricas = new Panel();
            panelAcciones = new Panel();

            SuspendLayout();

            // Form
            this.Text = "Dashboard Recepcionista";
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

            // Metrica 1: Pagos Pendientes
            lblPagosPendientes.Text = "💳 Pagos Pendientes";
            lblPagosPendientes.Font = new Font("Segoe UI", 10);
            lblPagosPendientes.ForeColor = Color.FromArgb(127, 140, 141);
            lblPagosPendientes.Location = new Point(20, 20);
            lblPagosPendientes.Size = new Size(180, 25);
            panelMetricas.Controls.Add(lblPagosPendientes);

            lblPagosPendientesValor.Text = "0";
            lblPagosPendientesValor.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            lblPagosPendientesValor.ForeColor = Color.FromArgb(231, 76, 60);
            lblPagosPendientesValor.Location = new Point(20, 50);
            lblPagosPendientesValor.Size = new Size(180, 40);
            panelMetricas.Controls.Add(lblPagosPendientesValor);

            // Metrica 2: Contratos Próximos a Vencer
            lblContratosProximosVencer.Text = "⏰ Contratos por Vencer";
            lblContratosProximosVencer.Font = new Font("Segoe UI", 10);
            lblContratosProximosVencer.ForeColor = Color.FromArgb(127, 140, 141);
            lblContratosProximosVencer.Location = new Point(220, 20);
            lblContratosProximosVencer.Size = new Size(200, 25);
            panelMetricas.Controls.Add(lblContratosProximosVencer);

            lblContratosProximosVencerValor.Text = "0";
            lblContratosProximosVencerValor.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            lblContratosProximosVencerValor.ForeColor = Color.FromArgb(241, 196, 15);
            lblContratosProximosVencerValor.Location = new Point(220, 50);
            lblContratosProximosVencerValor.Size = new Size(200, 40);
            panelMetricas.Controls.Add(lblContratosProximosVencerValor);

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
                // Pagos Pendientes (contratos activos sin pago este mes)
                var contratosActivos = _contratoRepository.ObtenerContratosActivos();
                int pagosPendientes = 0;

                foreach (var contrato in contratosActivos)
                {
                    var pagosMes = _pagoRepository.ObtenerPagosPorContrato(contrato.Id)
                        .Where(p => p.FechaPago.Month == DateTime.Now.Month && p.FechaPago.Year == DateTime.Now.Year)
                        .Count();

                    if (pagosMes == 0)
                        pagosPendientes++;
                }

                lblPagosPendientesValor.Text = pagosPendientes.ToString();

                // Contratos Próximos a Vencer (menos de 30 días)
                var contratosProximosVencer = contratosActivos
                    .Where(c => (c.FechaFin - DateTime.Now).Days <= 30 && (c.FechaFin - DateTime.Now).Days > 0)
                    .Count();

                lblContratosProximosVencerValor.Text = contratosProximosVencer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar métricas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
