using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaGestionResidencial.Interfaces;
using SistemaGestionResidencial.Models;

namespace SistemaGestionResidencial.Vistas
{
    public partial class ApartamentoForm : Form
    {
        private DataGridView dgvApartamentos;
        private TextBox txtNumero;
        private TextBox txtBloque;
        private TextBox txtPiso;
        private TextBox txtNumHabitaciones;
        private TextBox txtMetrosCuadrados;
        private TextBox txtPrecioAlquiler;
        private ComboBox cmbEstado;
        private TextBox txtDescripcion;
        private TextBox txtBusqueda;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnBuscar;
        private Label lblTitulo;
        private Label lblNumero;
        private Label lblBloque;
        private Label lblPiso;
        private Label lblNumHabitaciones;
        private Label lblMetrosCuadrados;
        private Label lblPrecioAlquiler;
        private Label lblEstado;
        private Label lblDescripcion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

        private readonly IApartamentoRepository _apartamentoRepository;

        public ApartamentoForm(IApartamentoRepository apartamentoRepository)
        {
            _apartamentoRepository = apartamentoRepository;
            InitializeComponent();
            CargarApartamentos();
        }

        private void InitializeComponent()
        {
            dgvApartamentos = new DataGridView();
            txtNumero = new TextBox();
            txtBloque = new TextBox();
            txtPiso = new TextBox();
            txtNumHabitaciones = new TextBox();
            txtMetrosCuadrados = new TextBox();
            txtPrecioAlquiler = new TextBox();
            cmbEstado = new ComboBox();
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            lblTitulo = new Label();
            lblNumero = new Label();
            lblBloque = new Label();
            lblPiso = new Label();
            lblNumHabitaciones = new Label();
            lblMetrosCuadrados = new Label();
            lblPrecioAlquiler = new Label();
            lblEstado = new Label();
            lblDescripcion = new Label();
            Panel panelFormulario = new Panel();
            Label lblFormulario = new Label();
            Panel panelBusqueda = new Panel();
            txtBusqueda = new TextBox();
            Button btnBuscar = new Button();
            Label lblBusqueda = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvApartamentos).BeginInit();
            SuspendLayout();

            // Form
            this.BackColor = Color.FromArgb(248, 249, 250);
            this.AutoScroll = true;

            // lblTitulo
            lblTitulo.Text = "🏢 Gestión de Apartamentos";
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
            txtBusqueda.PlaceholderText = "Buscar por número, bloque...";
            panelBusqueda.Controls.Add(txtBusqueda);

            // btnBuscar
            btnBuscar.Text = "🔎 Buscar";
            btnBuscar.Location = new Point(500, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 30);
            btnBuscar.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnBuscar.BackColor = Color.FromArgb(52, 152, 219);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Click += BtnBuscar_Click;
            panelBusqueda.Controls.Add(btnBuscar);

            // dgvApartamentos
            dgvApartamentos.ColumnHeadersHeight = 40;
            dgvApartamentos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgvApartamentos.Location = new Point(20, 130);
            dgvApartamentos.Name = "dgvApartamentos";
            dgvApartamentos.RowHeadersWidth = 40;
            dgvApartamentos.Size = new Size(880, 300);
            dgvApartamentos.TabIndex = 1;
            dgvApartamentos.BackgroundColor = Color.White;
            dgvApartamentos.GridColor = Color.FromArgb(236, 240, 241);
            dgvApartamentos.DefaultCellStyle.BackColor = Color.White;
            dgvApartamentos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvApartamentos.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvApartamentos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvApartamentos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvApartamentos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvApartamentos.EnableHeadersVisualStyles = false;
            dgvApartamentos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(244, 246, 247);
            dgvApartamentos.RowTemplate.Height = 30;

            // panelFormulario
            panelFormulario.Location = new Point(20, 450);
            panelFormulario.Size = new Size(880, 250);
            panelFormulario.BackColor = Color.White;
            panelFormulario.BorderStyle = BorderStyle.FixedSingle;

            // lblFormulario
            lblFormulario.Text = "📝 Nuevo Apartamento";
            lblFormulario.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblFormulario.ForeColor = Color.FromArgb(45, 52, 54);
            lblFormulario.Location = new Point(15, 10);
            lblFormulario.Size = new Size(180, 25);
            panelFormulario.Controls.Add(lblFormulario);

            // lblNumero
            lblNumero.Text = "Número:";
            lblNumero.Font = new Font("Segoe UI", 9);
            lblNumero.ForeColor = Color.FromArgb(127, 140, 141);
            lblNumero.Location = new Point(30, 50);
            lblNumero.Size = new Size(60, 20);
            panelFormulario.Controls.Add(lblNumero);

            // txtNumero
            txtNumero.Location = new Point(30, 75);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(80, 25);
            txtNumero.Font = new Font("Segoe UI", 9);
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.BackColor = Color.White;
            panelFormulario.Controls.Add(txtNumero);

            // lblBloque
            lblBloque.Text = "Bloque:";
            lblBloque.Font = new Font("Segoe UI", 9);
            lblBloque.ForeColor = Color.FromArgb(127, 140, 141);
            lblBloque.Location = new Point(130, 50);
            lblBloque.Size = new Size(50, 20);
            panelFormulario.Controls.Add(lblBloque);

            // txtBloque
            txtBloque.Location = new Point(130, 75);
            txtBloque.Name = "txtBloque";
            txtBloque.Size = new Size(60, 25);
            txtBloque.Font = new Font("Segoe UI", 9);
            txtBloque.BorderStyle = BorderStyle.FixedSingle;
            txtBloque.BackColor = Color.White;
            panelFormulario.Controls.Add(txtBloque);

            // lblPiso
            lblPiso.Text = "Piso:";
            lblPiso.Font = new Font("Segoe UI", 9);
            lblPiso.ForeColor = Color.FromArgb(127, 140, 141);
            lblPiso.Location = new Point(210, 50);
            lblPiso.Size = new Size(40, 20);
            panelFormulario.Controls.Add(lblPiso);

            // txtPiso
            txtPiso.Location = new Point(210, 75);
            txtPiso.Name = "txtPiso";
            txtPiso.Size = new Size(60, 25);
            txtPiso.Font = new Font("Segoe UI", 9);
            txtPiso.BorderStyle = BorderStyle.FixedSingle;
            txtPiso.BackColor = Color.White;
            panelFormulario.Controls.Add(txtPiso);

            // lblNumHabitaciones
            lblNumHabitaciones.Text = "Habitaciones:";
            lblNumHabitaciones.Font = new Font("Segoe UI", 9);
            lblNumHabitaciones.ForeColor = Color.FromArgb(127, 140, 141);
            lblNumHabitaciones.Location = new Point(290, 50);
            lblNumHabitaciones.Size = new Size(80, 20);
            panelFormulario.Controls.Add(lblNumHabitaciones);

            // txtNumHabitaciones
            txtNumHabitaciones.Location = new Point(290, 75);
            txtNumHabitaciones.Name = "txtNumHabitaciones";
            txtNumHabitaciones.Size = new Size(60, 25);
            txtNumHabitaciones.Font = new Font("Segoe UI", 9);
            txtNumHabitaciones.BorderStyle = BorderStyle.FixedSingle;
            txtNumHabitaciones.BackColor = Color.White;
            panelFormulario.Controls.Add(txtNumHabitaciones);

            // lblMetrosCuadrados
            lblMetrosCuadrados.Text = "M²:";
            lblMetrosCuadrados.Font = new Font("Segoe UI", 9);
            lblMetrosCuadrados.ForeColor = Color.FromArgb(127, 140, 141);
            lblMetrosCuadrados.Location = new Point(370, 50);
            lblMetrosCuadrados.Size = new Size(30, 20);
            panelFormulario.Controls.Add(lblMetrosCuadrados);

            // txtMetrosCuadrados
            txtMetrosCuadrados.Location = new Point(370, 75);
            txtMetrosCuadrados.Name = "txtMetrosCuadrados";
            txtMetrosCuadrados.Size = new Size(60, 25);
            txtMetrosCuadrados.Font = new Font("Segoe UI", 9);
            txtMetrosCuadrados.BorderStyle = BorderStyle.FixedSingle;
            txtMetrosCuadrados.BackColor = Color.White;
            panelFormulario.Controls.Add(txtMetrosCuadrados);

            // lblPrecioAlquiler
            lblPrecioAlquiler.Text = "Precio:";
            lblPrecioAlquiler.Font = new Font("Segoe UI", 9);
            lblPrecioAlquiler.ForeColor = Color.FromArgb(127, 140, 141);
            lblPrecioAlquiler.Location = new Point(450, 50);
            lblPrecioAlquiler.Size = new Size(50, 20);
            panelFormulario.Controls.Add(lblPrecioAlquiler);

            // txtPrecioAlquiler
            txtPrecioAlquiler.Location = new Point(450, 75);
            txtPrecioAlquiler.Name = "txtPrecioAlquiler";
            txtPrecioAlquiler.Size = new Size(80, 25);
            txtPrecioAlquiler.Font = new Font("Segoe UI", 9);
            txtPrecioAlquiler.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioAlquiler.BackColor = Color.White;
            panelFormulario.Controls.Add(txtPrecioAlquiler);

            // lblEstado
            lblEstado.Text = "Estado:";
            lblEstado.Font = new Font("Segoe UI", 9);
            lblEstado.ForeColor = Color.FromArgb(127, 140, 141);
            lblEstado.Location = new Point(550, 50);
            lblEstado.Size = new Size(50, 20);
            panelFormulario.Controls.Add(lblEstado);

            // cmbEstado
            cmbEstado.Items.AddRange(new object[] { "Disponible", "Ocupado", "En Mantenimiento" });
            cmbEstado.Location = new Point(550, 75);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(120, 25);
            cmbEstado.Font = new Font("Segoe UI", 9);
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.BackColor = Color.White;
            cmbEstado.SelectedIndex = 0;
            panelFormulario.Controls.Add(cmbEstado);

            // lblDescripcion
            lblDescripcion.Text = "Descripción:";
            lblDescripcion.Font = new Font("Segoe UI", 9);
            lblDescripcion.ForeColor = Color.FromArgb(127, 140, 141);
            lblDescripcion.Location = new Point(30, 110);
            lblDescripcion.Size = new Size(80, 20);
            panelFormulario.Controls.Add(lblDescripcion);

            // txtDescripcion
            txtDescripcion.Location = new Point(30, 135);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(640, 25);
            txtDescripcion.Font = new Font("Segoe UI", 9);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.BackColor = Color.White;
            panelFormulario.Controls.Add(txtDescripcion);

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

            dataGridViewTextBoxColumn2.HeaderText = "Número";
            dataGridViewTextBoxColumn2.MinimumWidth = 60;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 80;
            dataGridViewTextBoxColumn2.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTextBoxColumn3.HeaderText = "Bloque";
            dataGridViewTextBoxColumn3.MinimumWidth = 50;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 60;
            dataGridViewTextBoxColumn3.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTextBoxColumn4.HeaderText = "Piso";
            dataGridViewTextBoxColumn4.MinimumWidth = 40;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 50;
            dataGridViewTextBoxColumn4.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTextBoxColumn5.HeaderText = "Habitaciones";
            dataGridViewTextBoxColumn5.MinimumWidth = 80;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 90;
            dataGridViewTextBoxColumn5.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTextBoxColumn6.HeaderText = "M²";
            dataGridViewTextBoxColumn6.MinimumWidth = 50;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 60;
            dataGridViewTextBoxColumn6.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTextBoxColumn7.HeaderText = "Precio";
            dataGridViewTextBoxColumn7.MinimumWidth = 70;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 80;
            dataGridViewTextBoxColumn7.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridViewTextBoxColumn7.DefaultCellStyle.Format = "C2";

            dataGridViewTextBoxColumn8.HeaderText = "Estado";
            dataGridViewTextBoxColumn8.MinimumWidth = 80;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 100;
            dataGridViewTextBoxColumn8.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            // ApartamentoForm
            ClientSize = new Size(920, 720);
            Controls.Add(panelFormulario);
            Controls.Add(panelBusqueda);
            Controls.Add(lblTitulo);
            Controls.Add(dgvApartamentos);
            Name = "ApartamentoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Apartamentos";
            BackColor = Color.FromArgb(248, 249, 250);
            Font = new Font("Segoe UI", 9);
            ((System.ComponentModel.ISupportInitialize)dgvApartamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarApartamento();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditarApartamento();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarApartamento();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarApartamentos();
        }

        private void CargarApartamentos()
        {
            try
            {
                dgvApartamentos.Rows.Clear();
                var apartamentos = _apartamentoRepository.ObtenerTodos();

                foreach (var apt in apartamentos)
                {
                    dgvApartamentos.Rows.Add(
                        apt.Id,
                        apt.Numero,
                        apt.Bloque,
                        apt.Piso,
                        apt.NumHabitaciones,
                        apt.MetrosCuadrados,
                        apt.PrecioAlquiler.ToString("C2"),
                        apt.Estado.ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar apartamentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarApartamentos()
        {
            try
            {
                string busqueda = txtBusqueda.Text.ToLower();
                if (string.IsNullOrWhiteSpace(busqueda))
                {
                    CargarApartamentos();
                    return;
                }

                dgvApartamentos.Rows.Clear();
                var apartamentos = _apartamentoRepository.ObtenerTodos()
                    .Where(a => a.Numero.ToLower().Contains(busqueda) ||
                               a.Bloque.ToLower().Contains(busqueda) ||
                               a.Piso.ToString().Contains(busqueda) ||
                               a.Estado.ToString().ToLower().Contains(busqueda));

                foreach (var apt in apartamentos)
                {
                    dgvApartamentos.Rows.Add(
                        apt.Id,
                        apt.Numero,
                        apt.Bloque,
                        apt.Piso,
                        apt.NumHabitaciones,
                        apt.MetrosCuadrados,
                        apt.PrecioAlquiler.ToString("C2"),
                        apt.Estado.ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar apartamentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarApartamento()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumero.Text) ||
                    string.IsNullOrWhiteSpace(txtBloque.Text) ||
                    string.IsNullOrWhiteSpace(txtPiso.Text))
                {
                    MessageBox.Show("Por favor complete los campos obligatorios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var apartamento = new Apartamento
                {
                    Numero = txtNumero.Text,
                    Bloque = txtBloque.Text,
                    Piso = int.TryParse(txtPiso.Text, out int piso) ? piso : 1,
                    NumHabitaciones = int.TryParse(txtNumHabitaciones.Text, out int numHab) ? numHab : 1,
                    MetrosCuadrados = double.TryParse(txtMetrosCuadrados.Text, out double m2) ? m2 : 20,
                    PrecioAlquiler = decimal.TryParse(txtPrecioAlquiler.Text, out decimal precio) ? precio : 100,
                    Estado = cmbEstado.SelectedItem?.ToString() == "Disponible" ? EstadoApartamento.Disponible :
                             cmbEstado.SelectedItem?.ToString() == "Ocupado" ? EstadoApartamento.Ocupado :
                             EstadoApartamento.EnMantenimiento,
                    Descripcion = txtDescripcion.Text
                };

                _apartamentoRepository.Agregar(apartamento);
                MessageBox.Show("Apartamento agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarApartamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar apartamento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarApartamento()
        {
            try
            {
                if (dgvApartamentos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un apartamento para editar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvApartamentos.SelectedRows[0].Cells[0].Value);
                var apartamento = _apartamentoRepository.ObtenerPorId(id);

                if (apartamento == null)
                {
                    MessageBox.Show("Apartamento no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                apartamento.Numero = txtNumero.Text;
                apartamento.Bloque = txtBloque.Text;
                apartamento.Piso = int.TryParse(txtPiso.Text, out int piso) ? piso : 1;
                apartamento.NumHabitaciones = int.TryParse(txtNumHabitaciones.Text, out int numHab) ? numHab : 1;
                apartamento.MetrosCuadrados = double.TryParse(txtMetrosCuadrados.Text, out double m2) ? m2 : 20;
                apartamento.PrecioAlquiler = decimal.TryParse(txtPrecioAlquiler.Text, out decimal precio) ? precio : 100;
                apartamento.Estado = cmbEstado.SelectedItem?.ToString() == "Disponible" ? EstadoApartamento.Disponible :
                                   cmbEstado.SelectedItem?.ToString() == "Ocupado" ? EstadoApartamento.Ocupado :
                                   EstadoApartamento.EnMantenimiento;
                apartamento.Descripcion = txtDescripcion.Text;

                _apartamentoRepository.Actualizar(apartamento);
                MessageBox.Show("Apartamento actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarApartamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar apartamento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarApartamento()
        {
            try
            {
                if (dgvApartamentos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un apartamento para eliminar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvApartamentos.SelectedRows[0].Cells[0].Value);

                var result = MessageBox.Show("¿Está seguro de eliminar este apartamento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _apartamentoRepository.Eliminar(id);
                    MessageBox.Show("Apartamento eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarApartamentos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar apartamento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNumero.Clear();
            txtBloque.Clear();
            txtPiso.Clear();
            txtNumHabitaciones.Clear();
            txtMetrosCuadrados.Clear();
            txtPrecioAlquiler.Clear();
            txtDescripcion.Clear();
            cmbEstado.SelectedIndex = 0;
        }
    }
}
