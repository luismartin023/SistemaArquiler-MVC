using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestionResidencial.Forms
{
    public partial class LoginForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancelar;
        private Label lblTitulo;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblSistema;
        private PictureBox pictureBoxLogo;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancelar = new Button();
            lblTitulo = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblSistema = new Label();
            Panel panelLogin = new Panel();
            
            SuspendLayout();
            
            // Form
            this.Text = "Login - Sistema de Gestión Residencial";
            this.Size = new Size(450, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            
            // panelLogin
            panelLogin.Location = new Point(50, 50);
            panelLogin.Size = new Size(350, 400);
            panelLogin.BackColor = Color.White;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            
            // lblSistema
            lblSistema.Text = "🏢 Sistema de Gestión";
            lblSistema.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblSistema.ForeColor = Color.FromArgb(52, 152, 219);
            lblSistema.Location = new Point(60, 30);
            lblSistema.Size = new Size(230, 30);
            lblSistema.TextAlign = ContentAlignment.MiddleCenter;
            panelLogin.Controls.Add(lblSistema);
            
            // lblTitulo
            lblTitulo.Text = "Iniciar Sesión";
            lblTitulo.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(45, 52, 54);
            lblTitulo.Location = new Point(60, 80);
            lblTitulo.Size = new Size(230, 40);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            panelLogin.Controls.Add(lblTitulo);
            
            // lblUsername
            lblUsername.Text = "Usuario:";
            lblUsername.Font = new Font("Segoe UI", 10);
            lblUsername.ForeColor = Color.FromArgb(127, 140, 141);
            lblUsername.Location = new Point(50, 150);
            lblUsername.Size = new Size(70, 25);
            panelLogin.Controls.Add(lblUsername);
            
            // txtUsername
            txtUsername.Location = new Point(50, 180);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 30);
            txtUsername.Font = new Font("Segoe UI", 10);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.BackColor = Color.FromArgb(248, 249, 250);
            txtUsername.PlaceholderText = "Ingrese su usuario";
            panelLogin.Controls.Add(txtUsername);
            
            // lblPassword
            lblPassword.Text = "Contraseña:";
            lblPassword.Font = new Font("Segoe UI", 10);
            lblPassword.ForeColor = Color.FromArgb(127, 140, 141);
            lblPassword.Location = new Point(50, 220);
            lblPassword.Size = new Size(80, 25);
            panelLogin.Controls.Add(lblPassword);
            
            // txtPassword
            txtPassword.Location = new Point(50, 250);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 30);
            txtPassword.Font = new Font("Segoe UI", 10);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.BackColor = Color.FromArgb(248, 249, 250);
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "Ingrese su contraseña";
            panelLogin.Controls.Add(txtPassword);
            
            // btnLogin
            btnLogin.Text = "🔐 Iniciar Sesión";
            btnLogin.Location = new Point(50, 310);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 40);
            btnLogin.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnLogin.BackColor = Color.FromArgb(52, 152, 219);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Click += BtnLogin_Click;
            panelLogin.Controls.Add(btnLogin);
            
            // btnCancelar
            btnCancelar.Text = "❌ Cancelar";
            btnCancelar.Location = new Point(50, 360);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(250, 30);
            btnCancelar.Font = new Font("Segoe UI", 9);
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.ForeColor = Color.FromArgb(149, 165, 166);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Click += BtnCancelar_Click;
            panelLogin.Controls.Add(btnCancelar);
            
            // Agregar panel al form
            Controls.Add(panelLogin);
            
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Aquí iría la lógica de autenticación
            MessageBox.Show("Funcionalidad de login pendiente de implementación", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
