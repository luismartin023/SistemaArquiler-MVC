using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaGestionResidencial.Interfaces;
using SistemaGestionResidencial.Models;

namespace SistemaGestionResidencial.Vistas
{
    public partial class PagoForm : Form
    {
        private DataGridView dgvPagos;
        private ComboBox cmbContrato;
        private DateTimePicker dtpFechaPago;
        private TextBox txtMonto;
        private ComboBox cmbMetodoPago;
        private TextBox txtReferencia;
        private TextBox txtBusqueda;
        private TextBox txtNumeroRecibo;
        private ComboBox cmbEstado;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnBuscarPanel;
        private Label lblTitulo;
        private Label lblContrato;
        private Label lblFechaPago;
        private Label lblMonto;
        private Label lblMetodoPago;
        private Label lblReferencia;
        private Label lblNumeroRecibo;
        private Label lblEstado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

        private readonly IPagoRepository _pagoRepository;
        private readonly IContratoRepository _contratoRepository;

        public PagoForm(IPagoRepository pagoRepository, IContratoRepository contratoRepository)
        {
            _pagoRepository = pagoRepository;
            _contratoRepository = contratoRepository;
            InitializeComponent();
            CargarCombos();
            CargarPagos();
        }

        private void InitializeComponent()
        {
            dgvPagos = new DataGridView();
            cmbContrato = new ComboBox();
            dtpFechaPago = new DateTimePicker();
            txtMonto = new TextBox();
            cmbMetodoPago = new ComboBox();
            txtReferencia = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            lblTitulo = new Label();
            lblContrato = new Label();
            lblFechaPago = new Label();
            lblMonto = new Label();
            lblMetodoPago = new Label();
            lblReferencia = new Label();
            lblNumeroRecibo = new Label();
            lblEstado = new Label();
            Panel panelFormulario = new Panel();
            Label lblFormulario = new Label();
            Panel panelBusqueda = new Panel();
            Label lblBusqueda = new Label();
            TextBox txtBusqueda = new TextBox();
            Button btnBuscarPanel = new Button();
            TextBox txtNumeroRecibo = new TextBox();
            ComboBox cmbEstado = new ComboBox();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            SuspendLayout();

            // Form
            this.BackColor = Color.FromArgb(248, 249, 250);
            this.AutoScroll = true;

            // lblTitulo
            lblTitulo.Text = "💰 Gestión de Pagos";
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
            txtBusqueda.PlaceholderText = "Buscar por contrato, referencia...";
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

            // dgvPagos
            dgvPagos.ColumnHeadersHeight = 40;
            dgvPagos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dgvPagos.Location = new Point(20, 130);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.RowHeadersWidth = 40;
            dgvPagos.Size = new Size(880, 300);
            dgvPagos.TabIndex = 1;
            dgvPagos.BackgroundColor = Color.White;
            dgvPagos.GridColor = Color.FromArgb(236, 240, 241);
            dgvPagos.DefaultCellStyle.BackColor = Color.White;
            dgvPagos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvPagos.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPagos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvPagos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPagos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPagos.EnableHeadersVisualStyles = false;
            dgvPagos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(244, 246, 247);
            dgvPagos.RowTemplate.Height = 30;

            // panelFormulario
            panelFormulario.Location = new Point(20, 450);
            panelFormulario.Size = new Size(880, 250);
            panelFormulario.BackColor = Color.White;
            panelFormulario.BorderStyle = BorderStyle.FixedSingle;

            // lblFormulario
            lblFormulario.Text = "📝 Nuevo Pago";
            lblFormulario.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblFormulario.ForeColor = Color.FromArgb(45, 52, 54);
            lblFormulario.Location = new Point(15, 10);
            lblFormulario.Size = new Size(150, 25);
            panelFormulario.Controls.Add(lblFormulario);

            // lblContrato
            lblContrato.Text = "Contrato:";
            lblContrato.Font = new Font("Segoe UI", 9);
            lblContrato.ForeColor = Color.FromArgb(127, 140, 141);
            lblContrato.Location = new Point(30, 50);
            lblContrato.Size = new Size(60, 20);
            panelFormulario.Controls.Add(lblContrato);

            // cmbContrato
            cmbContrato.Location = new Point(30, 75);
            cmbContrato.Name = "cmbContrato";
            cmbContrato.Size = new Size(200, 25);
            cmbContrato.Font = new Font("Segoe UI", 9);
            cmbContrato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContrato.BackColor = Color.White;
            panelFormulario.Controls.Add(cmbContrato);

            // lblFechaPago
            lblFechaPago.Text = "Fecha:";
            lblFechaPago.Font = new Font("Segoe UI", 9);
            lblFechaPago.ForeColor = Color.FromArgb(127, 140, 141);
            lblFechaPago.Location = new Point(250, 50);
            lblFechaPago.Size = new Size(50, 20);
            panelFormulario.Controls.Add(lblFechaPago);

            // dtpFechaPago
            dtpFechaPago.Location = new Point(250, 75);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(120, 25);
            dtpFechaPago.Font = new Font("Segoe UI", 9);
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            panelFormulario.Controls.Add(dtpFechaPago);

            // lblMonto
            lblMonto.Text = "Monto:";
            lblMonto.Font = new Font("Segoe UI", 9);
            lblMonto.ForeColor = Color.FromArgb(127, 140, 141);
            lblMonto.Location = new Point(390, 50);
            lblMonto.Size = new Size(50, 20);
            panelFormulario.Controls.Add(lblMonto);

            // txtMonto
            txtMonto.Location = new Point(390, 75);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 25);
            txtMonto.Font = new Font("Segoe UI", 9);
            txtMonto.BorderStyle = BorderStyle.FixedSingle;
            txtMonto.BackColor = Color.White;
            panelFormulario.Controls.Add(txtMonto);

            // lblMetodoPago
            lblMetodoPago.Text = "Método:";
            lblMetodoPago.Font = new Font("Segoe UI", 9);
            lblMetodoPago.ForeColor = Color.FromArgb(127, 140, 141);
            lblMetodoPago.Location = new Point(510, 50);
            lblMetodoPago.Size = new Size(60, 20);
            panelFormulario.Controls.Add(lblMetodoPago);

            // cmbMetodoPago
            cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Transferencia", "Tarjeta" });
            cmbMetodoPago.Location = new Point(510, 75);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(120, 25);
            cmbMetodoPago.Font = new Font("Segoe UI", 9);
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.BackColor = Color.White;
            cmbMetodoPago.SelectedIndex = 0;
            panelFormulario.Controls.Add(cmbMetodoPago);

            // lblReferencia
            lblReferencia.Text = "Referencia:";
            lblReferencia.Font = new Font("Segoe UI", 9);
            lblReferencia.ForeColor = Color.FromArgb(127, 140, 141);
            lblReferencia.Location = new Point(650, 50);
            lblReferencia.Size = new Size(70, 20);
            panelFormulario.Controls.Add(lblReferencia);

            // txtReferencia
            txtReferencia.Location = new Point(650, 75);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(200, 25);
            txtReferencia.Font = new Font("Segoe UI", 9);
            txtReferencia.BorderStyle = BorderStyle.FixedSingle;
            txtReferencia.BackColor = Color.White;
            panelFormulario.Controls.Add(txtReferencia);

            // lblNumeroRecibo
            lblNumeroRecibo.Text = "N° Recibo:";
            lblNumeroRecibo.Font = new Font("Segoe UI", 9);
            lblNumeroRecibo.ForeColor = Color.FromArgb(127, 140, 141);
            lblNumeroRecibo.Location = new Point(30, 110);
            lblNumeroRecibo.Size = new Size(70, 20);
            panelFormulario.Controls.Add(lblNumeroRecibo);

            // txtNumeroRecibo
            txtNumeroRecibo.Location = new Point(30, 135);
            txtNumeroRecibo.Name = "txtNumeroRecibo";
            txtNumeroRecibo.Size = new Size(150, 25);
            txtNumeroRecibo.Font = new Font("Segoe UI", 9);
            txtNumeroRecibo.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroRecibo.BackColor = Color.White;
            panelFormulario.Controls.Add(txtNumeroRecibo);

            // lblEstado
            lblEstado.Text = "Estado:";
            lblEstado.Font = new Font("Segoe UI", 9);
            lblEstado.ForeColor = Color.FromArgb(127, 140, 141);
            lblEstado.Location = new Point(200, 110);
            lblEstado.Size = new Size(50, 20);
            panelFormulario.Controls.Add(lblEstado);

            // cmbEstado
            cmbEstado.Items.AddRange(new object[] { "Pagado", "Pendiente", "Cancelado" });
            cmbEstado.Location = new Point(200, 135);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(120, 25);
            cmbEstado.Font = new Font("Segoe UI", 9);
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.BackColor = Color.White;
            cmbEstado.SelectedIndex = 0;
            panelFormulario.Controls.Add(cmbEstado);

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

            dataGridViewTextBoxColumn2.HeaderText = "Contrato";
            dataGridViewTextBoxColumn2.MinimumWidth = 80;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 100;
            dataGridViewTextBoxColumn2.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            dataGridViewTextBoxColumn3.MinimumWidth = 80;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 100;
            dataGridViewTextBoxColumn3.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTextBoxColumn4.HeaderText = "Monto";
            dataGridViewTextBoxColumn4.MinimumWidth = 80;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 100;
            dataGridViewTextBoxColumn4.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridViewTextBoxColumn4.DefaultCellStyle.Format = "C2";

            dataGridViewTextBoxColumn5.HeaderText = "Método";
            dataGridViewTextBoxColumn5.MinimumWidth = 80;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 100;
            dataGridViewTextBoxColumn5.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTextBoxColumn6.HeaderText = "Referencia";
            dataGridViewTextBoxColumn6.MinimumWidth = 100;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 150;
            dataGridViewTextBoxColumn6.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTextBoxColumn7.HeaderText = "Estado";
            dataGridViewTextBoxColumn7.MinimumWidth = 80;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 100;
            dataGridViewTextBoxColumn7.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            // PagoForm
            ClientSize = new Size(920, 720);
            Controls.Add(panelFormulario);
            Controls.Add(panelBusqueda);
            Controls.Add(lblTitulo);
            Controls.Add(dgvPagos);
            Name = "PagoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Pagos";
            BackColor = Color.FromArgb(248, 249, 250);
            Font = new Font("Segoe UI", 9);
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void CargarCombos()
        {
            try
            {
                var contratos = _contratoRepository.ObtenerContratosActivos();
                cmbContrato.DataSource = contratos.ToList();
                cmbContrato.DisplayMember = "Id";
                cmbContrato.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar combos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPagos()
        {
            try
            {
                dgvPagos.Rows.Clear();
                var pagos = _pagoRepository.ObtenerTodos();

                foreach (var pago in pagos)
                {
                    dgvPagos.Rows.Add(
                        pago.Id,
                        pago.ContratoId,
                        pago.FechaPago.ToShortDateString(),
                        pago.Monto.ToString("C2"),
                        pago.MetodoPago.ToString(),
                        pago.Referencia ?? "",
                        pago.Estado.ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pagos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarPagos()
        {
            try
            {
                string busqueda = txtBusqueda.Text.ToLower();
                if (string.IsNullOrWhiteSpace(busqueda))
                {
                    CargarPagos();
                    return;
                }

                dgvPagos.Rows.Clear();
                var pagos = _pagoRepository.ObtenerTodos()
                    .Where(p => p.ContratoId.ToString().Contains(busqueda) ||
                               (p.Referencia ?? "").ToLower().Contains(busqueda) ||
                               p.Estado.ToString().ToLower().Contains(busqueda));

                foreach (var pago in pagos)
                {
                    dgvPagos.Rows.Add(
                        pago.Id,
                        pago.ContratoId,
                        pago.FechaPago.ToShortDateString(),
                        pago.Monto.ToString("C2"),
                        pago.MetodoPago.ToString(),
                        pago.Referencia ?? "",
                        pago.Estado.ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar pagos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPago();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditarPago();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarPago();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPagos();
        }

        private void AgregarPago()
        {
            try
            {
                if (cmbContrato.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtMonto.Text))
                {
                    MessageBox.Show("Por favor complete los campos obligatorios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var pago = new Pago
                {
                    ContratoId = Convert.ToInt32(cmbContrato.SelectedValue),
                    FechaPago = dtpFechaPago.Value,
                    Monto = decimal.TryParse(txtMonto.Text, out decimal monto) ? monto : 0,
                    MetodoPago = cmbMetodoPago.SelectedItem?.ToString() == "Efectivo" ? MetodoPago.Efectivo :
                                  cmbMetodoPago.SelectedItem?.ToString() == "Transferencia" ? MetodoPago.Transferencia :
                                  MetodoPago.Tarjeta,
                    Referencia = txtReferencia.Text
                };

                _pagoRepository.Agregar(pago);
                MessageBox.Show("Pago agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarPago()
        {
            try
            {
                if (dgvPagos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un pago para editar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvPagos.SelectedRows[0].Cells[0].Value);
                var pago = _pagoRepository.ObtenerPorId(id);

                if (pago == null)
                {
                    MessageBox.Show("Pago no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                pago.ContratoId = Convert.ToInt32(cmbContrato.SelectedValue);
                pago.FechaPago = dtpFechaPago.Value;
                pago.Monto = decimal.TryParse(txtMonto.Text, out decimal monto) ? monto : 0;
                pago.MetodoPago = cmbMetodoPago.SelectedItem?.ToString() == "Efectivo" ? MetodoPago.Efectivo :
                                cmbMetodoPago.SelectedItem?.ToString() == "Transferencia" ? MetodoPago.Transferencia :
                                MetodoPago.Tarjeta;
                pago.Referencia = txtReferencia.Text;

                _pagoRepository.Actualizar(pago);
                MessageBox.Show("Pago actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarPago()
        {
            try
            {
                if (dgvPagos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un pago para eliminar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvPagos.SelectedRows[0].Cells[0].Value);

                var result = MessageBox.Show("¿Está seguro de eliminar este pago?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _pagoRepository.Eliminar(id);
                    MessageBox.Show("Pago eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPagos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtMonto.Clear();
            txtReferencia.Clear();
            cmbContrato.SelectedIndex = 0;
            cmbMetodoPago.SelectedIndex = 0;
            dtpFechaPago.Value = DateTime.Now;
        }
    }
}
