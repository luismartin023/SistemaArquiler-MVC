using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaGestionResidencial.Interfaces;
using SistemaGestionResidencial.Models;

namespace SistemaGestionResidencial.Vistas
{
    public partial class InquilinoForm : Form
    {
        private DataGridView dgvInquilinos;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNumeroDocumento;
        private ComboBox cmbTipoDocumento;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtBusqueda;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnBuscar;
        private Label lblTitulo;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblNumeroDocumento;
        private Label lblTipoDocumento;
        private Label lblTelefono;
        private Label lblEmail;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

        private readonly IInquilinoRepository _inquilinoRepository;

        public InquilinoForm(IInquilinoRepository inquilinoRepository)
        {
            _inquilinoRepository = inquilinoRepository;
            InitializeComponent();
            CargarInquilinos();
        }

        private void InitializeComponent()
        {
            dgvInquilinos = new DataGridView();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNumeroDocumento = new TextBox();
            cmbTipoDocumento = new ComboBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            lblTitulo = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblNumeroDocumento = new Label();
            lblTipoDocumento = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            Panel panelFormulario = new Panel();
            Label lblFormulario = new Label();
            Panel panelBusqueda = new Panel();
            Label lblBusqueda = new Label();
            TextBox txtBusqueda = new TextBox();
            Button btnBuscarPanel = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvInquilinos).BeginInit();
            SuspendLayout();

            // Form
            this.BackColor = Color.FromArgb(248, 249, 250);
            this.AutoScroll = true;

            // lblTitulo
            lblTitulo.Text = "👥 Gestión de Inquilinos";
            lblTitulo.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(45, 52, 54);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Size = new Size(400, 40);
            lblTitulo.TabIndex = 0;

            // panelBusqueda
            panelBusqueda.Location = new Point(20, 70);
            panelBusqueda.Size = new Size(880, 50);
            panelBusqueda.BackColor = Color.White;
            panelBusqueda.BorderStyle = BorderStyle.FixedSingle;

            // lblBusqueda
            lblBusqueda.Text = "🔍 Buscar:";
            lblBusqueda.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblBusqueda.ForeColor = Color.FromArgb(45, 52, 54);
            lblBusqueda.Location = new Point(15, 15);
            lblBusqueda.Size = new Size(70, 25);
            panelBusqueda.Controls.Add(lblBusqueda);

            // txtBusqueda
            txtBusqueda.Location = new Point(90, 12);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(400, 25);
            txtBusqueda.Font = new Font("Segoe UI", 9);
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.BackColor = Color.White;
            txtBusqueda.PlaceholderText = "Buscar por nombre, documento...";
            panelBusqueda.Controls.Add(txtBusqueda);

            // btnBuscarPanel
            btnBuscarPanel.Text = "🔎 Buscar";
            btnBuscarPanel.Location = new Point(500, 10);
            btnBuscarPanel.Name = "btnBuscarPanel";
            btnBuscarPanel.Size = new Size(100, 30);
            btnBuscarPanel.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnBuscarPanel.BackColor = Color.FromArgb(52, 152, 219);
            btnBuscarPanel.ForeColor = Color.White;
            btnBuscarPanel.FlatStyle = FlatStyle.Flat;
            btnBuscarPanel.FlatAppearance.BorderSize = 0;
            btnBuscarPanel.Cursor = Cursors.Hand;
            btnBuscarPanel.Click += BtnBuscar_Click;
            panelBusqueda.Controls.Add(btnBuscarPanel);

            // dgvInquilinos
            dgvInquilinos.ColumnHeadersHeight = 40;
            dgvInquilinos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgvInquilinos.Location = new Point(20, 130);
            dgvInquilinos.Name = "dgvInquilinos";
            dgvInquilinos.RowHeadersWidth = 40;
            dgvInquilinos.Size = new Size(880, 300);
            dgvInquilinos.TabIndex = 1;
            dgvInquilinos.BackgroundColor = Color.White;
            dgvInquilinos.GridColor = Color.FromArgb(236, 240, 241);
            dgvInquilinos.DefaultCellStyle.BackColor = Color.White;
            dgvInquilinos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvInquilinos.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvInquilinos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvInquilinos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInquilinos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvInquilinos.EnableHeadersVisualStyles = false;
            dgvInquilinos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(244, 246, 247);

            // panelFormulario
            panelFormulario.Location = new Point(20, 450);
            panelFormulario.Size = new Size(880, 250);
            panelFormulario.BackColor = Color.White;
            panelFormulario.BorderStyle = BorderStyle.FixedSingle;

            // lblFormulario
            lblFormulario.Text = "📝 Nuevo Inquilino";
            lblFormulario.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblFormulario.ForeColor = Color.FromArgb(45, 52, 54);
            lblFormulario.Location = new Point(15, 10);
            lblFormulario.Size = new Size(180, 25);
            panelFormulario.Controls.Add(lblFormulario);

            // lblNombre
            lblNombre.Text = "Nombre:";
            lblNombre.Font = new Font("Segoe UI", 9);
            lblNombre.ForeColor = Color.FromArgb(127, 140, 141);
            lblNombre.Location = new Point(30, 50);
            lblNombre.Size = new Size(60, 20);
            panelFormulario.Controls.Add(lblNombre);

            // txtNombre
            txtNombre.Location = new Point(30, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 25);
            txtNombre.Font = new Font("Segoe UI", 9);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.BackColor = Color.White;
            panelFormulario.Controls.Add(txtNombre);

            // lblApellido
            lblApellido.Text = "Apellido:";
            lblApellido.Font = new Font("Segoe UI", 9);
            lblApellido.ForeColor = Color.FromArgb(127, 140, 141);
            lblApellido.Location = new Point(200, 50);
            lblApellido.Size = new Size(60, 20);
            panelFormulario.Controls.Add(lblApellido);

            // txtApellido
            txtApellido.Location = new Point(200, 75);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 25);
            txtApellido.Font = new Font("Segoe UI", 9);
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.BackColor = Color.White;
            panelFormulario.Controls.Add(txtApellido);

            // lblTipoDocumento
            lblTipoDocumento.Text = "Tipo Doc:";
            lblTipoDocumento.Font = new Font("Segoe UI", 9);
            lblTipoDocumento.ForeColor = Color.FromArgb(127, 140, 141);
            lblTipoDocumento.Location = new Point(370, 50);
            lblTipoDocumento.Size = new Size(60, 20);
            panelFormulario.Controls.Add(lblTipoDocumento);

            // cmbTipoDocumento
            cmbTipoDocumento.Items.AddRange(new object[] { "Cedula", "Pasaporte" });
            cmbTipoDocumento.Location = new Point(370, 75);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(100, 25);
            cmbTipoDocumento.Font = new Font("Segoe UI", 9);
            cmbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDocumento.BackColor = Color.White;
            cmbTipoDocumento.SelectedIndex = 0;
            panelFormulario.Controls.Add(cmbTipoDocumento);

            // lblNumeroDocumento
            lblNumeroDocumento.Text = "N° Doc:";
            lblNumeroDocumento.Font = new Font("Segoe UI", 9);
            lblNumeroDocumento.ForeColor = Color.FromArgb(127, 140, 141);
            lblNumeroDocumento.Location = new Point(490, 50);
            lblNumeroDocumento.Size = new Size(50, 20);
            panelFormulario.Controls.Add(lblNumeroDocumento);

            // txtNumeroDocumento
            txtNumeroDocumento.Location = new Point(490, 75);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(120, 25);
            txtNumeroDocumento.Font = new Font("Segoe UI", 9);
            txtNumeroDocumento.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroDocumento.BackColor = Color.White;
            panelFormulario.Controls.Add(txtNumeroDocumento);

            // lblTelefono
            lblTelefono.Text = "Teléfono:";
            lblTelefono.Font = new Font("Segoe UI", 9);
            lblTelefono.ForeColor = Color.FromArgb(127, 140, 141);
            lblTelefono.Location = new Point(30, 110);
            lblTelefono.Size = new Size(60, 20);
            panelFormulario.Controls.Add(lblTelefono);

            // txtTelefono
            txtTelefono.Location = new Point(30, 135);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 25);
            txtTelefono.Font = new Font("Segoe UI", 9);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.BackColor = Color.White;
            panelFormulario.Controls.Add(txtTelefono);

            // lblEmail
            lblEmail.Text = "Email:";
            lblEmail.Font = new Font("Segoe UI", 9);
            lblEmail.ForeColor = Color.FromArgb(127, 140, 141);
            lblEmail.Location = new Point(200, 110);
            lblEmail.Size = new Size(50, 20);
            panelFormulario.Controls.Add(lblEmail);

            // txtEmail
            txtEmail.Location = new Point(200, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 25);
            txtEmail.Font = new Font("Segoe UI", 9);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.BackColor = Color.White;
            panelFormulario.Controls.Add(txtEmail);

            // btnAgregar
            btnAgregar.Text = "➕ Agregar";
            btnAgregar.Location = new Point(30, 175);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 35);
            btnAgregar.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnAgregar.BackColor = Color.FromArgb(46, 204, 113);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.TabIndex = 12;
            btnAgregar.Click += BtnAgregar_Click;
            panelFormulario.Controls.Add(btnAgregar);

            // btnEditar
            btnEditar.Text = "✏️ Editar";
            btnEditar.Location = new Point(150, 175);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 35);
            btnEditar.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnEditar.BackColor = Color.FromArgb(52, 152, 219);
            btnEditar.ForeColor = Color.White;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.TabIndex = 13;
            btnEditar.Click += BtnEditar_Click;
            panelFormulario.Controls.Add(btnEditar);

            // btnEliminar
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.Location = new Point(270, 175);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.TabIndex = 14;
            btnEliminar.Click += BtnEliminar_Click;
            panelFormulario.Controls.Add(btnEliminar);

            // btnLimpiar
            btnLimpiar.Text = "🧹 Limpiar";
            btnLimpiar.Location = new Point(390, 175);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 35);
            btnLimpiar.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnLimpiar.BackColor = Color.FromArgb(149, 165, 166);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Click += BtnLimpiar_Click;
            panelFormulario.Controls.Add(btnLimpiar);

            // DataGridView Columns
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 50;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 60;
            dataGridViewTextBoxColumn1.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.MinimumWidth = 100;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 120;
            dataGridViewTextBoxColumn2.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            dataGridViewTextBoxColumn3.MinimumWidth = 100;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 120;
            dataGridViewTextBoxColumn3.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTextBoxColumn4.HeaderText = "Tipo Doc";
            dataGridViewTextBoxColumn4.MinimumWidth = 70;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 80;
            dataGridViewTextBoxColumn4.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTextBoxColumn5.HeaderText = "N° Documento";
            dataGridViewTextBoxColumn5.MinimumWidth = 100;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 120;
            dataGridViewTextBoxColumn5.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTextBoxColumn6.HeaderText = "Teléfono";
            dataGridViewTextBoxColumn6.MinimumWidth = 80;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 100;
            dataGridViewTextBoxColumn6.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTextBoxColumn7.HeaderText = "Email";
            dataGridViewTextBoxColumn7.MinimumWidth = 120;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 150;
            dataGridViewTextBoxColumn7.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTextBoxColumn8.HeaderText = "Dirección";
            dataGridViewTextBoxColumn8.MinimumWidth = 150;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 180;
            dataGridViewTextBoxColumn8.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            // InquilinoForm
            ClientSize = new Size(920, 720);
            Controls.Add(panelFormulario);
            Controls.Add(panelBusqueda);
            Controls.Add(lblTitulo);
            Controls.Add(dgvInquilinos);
            Name = "InquilinoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Inquilinos";
            BackColor = Color.FromArgb(248, 249, 250);
            Font = new Font("Segoe UI", 9);
            ((System.ComponentModel.ISupportInitialize)dgvInquilinos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarInquilino();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditarInquilino();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarInquilino();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarInquilino();
        }

        private void CargarInquilinos()
        {
            try
            {
                dgvInquilinos.Rows.Clear();
                var inquilinos = _inquilinoRepository.ObtenerTodos();

                foreach (var inq in inquilinos)
                {
                    dgvInquilinos.Rows.Add(
                        inq.Id,
                        inq.Nombre,
                        inq.Apellido,
                        inq.NumeroDocumento,
                        inq.TipoDocumento.ToString(),
                        inq.Telefono,
                        inq.Email
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar inquilinos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarInquilino()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
                {
                    CargarInquilinos();
                    return;
                }

                var inquilinos = _inquilinoRepository.BuscarPorNombre(txtBusqueda.Text);
                dgvInquilinos.Rows.Clear();

                foreach (var inq in inquilinos)
                {
                    dgvInquilinos.Rows.Add(
                        inq.Id,
                        inq.Nombre,
                        inq.Apellido,
                        inq.NumeroDocumento,
                        inq.TipoDocumento.ToString(),
                        inq.Telefono,
                        inq.Email
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar inquilinos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarInquilino()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
                {
                    MessageBox.Show("Por favor complete los campos obligatorios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var inquilino = new Inquilino
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    NumeroDocumento = txtNumeroDocumento.Text,
                    TipoDocumento = cmbTipoDocumento.SelectedItem?.ToString() == "Cedula" ? TipoDocumento.Cedula :
                                   TipoDocumento.Pasaporte,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text
                };

                _inquilinoRepository.Agregar(inquilino);
                MessageBox.Show("Inquilino agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarInquilinos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar inquilino: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarInquilino()
        {
            try
            {
                if (dgvInquilinos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un inquilino para editar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvInquilinos.SelectedRows[0].Cells[0].Value);
                var inquilino = _inquilinoRepository.ObtenerPorId(id);

                if (inquilino == null)
                {
                    MessageBox.Show("Inquilino no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                inquilino.Nombre = txtNombre.Text;
                inquilino.Apellido = txtApellido.Text;
                inquilino.NumeroDocumento = txtNumeroDocumento.Text;
                inquilino.TipoDocumento = cmbTipoDocumento.SelectedItem?.ToString() == "Cedula" ? TipoDocumento.Cedula :
                                        TipoDocumento.Pasaporte;
                inquilino.Telefono = txtTelefono.Text;
                inquilino.Email = txtEmail.Text;

                _inquilinoRepository.Actualizar(inquilino);
                MessageBox.Show("Inquilino actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarInquilinos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar inquilino: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarInquilino()
        {
            try
            {
                if (dgvInquilinos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un inquilino para eliminar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvInquilinos.SelectedRows[0].Cells[0].Value);

                var result = MessageBox.Show("¿Está seguro de eliminar este inquilino?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _inquilinoRepository.Eliminar(id);
                    MessageBox.Show("Inquilino eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarInquilinos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar inquilino: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNumeroDocumento.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            cmbTipoDocumento.SelectedIndex = 0;
        }
    }
}
