using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SistemaGestionResidencial.Models;
using Microsoft.Extensions.DependencyInjection;

namespace SistemaGestionResidencial.Vistas
{
    public partial class MainForm : Form
    {
        private Button btnApartamentos;
        private Button btnInquilinos;
        private Button btnContratos;
        private Button btnPagos;
        private Button btnDashboard;
        private Button btnSalir;
        private Label lblTitulo;
        private Label lblUsuario;
        private Panel panelMenu;
        private Panel panelContent;

        private readonly IServiceProvider _serviceProvider;
        private Form? _currentForm;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Usuario? UsuarioActual { get; set; }

        public MainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            btnApartamentos = new Button();
            btnInquilinos = new Button();
            btnContratos = new Button();
            btnPagos = new Button();
            btnDashboard = new Button();
            btnSalir = new Button();
            lblTitulo = new Label();
            lblUsuario = new Label();
            panelMenu = new Panel();
            panelContent = new Panel();

            SuspendLayout();

            // Form
            this.Text = "Sistema de Gestión Residencial";
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.MinimumSize = new Size(1000, 600);

            // panelMenu
            panelMenu.Location = new Point(0, 0);
            panelMenu.Size = new Size(250, this.ClientSize.Height);
            panelMenu.BackColor = Color.FromArgb(52, 73, 94);
            panelMenu.Dock = DockStyle.Left;

            // lblTitulo
            lblTitulo.Text = "🏢 Sistema Residencial";
            lblTitulo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 30);
            lblTitulo.Size = new Size(210, 40);
            panelMenu.Controls.Add(lblTitulo);

            // lblUsuario
            lblUsuario.Text = $"👤 {UsuarioActual?.NombreUsuario ?? "Usuario"} ({UsuarioActual?.Rol.ToString() ?? "Sin rol"})";
            lblUsuario.Font = new Font("Segoe UI", 10);
            lblUsuario.ForeColor = Color.FromArgb(189, 195, 199);
            lblUsuario.Location = new Point(20, 80);
            lblUsuario.Size = new Size(210, 25);
            panelMenu.Controls.Add(lblUsuario);

            // btnApartamentos
            btnApartamentos.Text = "🏢 Apartamentos";
            btnApartamentos.Location = new Point(20, 130);
            btnApartamentos.Name = "btnApartamentos";
            btnApartamentos.Size = new Size(210, 50);
            btnApartamentos.Font = new Font("Segoe UI", 11);
            btnApartamentos.BackColor = Color.FromArgb(52, 152, 219);
            btnApartamentos.ForeColor = Color.White;
            btnApartamentos.FlatStyle = FlatStyle.Flat;
            btnApartamentos.FlatAppearance.BorderSize = 0;
            btnApartamentos.Cursor = Cursors.Hand;
            btnApartamentos.TextAlign = ContentAlignment.MiddleLeft;
            btnApartamentos.Padding = new Padding(10, 0, 0, 0);
            btnApartamentos.Click += BtnApartamentos_Click;
            panelMenu.Controls.Add(btnApartamentos);

            // btnInquilinos
            btnInquilinos.Text = "👥 Inquilinos";
            btnInquilinos.Location = new Point(20, 190);
            btnInquilinos.Name = "btnInquilinos";
            btnInquilinos.Size = new Size(210, 50);
            btnInquilinos.Font = new Font("Segoe UI", 11);
            btnInquilinos.BackColor = Color.FromArgb(52, 73, 94);
            btnInquilinos.ForeColor = Color.White;
            btnInquilinos.FlatStyle = FlatStyle.Flat;
            btnInquilinos.FlatAppearance.BorderSize = 0;
            btnInquilinos.Cursor = Cursors.Hand;
            btnInquilinos.TextAlign = ContentAlignment.MiddleLeft;
            btnInquilinos.Padding = new Padding(10, 0, 0, 0);
            btnInquilinos.Click += BtnInquilinos_Click;
            panelMenu.Controls.Add(btnInquilinos);

            // btnContratos
            btnContratos.Text = "📄 Contratos";
            btnContratos.Location = new Point(20, 250);
            btnContratos.Name = "btnContratos";
            btnContratos.Size = new Size(210, 50);
            btnContratos.Font = new Font("Segoe UI", 11);
            btnContratos.BackColor = Color.FromArgb(52, 73, 94);
            btnContratos.ForeColor = Color.White;
            btnContratos.FlatStyle = FlatStyle.Flat;
            btnContratos.FlatAppearance.BorderSize = 0;
            btnContratos.Cursor = Cursors.Hand;
            btnContratos.TextAlign = ContentAlignment.MiddleLeft;
            btnContratos.Padding = new Padding(10, 0, 0, 0);
            btnContratos.Click += BtnContratos_Click;
            panelMenu.Controls.Add(btnContratos);

            // btnPagos
            btnPagos.Text = "💰 Pagos";
            btnPagos.Location = new Point(20, 310);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(210, 50);
            btnPagos.Font = new Font("Segoe UI", 11);
            btnPagos.BackColor = Color.FromArgb(52, 73, 94);
            btnPagos.ForeColor = Color.White;
            btnPagos.FlatStyle = FlatStyle.Flat;
            btnPagos.FlatAppearance.BorderSize = 0;
            btnPagos.Cursor = Cursors.Hand;
            btnPagos.TextAlign = ContentAlignment.MiddleLeft;
            btnPagos.Padding = new Padding(10, 0, 0, 0);
            btnPagos.Click += BtnPagos_Click;
            panelMenu.Controls.Add(btnPagos);

            // btnDashboard
            btnDashboard.Text = "📊 Dashboard";
            btnDashboard.Location = new Point(20, 370);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(210, 50);
            btnDashboard.Font = new Font("Segoe UI", 11);
            btnDashboard.BackColor = Color.FromArgb(52, 73, 94);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Click += BtnDashboard_Click;
            panelMenu.Controls.Add(btnDashboard);

            // btnSalir
            btnSalir.Text = "🚪 Salir";
            btnSalir.Location = new Point(20, 610);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(210, 50);
            btnSalir.Font = new Font("Segoe UI", 11);
            btnSalir.BackColor = Color.FromArgb(231, 76, 60);
            btnSalir.ForeColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.Padding = new Padding(10, 0, 0, 0);
            btnSalir.Click += BtnSalir_Click;
            panelMenu.Controls.Add(btnSalir);

            // panelContent
            panelContent.Location = new Point(250, 0);
            panelContent.Size = new Size(this.ClientSize.Width - 250, this.ClientSize.Height);
            panelContent.BackColor = Color.White;
            panelContent.Dock = DockStyle.Fill;

            // Label de bienvenida en panelContent
            Label lblBienvenida = new Label();
            lblBienvenida.Text = "👋 Bienvenido al Sistema de Gestión Residencial";
            lblBienvenida.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(45, 52, 54);
            lblBienvenida.Location = new Point(50, 100);
            lblBienvenida.Size = new Size(650, 50);
            panelContent.Controls.Add(lblBienvenida);

            Label lblInstrucciones = new Label();
            lblInstrucciones.Text = "Seleccione una opción del menú lateral para comenzar";
            lblInstrucciones.Font = new Font("Segoe UI", 14);
            lblInstrucciones.ForeColor = Color.FromArgb(127, 140, 141);
            lblInstrucciones.Location = new Point(50, 160);
            lblInstrucciones.Size = new Size(650, 30);
            panelContent.Controls.Add(lblInstrucciones);

            // Agregar paneles al form
            Controls.Add(panelContent);
            Controls.Add(panelMenu);

            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnApartamentos_Click(object sender, EventArgs e)
        {
            CargarApartamentos();
        }

        private void BtnInquilinos_Click(object sender, EventArgs e)
        {
            CargarInquilinos();
        }

        private void BtnContratos_Click(object sender, EventArgs e)
        {
            CargarContratos();
        }

        private void BtnPagos_Click(object sender, EventArgs e)
        {
            CargarPagos();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            CargarDashboard();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CargarApartamentos()
        {
            try
            {
                MostrarFormEnPanel<ApartamentoForm>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir formulario de apartamentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarInquilinos()
        {
            try
            {
                MostrarFormEnPanel<InquilinoForm>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir formulario de inquilinos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarContratos()
        {
            try
            {
                MostrarFormEnPanel<ContratoForm>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir formulario de contratos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPagos()
        {
            try
            {
                MostrarFormEnPanel<PagoForm>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir formulario de pagos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDashboard()
        {
            try
            {
                Form dashboardForm;

                if (UsuarioActual?.Rol == Rol.Admin)
                {
                    dashboardForm = _serviceProvider.GetRequiredService<DashboardAdminForm>();
                }
                else if (UsuarioActual?.Rol == Rol.Recepcionista)
                {
                    dashboardForm = _serviceProvider.GetRequiredService<DashboardRecepcionistaForm>();
                }
                else
                {
                    var dashboardUsuario = _serviceProvider.GetRequiredService<DashboardUsuarioForm>();
                    var usuarioProperty = dashboardUsuario.GetType().GetProperty("Usuario");
                    if (usuarioProperty != null && UsuarioActual != null)
                    {
                        usuarioProperty.SetValue(dashboardUsuario, UsuarioActual);
                    }
                    dashboardForm = dashboardUsuario;
                }

                MostrarFormEnPanel(dashboardForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarFormEnPanel<T>() where T : Form
        {
            var form = _serviceProvider.GetRequiredService<T>();
            MostrarFormEnPanel(form);
        }

        private void MostrarFormEnPanel(Form form)
        {
            // Cerrar el formulario actual si existe
            if (_currentForm != null)
            {
                _currentForm.Close();
                _currentForm.Dispose();
            }

            // Configurar el nuevo formulario
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.ShowInTaskbar = false;

            // Limpiar el panel y agregar el nuevo formulario
            panelContent.Controls.Clear();
            panelContent.Controls.Add(form);

            _currentForm = form;
            form.Show();
        }
    }
}
