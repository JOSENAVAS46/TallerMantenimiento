namespace TallerMantenimiento.Vista
{
    partial class FormCliente
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
            this.gbRegCliente = new System.Windows.Forms.GroupBox();
            this.bttRegistrar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbListarClientes = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtTelefonoMant = new System.Windows.Forms.TextBox();
            this.txtCorreoMant = new System.Windows.Forms.TextBox();
            this.txtCedulaMant = new System.Windows.Forms.TextBox();
            this.txtApellidoMant = new System.Windows.Forms.TextBox();
            this.txtNombreMant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbRegCliente.SuspendLayout();
            this.gbListarClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gbMantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegCliente
            // 
            this.gbRegCliente.BackColor = System.Drawing.Color.Silver;
            this.gbRegCliente.Controls.Add(this.bttRegistrar);
            this.gbRegCliente.Controls.Add(this.txtTelefono);
            this.gbRegCliente.Controls.Add(this.txtCorreo);
            this.gbRegCliente.Controls.Add(this.txtCedula);
            this.gbRegCliente.Controls.Add(this.txtApellido);
            this.gbRegCliente.Controls.Add(this.txtNombre);
            this.gbRegCliente.Controls.Add(this.label5);
            this.gbRegCliente.Controls.Add(this.label4);
            this.gbRegCliente.Controls.Add(this.label3);
            this.gbRegCliente.Controls.Add(this.label2);
            this.gbRegCliente.Controls.Add(this.label1);
            this.gbRegCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbRegCliente.Location = new System.Drawing.Point(12, 14);
            this.gbRegCliente.Name = "gbRegCliente";
            this.gbRegCliente.Size = new System.Drawing.Size(250, 264);
            this.gbRegCliente.TabIndex = 0;
            this.gbRegCliente.TabStop = false;
            this.gbRegCliente.Text = "Registro";
            // 
            // bttRegistrar
            // 
            this.bttRegistrar.BackColor = System.Drawing.Color.Gold;
            this.bttRegistrar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bttRegistrar.Location = new System.Drawing.Point(150, 219);
            this.bttRegistrar.Name = "bttRegistrar";
            this.bttRegistrar.Size = new System.Drawing.Size(94, 39);
            this.bttRegistrar.TabIndex = 10;
            this.bttRegistrar.Text = "Registrar";
            this.bttRegistrar.UseVisualStyleBackColor = false;
            this.bttRegistrar.Click += new System.EventHandler(this.bttRegistrar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(77, 160);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(153, 25);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(77, 127);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(153, 25);
            this.txtCorreo.TabIndex = 8;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(77, 94);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(153, 25);
            this.txtCedula.TabIndex = 7;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(77, 61);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(153, 25);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(77, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 25);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cedula :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            // 
            // gbListarClientes
            // 
            this.gbListarClientes.Controls.Add(this.dgvClientes);
            this.gbListarClientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbListarClientes.Location = new System.Drawing.Point(268, 14);
            this.gbListarClientes.Name = "gbListarClientes";
            this.gbListarClientes.Size = new System.Drawing.Size(600, 535);
            this.gbListarClientes.TabIndex = 1;
            this.gbListarClientes.TabStop = false;
            this.gbListarClientes.Text = "Clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 31);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(588, 493);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.BackColor = System.Drawing.Color.Silver;
            this.gbMantenimiento.Controls.Add(this.btnEliminar);
            this.gbMantenimiento.Controls.Add(this.btnEditar);
            this.gbMantenimiento.Controls.Add(this.txtTelefonoMant);
            this.gbMantenimiento.Controls.Add(this.txtCorreoMant);
            this.gbMantenimiento.Controls.Add(this.txtCedulaMant);
            this.gbMantenimiento.Controls.Add(this.txtApellidoMant);
            this.gbMantenimiento.Controls.Add(this.txtNombreMant);
            this.gbMantenimiento.Controls.Add(this.label6);
            this.gbMantenimiento.Controls.Add(this.label7);
            this.gbMantenimiento.Controls.Add(this.label8);
            this.gbMantenimiento.Controls.Add(this.label9);
            this.gbMantenimiento.Controls.Add(this.label10);
            this.gbMantenimiento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbMantenimiento.Location = new System.Drawing.Point(12, 284);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Size = new System.Drawing.Size(250, 264);
            this.gbMantenimiento.TabIndex = 3;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Mantenimiento";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gold;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(48, 213);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 39);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gold;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(148, 215);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 39);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtTelefonoMant
            // 
            this.txtTelefonoMant.Location = new System.Drawing.Point(77, 160);
            this.txtTelefonoMant.Name = "txtTelefonoMant";
            this.txtTelefonoMant.Size = new System.Drawing.Size(153, 25);
            this.txtTelefonoMant.TabIndex = 9;
            this.txtTelefonoMant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoMant_KeyPress);
            // 
            // txtCorreoMant
            // 
            this.txtCorreoMant.Location = new System.Drawing.Point(77, 127);
            this.txtCorreoMant.Name = "txtCorreoMant";
            this.txtCorreoMant.Size = new System.Drawing.Size(153, 25);
            this.txtCorreoMant.TabIndex = 8;
            // 
            // txtCedulaMant
            // 
            this.txtCedulaMant.Location = new System.Drawing.Point(77, 94);
            this.txtCedulaMant.Name = "txtCedulaMant";
            this.txtCedulaMant.Size = new System.Drawing.Size(153, 25);
            this.txtCedulaMant.TabIndex = 7;
            this.txtCedulaMant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaMant_KeyPress);
            // 
            // txtApellidoMant
            // 
            this.txtApellidoMant.Location = new System.Drawing.Point(77, 61);
            this.txtApellidoMant.Name = "txtApellidoMant";
            this.txtApellidoMant.Size = new System.Drawing.Size(153, 25);
            this.txtApellidoMant.TabIndex = 6;
            this.txtApellidoMant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoMant_KeyPress);
            // 
            // txtNombreMant
            // 
            this.txtNombreMant.Location = new System.Drawing.Point(77, 28);
            this.txtNombreMant.Name = "txtNombreMant";
            this.txtNombreMant.Size = new System.Drawing.Size(153, 25);
            this.txtNombreMant.TabIndex = 5;
            this.txtNombreMant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMant_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefono :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Correo :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cedula :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Apellido :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nombre :";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(884, 550);
            this.Controls.Add(this.gbMantenimiento);
            this.Controls.Add(this.gbListarClientes);
            this.Controls.Add(this.gbRegCliente);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.gbRegCliente.ResumeLayout(false);
            this.gbRegCliente.PerformLayout();
            this.gbListarClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gbMantenimiento.ResumeLayout(false);
            this.gbMantenimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbRegCliente;
        private Button btnCancelar;
        private Button btnRegistrar;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtCedula;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmCedula;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn clmApellido;
        private DataGridViewTextBoxColumn clmCorreo;
        private DataGridViewTextBoxColumn clmTelefono;
        private Button bttRegistrar;
        private GroupBox gbListarClientes;
        private GroupBox gbMantenimiento;
        private Button btnEliminar;
        private Button btnEditar;
        private TextBox txtTelefonoMant;
        private TextBox txtCorreoMant;
        private TextBox txtCedulaMant;
        private TextBox txtApellidoMant;
        private TextBox txtNombreMant;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}