using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaGestionResidencial.Controllers;
using SistemaGestionResidencial.Models;

namespace SistemaGestionResidencial.Vistas
{
    public partial class CambiarPasswordForm : Form
    {
        private TextBox txtPasswordActual;
        private TextBox txtPasswordNueva;
        private TextBox txtConfirmarPassword;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblTitulo;
        private Label lblPasswordActual;
        private Label lblPasswordNueva;
        private Label lblConfirmarPassword;
        private Panel panelFormulario;

        private readonly AuthController _authController;
        private readonly Usuario _usuario;

        public CambiarPasswordForm(AuthController authController, Usuario usuario)
        {
            _authController = authController;
            _usuario = usuario;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            txtPasswordActual = new TextBox();
            txtPasswordNueva = new TextBox();
            txtConfirmarPassword = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblTitulo = new Label();
            lblPasswordActual = new Label();
            lblPasswordNueva = new Label();
            lblConfirmarPassword = new Label();
            panelFormulario = new Panel();

            SuspendLayout();

            // Form
            this.Text = "Cambiar Contraseña";
            this.Size = new Size(450, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // panelFormulario
            panelFormulario.Location = new Point(50, 50);
            panelFormulario.Size = new Size(350, 300);
            panelFormulario.BackColor = Color.White;
            panelFormulario.BorderStyle = BorderStyle.FixedSingle;

            // lblTitulo
            lblTitulo.Text = "🔐 Cambiar Contraseña";
            lblTitulo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(45, 52, 54);
            lblTitulo.Location = new Point(60, 30);
            lblTitulo.Size = new Size(230, 30);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            panelFormulario.Controls.Add(lblTitulo);

            // lblPasswordActual
            lblPasswordActual.Text = "Contraseña Actual:";
            lblPasswordActual.Font = new Font("Segoe UI", 10);
            lblPasswordActual.ForeColor = Color.FromArgb(127, 140, 141);
            lblPasswordActual.Location = new Point(30, 80);
            lblPasswordActual.Size = new Size(120, 25);
            panelFormulario.Controls.Add(lblPasswordActual);

            // txtPasswordActual
            txtPasswordActual.Location = new Point(30, 110);
            txtPasswordActual.Name = "txtPasswordActual";
            txtPasswordActual.Size = new Size(290, 30);
            txtPasswordActual.Font = new Font("Segoe UI", 10);
            txtPasswordActual.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordActual.BackColor = Color.FromArgb(248, 249, 250);
            txtPasswordActual.PasswordChar = '•';
            panelFormulario.Controls.Add(txtPasswordActual);

            // lblPasswordNueva
            lblPasswordNueva.Text = "Nueva Contraseña:";
            lblPasswordNueva.Font = new Font("Segoe UI", 10);
            lblPasswordNueva.ForeColor = Color.FromArgb(127, 140, 141);
            lblPasswordNueva.Location = new Point(30, 150);
            lblPasswordNueva.Size = new Size(120, 25);
            panelFormulario.Controls.Add(lblPasswordNueva);

            // txtPasswordNueva
            txtPasswordNueva.Location = new Point(30, 180);
            txtPasswordNueva.Name = "txtPasswordNueva";
            txtPasswordNueva.Size = new Size(290, 30);
            txtPasswordNueva.Font = new Font("Segoe UI", 10);
            txtPasswordNueva.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordNueva.BackColor = Color.FromArgb(248, 249, 250);
            txtPasswordNueva.PasswordChar = '•';
            panelFormulario.Controls.Add(txtPasswordNueva);

            // lblConfirmarPassword
            lblConfirmarPassword.Text = "Confirmar Contraseña:";
            lblConfirmarPassword.Font = new Font("Segoe UI", 10);
            lblConfirmarPassword.ForeColor = Color.FromArgb(127, 140, 141);
            lblConfirmarPassword.Location = new Point(30, 220);
            lblConfirmarPassword.Size = new Size(140, 25);
            panelFormulario.Controls.Add(lblConfirmarPassword);

            // txtConfirmarPassword
            txtConfirmarPassword.Location = new Point(30, 250);
            txtConfirmarPassword.Name = "txtConfirmarPassword";
            txtConfirmarPassword.Size = new Size(290, 30);
            txtConfirmarPassword.Font = new Font("Segoe UI", 10);
            txtConfirmarPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarPassword.BackColor = Color.FromArgb(248, 249, 250);
            txtConfirmarPassword.PasswordChar = '•';
            panelFormulario.Controls.Add(txtConfirmarPassword);

            // btnGuardar
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.Location = new Point(30, 310);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 35);
            btnGuardar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnGuardar.BackColor = Color.FromArgb(46, 204, 113);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Click += BtnGuardar_Click;
            panelFormulario.Controls.Add(btnGuardar);

            // btnCancelar
            btnCancelar.Text = "❌ Cancelar";
            btnCancelar.Location = new Point(180, 310);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 35);
            btnCancelar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnCancelar.BackColor = Color.FromArgb(231, 76, 60);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Click += BtnCancelar_Click;
            panelFormulario.Controls.Add(btnCancelar);

            // Agregar panel al form
            Controls.Add(panelFormulario);

            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPasswordActual.Text) ||
                    string.IsNullOrWhiteSpace(txtPasswordNueva.Text) ||
                    string.IsNullOrWhiteSpace(txtConfirmarPassword.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtPasswordNueva.Text != txtConfirmarPassword.Text)
                {
                    MessageBox.Show("Las contraseñas nuevas no coinciden", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _authController.CambiarPassword(_usuario.NombreUsuario, txtPasswordActual.Text, txtPasswordNueva.Text);
                MessageBox.Show("Contraseña cambiada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar contraseña: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
