using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestionResidencial.Forms
{
    public partial class DashboardUsuarioForm : Form
    {
        private Label lblTitulo;
        private Label lblNombre;
        private Label lblApartamento;
        private Label lblContrato;
        private Label lblPagos;
        private Label lblNombreValor;
        private Label lblApartamentoValor;
        private Label lblContratoValor;
        private Label lblPagosValor;
        private Panel panelInfo;
        private Panel panelPagos;
        private DataGridView dgvPagosUsuario;

        public DashboardUsuarioForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            lblApartamento = new Label();
            lblContrato = new Label();
            lblPagos = new Label();
            lblNombreValor = new Label();
            lblApartamentoValor = new Label();
            lblContratoValor = new Label();
            lblPagosValor = new Label();
            panelInfo = new Panel();
            panelPagos = new Panel();
            dgvPagosUsuario = new DataGridView();
            
            SuspendLayout();
            
            // Form
            this.Text = "Mi Perfil";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(236, 240, 241);
            
            // lblTitulo
            lblTitulo.Text = "👤 Mi Perfil";
            lblTitulo.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(45, 52, 54);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Size = new Size(200, 40);
            
            // panelInfo
            panelInfo.Location = new Point(30, 80);
            panelInfo.Size = new Size(840, 150);
            panelInfo.BackColor = Color.White;
            panelInfo.BorderStyle = BorderStyle.FixedSingle;
            
            // Info 1: Nombre
            lblNombre.Text = "👤 Nombre:";
            lblNombre.Font = new Font("Segoe UI", 10);
            lblNombre.ForeColor = Color.FromArgb(127, 140, 141);
            lblNombre.Location = new Point(20, 20);
            lblNombre.Size = new Size(100, 25);
            panelInfo.Controls.Add(lblNombre);
            
            lblNombreValor.Text = "Usuario";
            lblNombreValor.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblNombreValor.ForeColor = Color.FromArgb(45, 52, 54);
            lblNombreValor.Location = new Point(120, 20);
            lblNombreValor.Size = new Size(200, 25);
            panelInfo.Controls.Add(lblNombreValor);
            
            // Info 2: Apartamento
            lblApartamento.Text = "🏢 Apartamento:";
            lblApartamento.Font = new Font("Segoe UI", 10);
            lblApartamento.ForeColor = Color.FromArgb(127, 140, 141);
            lblApartamento.Location = new Point(20, 55);
            lblApartamento.Size = new Size(120, 25);
            panelInfo.Controls.Add(lblApartamento);
            
            lblApartamentoValor.Text = "No asignado";
            lblApartamentoValor.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblApartamentoValor.ForeColor = Color.FromArgb(45, 52, 54);
            lblApartamentoValor.Location = new Point(140, 55);
            lblApartamentoValor.Size = new Size(200, 25);
            panelInfo.Controls.Add(lblApartamentoValor);
            
            // Info 3: Contrato
            lblContrato.Text = "📄 Contrato:";
            lblContrato.Font = new Font("Segoe UI", 10);
            lblContrato.ForeColor = Color.FromArgb(127, 140, 141);
            lblContrato.Location = new Point(20, 90);
            lblContrato.Size = new Size(100, 25);
            panelInfo.Controls.Add(lblContrato);
            
            lblContratoValor.Text = "Sin contrato activo";
            lblContratoValor.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblContratoValor.ForeColor = Color.FromArgb(45, 52, 54);
            lblContratoValor.Location = new Point(120, 90);
            lblContratoValor.Size = new Size(200, 25);
            panelInfo.Controls.Add(lblContratoValor);
            
            // Info 4: Pagos
            lblPagos.Text = "💰 Pagos Realizados:";
            lblPagos.Font = new Font("Segoe UI", 10);
            lblPagos.ForeColor = Color.FromArgb(127, 140, 141);
            lblPagos.Location = new Point(450, 20);
            lblPagos.Size = new Size(130, 25);
            panelInfo.Controls.Add(lblPagos);
            
            lblPagosValor.Text = "0";
            lblPagosValor.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            lblPagosValor.ForeColor = Color.FromArgb(46, 204, 113);
            lblPagosValor.Location = new Point(450, 50);
            lblPagosValor.Size = new Size(100, 40);
            panelInfo.Controls.Add(lblPagosValor);
            
            // panelPagos
            panelPagos.Location = new Point(30, 250);
            panelPagos.Size = new Size(840, 300);
            panelPagos.BackColor = Color.White;
            panelPagos.BorderStyle = BorderStyle.FixedSingle;
            
            Label lblPagosHistorial = new Label();
            lblPagosHistorial.Text = "📋 Historial de Pagos";
            lblPagosHistorial.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblPagosHistorial.ForeColor = Color.FromArgb(45, 52, 54);
            lblPagosHistorial.Location = new Point(20, 20);
            lblPagosHistorial.Size = new Size(200, 30);
            panelPagos.Controls.Add(lblPagosHistorial);
            
            // dgvPagosUsuario
            dgvPagosUsuario.Location = new Point(20, 60);
            dgvPagosUsuario.Name = "dgvPagosUsuario";
            dgvPagosUsuario.Size = new Size(800, 220);
            dgvPagosUsuario.BackgroundColor = Color.White;
            dgvPagosUsuario.GridColor = Color.FromArgb(236, 240, 241);
            dgvPagosUsuario.DefaultCellStyle.BackColor = Color.White;
            dgvPagosUsuario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvPagosUsuario.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPagosUsuario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvPagosUsuario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPagosUsuario.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPagosUsuario.EnableHeadersVisualStyles = false;
            dgvPagosUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(244, 246, 247);
            dgvPagosUsuario.ReadOnly = true;
            dgvPagosUsuario.AllowUserToAddRows = false;
            
            // Agregar columnas
            dgvPagosUsuario.Columns.Add("Fecha", "Fecha");
            dgvPagosUsuario.Columns.Add("Monto", "Monto");
            dgvPagosUsuario.Columns.Add("Metodo", "Método");
            dgvPagosUsuario.Columns.Add("Estado", "Estado");
            
            panelPagos.Controls.Add(dgvPagosUsuario);
            
            // Agregar controles al form
            Controls.Add(panelPagos);
            Controls.Add(panelInfo);
            Controls.Add(lblTitulo);
            
            ResumeLayout(false);
            PerformLayout();
        }

        private void CargarInformacion()
        {
            // Implementación pendiente - cargar información del usuario desde el DashboardController
        }
    }
}
