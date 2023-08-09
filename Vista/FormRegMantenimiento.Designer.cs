namespace TallerMantenimiento.Vista
{
    partial class FormRegMantenimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbVehiculo = new System.Windows.Forms.GroupBox();
            this.btnAñadirVeh = new System.Windows.Forms.Button();
            this.cmbVehiculos = new System.Windows.Forms.ComboBox();
            this.dtpFechaMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbMecanicos = new System.Windows.Forms.ComboBox();
            this.rtbDiagnostico = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPreventivo = new System.Windows.Forms.RadioButton();
            this.rbCorrectivo = new System.Windows.Forms.RadioButton();
            this.gbRepuestos = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvRepuestos = new System.Windows.Forms.DataGridView();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAñadirRepuesto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkLstBxServicios = new System.Windows.Forms.CheckedListBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbVehiculo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbRepuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mecanico :";
            // 
            // gbVehiculo
            // 
            this.gbVehiculo.BackColor = System.Drawing.Color.Silver;
            this.gbVehiculo.Controls.Add(this.btnAñadirVeh);
            this.gbVehiculo.Controls.Add(this.cmbVehiculos);
            this.gbVehiculo.Location = new System.Drawing.Point(289, 14);
            this.gbVehiculo.Name = "gbVehiculo";
            this.gbVehiculo.Size = new System.Drawing.Size(315, 119);
            this.gbVehiculo.TabIndex = 3;
            this.gbVehiculo.TabStop = false;
            this.gbVehiculo.Text = "Vehiculo";
            // 
            // btnAñadirVeh
            // 
            this.btnAñadirVeh.BackColor = System.Drawing.Color.Gold;
            this.btnAñadirVeh.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAñadirVeh.Location = new System.Drawing.Point(216, 66);
            this.btnAñadirVeh.Name = "btnAñadirVeh";
            this.btnAñadirVeh.Size = new System.Drawing.Size(93, 34);
            this.btnAñadirVeh.TabIndex = 1;
            this.btnAñadirVeh.Text = "Añadir Vehiculo";
            this.btnAñadirVeh.UseVisualStyleBackColor = false;
            this.btnAñadirVeh.Click += new System.EventHandler(this.btnAñadirVeh_Click);
            // 
            // cmbVehiculos
            // 
            this.cmbVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculos.FormattingEnabled = true;
            this.cmbVehiculos.Location = new System.Drawing.Point(17, 25);
            this.cmbVehiculos.Name = "cmbVehiculos";
            this.cmbVehiculos.Size = new System.Drawing.Size(292, 25);
            this.cmbVehiculos.TabIndex = 0;
            // 
            // dtpFechaMantenimiento
            // 
            this.dtpFechaMantenimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaMantenimiento.Location = new System.Drawing.Point(110, 79);
            this.dtpFechaMantenimiento.MaxDate = new System.DateTime(2030, 1, 17, 0, 0, 0, 0);
            this.dtpFechaMantenimiento.Name = "dtpFechaMantenimiento";
            this.dtpFechaMantenimiento.Size = new System.Drawing.Size(168, 25);
            this.dtpFechaMantenimiento.TabIndex = 4;
            this.dtpFechaMantenimiento.Value = new System.DateTime(2023, 1, 16, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Fecha :";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(110, 14);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(168, 25);
            this.cmbClientes.TabIndex = 10;
            // 
            // cmbMecanicos
            // 
            this.cmbMecanicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMecanicos.FormattingEnabled = true;
            this.cmbMecanicos.Location = new System.Drawing.Point(110, 46);
            this.cmbMecanicos.Name = "cmbMecanicos";
            this.cmbMecanicos.Size = new System.Drawing.Size(168, 25);
            this.cmbMecanicos.TabIndex = 11;
            // 
            // rtbDiagnostico
            // 
            this.rtbDiagnostico.Location = new System.Drawing.Point(110, 112);
            this.rtbDiagnostico.Name = "rtbDiagnostico";
            this.rtbDiagnostico.Size = new System.Drawing.Size(168, 81);
            this.rtbDiagnostico.TabIndex = 12;
            this.rtbDiagnostico.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Diagnóstico :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.rbPreventivo);
            this.groupBox1.Controls.Add(this.rbCorrectivo);
            this.groupBox1.Location = new System.Drawing.Point(12, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 57);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Mantenimiento";
            // 
            // rbPreventivo
            // 
            this.rbPreventivo.AutoSize = true;
            this.rbPreventivo.Checked = true;
            this.rbPreventivo.Location = new System.Drawing.Point(11, 25);
            this.rbPreventivo.Name = "rbPreventivo";
            this.rbPreventivo.Size = new System.Drawing.Size(92, 23);
            this.rbPreventivo.TabIndex = 9;
            this.rbPreventivo.TabStop = true;
            this.rbPreventivo.Tag = "tipo";
            this.rbPreventivo.Text = "Preventivo";
            this.rbPreventivo.UseVisualStyleBackColor = true;
            this.rbPreventivo.CheckedChanged += new System.EventHandler(this.rbPreventivo_CheckedChanged);
            // 
            // rbCorrectivo
            // 
            this.rbCorrectivo.AutoSize = true;
            this.rbCorrectivo.Location = new System.Drawing.Point(109, 24);
            this.rbCorrectivo.Name = "rbCorrectivo";
            this.rbCorrectivo.Size = new System.Drawing.Size(90, 23);
            this.rbCorrectivo.TabIndex = 8;
            this.rbCorrectivo.Tag = "tipo";
            this.rbCorrectivo.Text = "Correctivo";
            this.rbCorrectivo.UseVisualStyleBackColor = true;
            this.rbCorrectivo.CheckedChanged += new System.EventHandler(this.rbCorrectivo_CheckedChanged);
            // 
            // gbRepuestos
            // 
            this.gbRepuestos.BackColor = System.Drawing.Color.Silver;
            this.gbRepuestos.Controls.Add(this.txtPrecio);
            this.gbRepuestos.Controls.Add(this.txtNombre);
            this.gbRepuestos.Controls.Add(this.label10);
            this.gbRepuestos.Controls.Add(this.label9);
            this.gbRepuestos.Controls.Add(this.dgvRepuestos);
            this.gbRepuestos.Controls.Add(this.btnAñadirRepuesto);
            this.gbRepuestos.Enabled = false;
            this.gbRepuestos.Location = new System.Drawing.Point(289, 153);
            this.gbRepuestos.Name = "gbRepuestos";
            this.gbRepuestos.Size = new System.Drawing.Size(315, 190);
            this.gbRepuestos.TabIndex = 17;
            this.gbRepuestos.TabStop = false;
            this.gbRepuestos.Text = "Repuestos";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(79, 52);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(131, 25);
            this.txtPrecio.TabIndex = 23;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 25);
            this.txtNombre.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Precio :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nombre :";
            // 
            // dgvRepuestos
            // 
            this.dgvRepuestos.AllowUserToAddRows = false;
            this.dgvRepuestos.AllowUserToDeleteRows = false;
            this.dgvRepuestos.AllowUserToResizeColumns = false;
            this.dgvRepuestos.AllowUserToResizeRows = false;
            this.dgvRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombre,
            this.clmPrecio});
            this.dgvRepuestos.Enabled = false;
            this.dgvRepuestos.Location = new System.Drawing.Point(39, 85);
            this.dgvRepuestos.Name = "dgvRepuestos";
            this.dgvRepuestos.ReadOnly = true;
            this.dgvRepuestos.RowHeadersVisible = false;
            this.dgvRepuestos.RowTemplate.Height = 25;
            this.dgvRepuestos.Size = new System.Drawing.Size(254, 99);
            this.dgvRepuestos.TabIndex = 19;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 125;
            // 
            // clmPrecio
            // 
            this.clmPrecio.HeaderText = "Precio";
            this.clmPrecio.Name = "clmPrecio";
            this.clmPrecio.ReadOnly = true;
            this.clmPrecio.Width = 125;
            // 
            // btnAñadirRepuesto
            // 
            this.btnAñadirRepuesto.BackColor = System.Drawing.Color.Gold;
            this.btnAñadirRepuesto.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAñadirRepuesto.Location = new System.Drawing.Point(216, 23);
            this.btnAñadirRepuesto.Name = "btnAñadirRepuesto";
            this.btnAñadirRepuesto.Size = new System.Drawing.Size(93, 34);
            this.btnAñadirRepuesto.TabIndex = 18;
            this.btnAñadirRepuesto.Text = "Añadir";
            this.btnAñadirRepuesto.UseVisualStyleBackColor = false;
            this.btnAñadirRepuesto.Click += new System.EventHandler(this.btnAñadirRepuesto_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.chkLstBxServicios);
            this.groupBox3.Location = new System.Drawing.Point(12, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 138);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servicios";
            // 
            // chkLstBxServicios
            // 
            this.chkLstBxServicios.CheckOnClick = true;
            this.chkLstBxServicios.FormattingEnabled = true;
            this.chkLstBxServicios.Location = new System.Drawing.Point(6, 22);
            this.chkLstBxServicios.Name = "chkLstBxServicios";
            this.chkLstBxServicios.Size = new System.Drawing.Size(254, 104);
            this.chkLstBxServicios.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Gold;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Location = new System.Drawing.Point(504, 368);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 34);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FormRegMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(616, 416);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbRepuestos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbDiagnostico);
            this.Controls.Add(this.cmbMecanicos);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaMantenimiento);
            this.Controls.Add(this.gbVehiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Mantenimiento";
            this.Load += new System.EventHandler(this.FormRegMantenimiento_Load);
            this.gbVehiculo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbRepuestos.ResumeLayout(false);
            this.gbRepuestos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private GroupBox gbVehiculo;
        private DateTimePicker dtpFechaMantenimiento;
        private Label label8;
        private ComboBox cmbClientes;
        private ComboBox cmbMecanicos;
        private RichTextBox rtbDiagnostico;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbPreventivo;
        private RadioButton rbCorrectivo;
        private GroupBox gbRepuestos;
        private Button btnAñadirRepuesto;
        private GroupBox groupBox3;
        private CheckedListBox chkLstBxServicios;
        private Button btnRegistrar;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label label10;
        private Label label9;
        private DataGridView dgvRepuestos;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn clmPrecio;
        private ComboBox cmbVehiculos;
        private Button btnAñadirVeh;
    }
}