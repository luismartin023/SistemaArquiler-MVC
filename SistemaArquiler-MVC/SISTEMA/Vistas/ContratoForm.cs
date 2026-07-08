using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SistemaGestionResidencial.Vistas
{
    public partial class ContratoForm : Form
    {
        private DataGridView dgvContratos;
        private ComboBox cmbApartamento;
        private ComboBox cmbInquilino;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private TextBox txtMontoMensual;
        private ComboBox cmbEstado;
        private TextBox txtDeposito;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label lblTitulo;
        private Label lblApartamento;
        private Label lblInquilino;
        private Label lblFechaInicio;
        private Label lblFechaFin;
        private Label lblMontoMensual;
        private Label lblEstado;
        private Label lblDeposito;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

        public ContratoForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            dgvContratos = new DataGridView();
            cmbApartamento = new ComboBox();
            cmbInquilino = new ComboBox();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            txtMontoMensual = new TextBox();
            cmbEstado = new ComboBox();
            txtDeposito = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            lblTitulo = new Label();
            lblApartamento = new Label();
            lblInquilino = new Label();
            lblFechaInicio = new Label();
            lblFechaFin = new Label();
            lblMontoMensual = new Label();
            lblEstado = new Label();
            lblDeposito = new Label();
            Panel panelFormulario = new Panel();
            Label lblFormulario = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvContratos).BeginInit();
            SuspendLayout();
            
            // lblTitulo
            lblTitulo.Text = "📄 Gestión de Contratos";
            lblTitulo.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(45, 52, 54);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Size = new Size(350, 35);
            lblTitulo.TabIndex = 0;
            
            // dgvContratos
            dgvContratos.ColumnHeadersHeight = 35;
            dgvContratos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgvContratos.Location = new Point(20, 70);
            dgvContratos.Name = "dgvContratos";
            dgvContratos.RowHeadersWidth = 40;
            dgvContratos.Size = new Size(880, 280);
            dgvContratos.TabIndex = 1;
            dgvContratos.BackgroundColor = Color.White;
            dgvContratos.GridColor = Color.FromArgb(236, 240, 241);
            dgvContratos.DefaultCellStyle.BackColor = Color.White;
            dgvContratos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvContratos.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvContratos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvContratos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvContratos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvContratos.EnableHeadersVisualStyles = false;
            dgvContratos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(244, 246, 247);
            
            // panelFormulario
            panelFormulario.Location = new Point(20, 370);
            panelFormulario.Size = new Size(880, 220);
            panelFormulario.BackColor = Color.FromArgb(248, 249, 250);
            panelFormulario.BorderStyle = BorderStyle.FixedSingle;
            
            // lblFormulario
            lblFormulario.Text = "📝 Nuevo Contrato";
            lblFormulario.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblFormulario.ForeColor = Color.FromArgb(45, 52, 54);
            lblFormulario.Location = new Point(15, 10);
            lblFormulario.Size = new Size(180, 25);
            panelFormulario.Controls.Add(lblFormulario);
            
            // lblApartamento
            lblApartamento.Text = "Apartamento:";
            lblApartamento.Font = new Font("Segoe UI", 9);
            lblApartamento.ForeColor = Color.FromArgb(127, 140, 141);
            lblApartamento.Location = new Point(30, 50);
            lblApartamento.Size = new Size(80, 20);
            panelFormulario.Controls.Add(lblApartamento);
            
            // cmbApartamento
            cmbApartamento.Items.AddRange(new object[] { "A-101", "A-102", "B-201", "B-202" });
            cmbApartamento.Location = new Point(30, 75);
            cmbApartamento.Name = "cmbApartamento";
            cmbApartamento.Size = new Size(150, 25);
            cmbApartamento.Font = new Font("Segoe UI", 9);
            cmbApartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbApartamento.BackColor = Color.White;
            cmbApartamento.SelectedIndex = 0;
            panelFormulario.Controls.Add(cmbApartamento);
            
            // lblInquilino
            lblInquilino.Text = "Inquilino:";
            lblInquilino.Font = new Font("Segoe UI", 9);
            lblInquilino.ForeColor = Color.FromArgb(127, 140, 141);
            lblInquilino.Location = new Point(200, 50);
            lblInquilino.Size = new Size(70, 20);
            panelFormulario.Controls.Add(lblInquilino);
            
            // cmbInquilino
            cmbInquilino.Items.AddRange(new object[] { "Juan Pérez", "María García", "Carlos López" });
            cmbInquilino.Location = new Point(200, 75);
            cmbInquilino.Name = "cmbInquilino";
            cmbInquilino.Size = new Size(150, 25);
            cmbInquilino.Font = new Font("Segoe UI", 9);
            cmbInquilino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInquilino.BackColor = Color.White;
            cmbInquilino.SelectedIndex = 0;
            panelFormulario.Controls.Add(cmbInquilino);
            
            // lblFechaInicio
            lblFechaInicio.Text = "Fecha Inicio:";
            lblFechaInicio.Font = new Font("Segoe UI", 9);
            lblFechaInicio.ForeColor = Color.FromArgb(127, 140, 141);
            lblFechaInicio.Location = new Point(370, 50);
            lblFechaInicio.Size = new Size(80, 20);
            panelFormulario.Controls.Add(lblFechaInicio);
            
            // dtpFechaInicio
            dtpFechaInicio.Location = new Point(370, 75);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(120, 25);
            dtpFechaInicio.Font = new Font("Segoe UI", 9);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.BackColor = Color.White;
            panelFormulario.Controls.Add(dtpFechaInicio);
            
            // lblFechaFin
            lblFechaFin.Text = "Fecha Fin:";
            lblFechaFin.Font = new Font("Segoe UI", 9);
            lblFechaFin.ForeColor = Color.FromArgb(127, 140, 141);
            lblFechaFin.Location = new Point(510, 50);
            lblFechaFin.Size = new Size(70, 20);
            panelFormulario.Controls.Add(lblFechaFin);
            
            // dtpFechaFin
            dtpFechaFin.Location = new Point(510, 75);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(120, 25);
            dtpFechaFin.Font = new Font("Segoe UI", 9);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.BackColor = Color.White;
            panelFormulario.Controls.Add(dtpFechaFin);
            
            // lblMontoMensual
            lblMontoMensual.Text = "Monto Mensual:";
            lblMontoMensual.Font = new Font("Segoe UI", 9);
            lblMontoMensual.ForeColor = Color.FromArgb(127, 140, 141);
            lblMontoMensual.Location = new Point(30, 110);
            lblMontoMensual.Size = new Size(90, 20);
            panelFormulario.Controls.Add(lblMontoMensual);
            
            // txtMontoMensual
            txtMontoMensual.Location = new Point(30, 135);
            txtMontoMensual.Name = "txtMontoMensual";
            txtMontoMensual.Size = new Size(100, 25);
            txtMontoMensual.Font = new Font("Segoe UI", 9);
            txtMontoMensual.BorderStyle = BorderStyle.FixedSingle;
            txtMontoMensual.BackColor = Color.White;
            panelFormulario.Controls.Add(txtMontoMensual);
            
            // lblDeposito
            lblDeposito.Text = "Depósito:";
            lblDeposito.Font = new Font("Segoe UI", 9);
            lblDeposito.ForeColor = Color.FromArgb(127, 140, 141);
            lblDeposito.Location = new Point(150, 110);
            lblDeposito.Size = new Size(60, 20);
            panelFormulario.Controls.Add(lblDeposito);
            
            // txtDeposito
            txtDeposito.Location = new Point(150, 135);
            txtDeposito.Name = "txtDeposito";
            txtDeposito.Size = new Size(100, 25);
            txtDeposito.Font = new Font("Segoe UI", 9);
            txtDeposito.BorderStyle = BorderStyle.FixedSingle;
            txtDeposito.BackColor = Color.White;
            panelFormulario.Controls.Add(txtDeposito);
            
            // lblEstado
            lblEstado.Text = "Estado:";
            lblEstado.Font = new Font("Segoe UI", 9);
            lblEstado.ForeColor = Color.FromArgb(127, 140, 141);
            lblEstado.Location = new Point(270, 110);
            lblEstado.Size = new Size(50, 20);
            panelFormulario.Controls.Add(lblEstado);
            
            // cmbEstado
            cmbEstado.Items.AddRange(new object[] { "Activo", "Vencido", "Cancelado", "Pendiente" });
            cmbEstado.Location = new Point(270, 135);
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
            
            dataGridViewTextBoxColumn2.HeaderText = "Apartamento";
            dataGridViewTextBoxColumn2.MinimumWidth = 80;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 100;
            dataGridViewTextBoxColumn2.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            
            dataGridViewTextBoxColumn3.HeaderText = "Inquilino";
            dataGridViewTextBoxColumn3.MinimumWidth = 100;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 120;
            dataGridViewTextBoxColumn3.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            
            dataGridViewTextBoxColumn4.HeaderText = "Fecha Inicio";
            dataGridViewTextBoxColumn4.MinimumWidth = 90;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 100;
            dataGridViewTextBoxColumn4.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            
            dataGridViewTextBoxColumn5.HeaderText = "Fecha Fin";
            dataGridViewTextBoxColumn5.MinimumWidth = 80;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 100;
            dataGridViewTextBoxColumn5.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            
            dataGridViewTextBoxColumn6.HeaderText = "Monto Mensual";
            dataGridViewTextBoxColumn6.MinimumWidth = 100;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 110;
            dataGridViewTextBoxColumn6.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridViewTextBoxColumn6.DefaultCellStyle.Format = "C2";
            
            dataGridViewTextBoxColumn7.HeaderText = "Depósito";
            dataGridViewTextBoxColumn7.MinimumWidth = 80;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 90;
            dataGridViewTextBoxColumn7.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridViewTextBoxColumn7.DefaultCellStyle.Format = "C2";
            
            dataGridViewTextBoxColumn8.HeaderText = "Estado";
            dataGridViewTextBoxColumn8.MinimumWidth = 80;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 100;
            dataGridViewTextBoxColumn8.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            
            // ContratoForm
            ClientSize = new Size(920, 610);
            Controls.Add(panelFormulario);
            Controls.Add(lblTitulo);
            Controls.Add(dgvContratos);
            Name = "ContratoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Contratos";
            BackColor = Color.FromArgb(236, 240, 241);
            Font = new Font("Segoe UI", 9);
            ((System.ComponentModel.ISupportInitialize)dgvContratos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarContrato();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditarContrato();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarContrato();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CargarContratos()
        {
            dgvContratos.Rows.Clear();
        }

        private void AgregarContrato()
        {
            MessageBox.Show("Funcionalidad de agregar contrato pendiente de implementación");
        }

        private void EditarContrato()
        {
            MessageBox.Show("Funcionalidad de editar contrato pendiente de implementación");
        }

        private void EliminarContrato()
        {
            MessageBox.Show("Funcionalidad de eliminar contrato pendiente de implementación");
        }

        private void LimpiarCampos()
        {
            txtMontoMensual.Clear();
            txtDeposito.Clear();
            cmbApartamento.SelectedIndex = 0;
            cmbInquilino.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now.AddMonths(12);
        }
    }
}
