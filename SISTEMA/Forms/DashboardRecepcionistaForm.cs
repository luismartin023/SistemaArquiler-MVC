using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestionResidencial.Forms
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

        public DashboardRecepcionistaForm()
        {
            InitializeComponent();
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
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(236, 240, 241);
            
            // lblTitulo
            lblTitulo.Text = "📋 Dashboard Recepcionista";
            lblTitulo.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(45, 52, 54);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Size = new Size(400, 40);
            
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
            
            // panelAcciones
            panelAcciones.Location = new Point(30, 250);
            panelAcciones.Size = new Size(840, 300);
            panelAcciones.BackColor = Color.White;
            panelAcciones.BorderStyle = BorderStyle.FixedSingle;
            
            Label lblAcciones = new Label();
            lblAcciones.Text = "⚡ Acciones Rápidas";
            lblAcciones.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblAcciones.ForeColor = Color.FromArgb(45, 52, 54);
            lblAcciones.Location = new Point(20, 20);
            lblAcciones.Size = new Size(200, 30);
            panelAcciones.Controls.Add(lblAcciones);
            
            // Botones de acción rápida
            Button btnRegistrarPago = new Button();
            btnRegistrarPago.Text = "💰 Registrar Pago";
            btnRegistrarPago.Location = new Point(20, 70);
            btnRegistrarPago.Size = new Size(200, 50);
            btnRegistrarPago.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnRegistrarPago.BackColor = Color.FromArgb(46, 204, 113);
            btnRegistrarPago.ForeColor = Color.White;
            btnRegistrarPago.FlatStyle = FlatStyle.Flat;
            btnRegistrarPago.FlatAppearance.BorderSize = 0;
            btnRegistrarPago.Cursor = Cursors.Hand;
            panelAcciones.Controls.Add(btnRegistrarPago);
            
            Button btnNuevoContrato = new Button();
            btnNuevoContrato.Text = "📄 Nuevo Contrato";
            btnNuevoContrato.Location = new Point(240, 70);
            btnNuevoContrato.Size = new Size(200, 50);
            btnNuevoContrato.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnNuevoContrato.BackColor = Color.FromArgb(52, 152, 219);
            btnNuevoContrato.ForeColor = Color.White;
            btnNuevoContrato.FlatStyle = FlatStyle.Flat;
            btnNuevoContrato.FlatAppearance.BorderSize = 0;
            btnNuevoContrato.Cursor = Cursors.Hand;
            panelAcciones.Controls.Add(btnNuevoContrato);
            
            Button btnVerInquilinos = new Button();
            btnVerInquilinos.Text = "👥 Ver Inquilinos";
            btnVerInquilinos.Location = new Point(460, 70);
            btnVerInquilinos.Size = new Size(200, 50);
            btnVerInquilinos.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnVerInquilinos.BackColor = Color.FromArgb(155, 89, 182);
            btnVerInquilinos.ForeColor = Color.White;
            btnVerInquilinos.FlatStyle = FlatStyle.Flat;
            btnVerInquilinos.FlatAppearance.BorderSize = 0;
            btnVerInquilinos.Cursor = Cursors.Hand;
            panelAcciones.Controls.Add(btnVerInquilinos);
            
            Label lblInfo = new Label();
            lblInfo.Text = "📌 Utilice estas acciones para realizar tareas comunes rápidamente";
            lblInfo.Font = new Font("Segoe UI", 10);
            lblInfo.ForeColor = Color.FromArgb(127, 140, 141);
            lblInfo.Location = new Point(20, 140);
            lblInfo.Size = new Size(800, 30);
            panelAcciones.Controls.Add(lblInfo);
            
            // Agregar controles al form
            Controls.Add(panelAcciones);
            Controls.Add(panelMetricas);
            Controls.Add(lblTitulo);
            
            ResumeLayout(false);
            PerformLayout();
        }

        private void CargarMetricas()
        {
            // Implementación pendiente - cargar métricas desde el DashboardController
        }
    }
}
