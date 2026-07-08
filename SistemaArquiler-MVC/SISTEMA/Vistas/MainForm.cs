using System;
using System.Drawing;
using System.Windows.Forms;

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

        public MainForm()
        {
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
            this.Size = new Size(1000, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(236, 240, 241);
            
            // panelMenu
            panelMenu.Location = new Point(0, 0);
            panelMenu.Size = new Size(250, 700);
            panelMenu.BackColor = Color.FromArgb(52, 73, 94);
            
            // lblTitulo
            lblTitulo.Text = "🏢 Sistema Residencial";
            lblTitulo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 30);
            lblTitulo.Size = new Size(210, 40);
            panelMenu.Controls.Add(lblTitulo);
            
            // lblUsuario
            lblUsuario.Text = "👤 Usuario: Admin";
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
            panelContent.Size = new Size(750, 700);
            panelContent.BackColor = Color.White;
            
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
            MessageBox.Show("Funcionalidad de cargar apartamentos pendiente de implementación");
        }

        private void CargarInquilinos()
        {
            MessageBox.Show("Funcionalidad de cargar inquilinos pendiente de implementación");
        }

        private void CargarContratos()
        {
            MessageBox.Show("Funcionalidad de cargar contratos pendiente de implementación");
        }

        private void CargarPagos()
        {
            MessageBox.Show("Funcionalidad de cargar pagos pendiente de implementación");
        }

        private void CargarDashboard()
        {
            MessageBox.Show("Funcionalidad de cargar dashboard pendiente de implementación");
        }
    }
}
