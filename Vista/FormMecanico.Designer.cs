namespace TallerMantenimiento.Vista
{
    partial class FormMecanico
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
            this.gbRegMecanicos = new System.Windows.Forms.GroupBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbListarMecanicos = new System.Windows.Forms.GroupBox();
            this.dgvMecanicos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbEspecialidadMant = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtSalarioMant = new System.Windows.Forms.TextBox();
            this.txtCedulaMant = new System.Windows.Forms.TextBox();
            this.txtApellidoMant = new System.Windows.Forms.TextBox();
            this.txtNombreMant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbRegMecanicos.SuspendLayout();
            this.gbListarMecanicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMecanicos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegMecanicos
            // 
            this.gbRegMecanicos.BackColor = System.Drawing.Color.Silver;
            this.gbRegMecanicos.Controls.Add(this.cmbEspecialidad);
            this.gbRegMecanicos.Controls.Add(this.btnRegistrar);
            this.gbRegMecanicos.Controls.Add(this.txtSalario);
            this.gbRegMecanicos.Controls.Add(this.txtCedula);
            this.gbRegMecanicos.Controls.Add(this.txtApellido);
            this.gbRegMecanicos.Controls.Add(this.txtNombre);
            this.gbRegMecanicos.Controls.Add(this.label5);
            this.gbRegMecanicos.Controls.Add(this.label4);
            this.gbRegMecanicos.Controls.Add(this.label3);
            this.gbRegMecanicos.Controls.Add(this.label2);
            this.gbRegMecanicos.Controls.Add(this.label1);
            this.gbRegMecanicos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbRegMecanicos.Location = new System.Drawing.Point(12, 12);
            this.gbRegMecanicos.Name = "gbRegMecanicos";
            this.gbRegMecanicos.Size = new System.Drawing.Size(263, 220);
            this.gbRegMecanicos.TabIndex = 0;
            this.gbRegMecanicos.TabStop = false;
            this.gbRegMecanicos.Text = "Registrar";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(93, 109);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(151, 25);
            this.cmbEspecialidad.TabIndex = 36;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Gold;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Location = new System.Drawing.Point(150, 173);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 36);
            this.btnRegistrar.TabIndex = 34;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(93, 138);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(151, 25);
            this.txtSalario.TabIndex = 33;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(93, 80);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(151, 25);
            this.txtCedula.TabIndex = 32;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(93, 51);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(151, 25);
            this.txtApellido.TabIndex = 31;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 25);
            this.txtNombre.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Salario :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Especialidad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cédula :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Apellido :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre :";
            // 
            // gbListarMecanicos
            // 
            this.gbListarMecanicos.Controls.Add(this.dgvMecanicos);
            this.gbListarMecanicos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbListarMecanicos.Location = new System.Drawing.Point(281, 12);
            this.gbListarMecanicos.Name = "gbListarMecanicos";
            this.gbListarMecanicos.Size = new System.Drawing.Size(600, 462);
            this.gbListarMecanicos.TabIndex = 2;
            this.gbListarMecanicos.TabStop = false;
            this.gbListarMecanicos.Text = "Mecanicos";
            // 
            // dgvMecanicos
            // 
            this.dgvMecanicos.AllowUserToAddRows = false;
            this.dgvMecanicos.AllowUserToDeleteRows = false;
            this.dgvMecanicos.AllowUserToResizeRows = false;
            this.dgvMecanicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMecanicos.Location = new System.Drawing.Point(6, 27);
            this.dgvMecanicos.MultiSelect = false;
            this.dgvMecanicos.Name = "dgvMecanicos";
            this.dgvMecanicos.ReadOnly = true;
            this.dgvMecanicos.RowHeadersVisible = false;
            this.dgvMecanicos.RowTemplate.Height = 25;
            this.dgvMecanicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMecanicos.Size = new System.Drawing.Size(588, 422);
            this.dgvMecanicos.TabIndex = 0;
            this.dgvMecanicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMecanicos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.cmbEspecialidadMant);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.txtSalarioMant);
            this.groupBox1.Controls.Add(this.txtCedulaMant);
            this.groupBox1.Controls.Add(this.txtApellidoMant);
            this.groupBox1.Controls.Add(this.txtNombreMant);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 220);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gold;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(60, 173);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 34);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmbEspecialidadMant
            // 
            this.cmbEspecialidadMant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidadMant.FormattingEnabled = true;
            this.cmbEspecialidadMant.Location = new System.Drawing.Point(93, 109);
            this.cmbEspecialidadMant.Name = "cmbEspecialidadMant";
            this.cmbEspecialidadMant.Size = new System.Drawing.Size(151, 25);
            this.cmbEspecialidadMant.TabIndex = 36;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gold;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(155, 173);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 36);
            this.btnEditar.TabIndex = 34;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtSalarioMant
            // 
            this.txtSalarioMant.Location = new System.Drawing.Point(93, 138);
            this.txtSalarioMant.Name = "txtSalarioMant";
            this.txtSalarioMant.Size = new System.Drawing.Size(151, 25);
            this.txtSalarioMant.TabIndex = 33;
            this.txtSalarioMant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarioMant_KeyPress);
            // 
            // txtCedulaMant
            // 
            this.txtCedulaMant.Location = new System.Drawing.Point(93, 80);
            this.txtCedulaMant.MaxLength = 10;
            this.txtCedulaMant.Name = "txtCedulaMant";
            this.txtCedulaMant.Size = new System.Drawing.Size(151, 25);
            this.txtCedulaMant.TabIndex = 32;
            this.txtCedulaMant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaMant_KeyPress);
            // 
            // txtApellidoMant
            // 
            this.txtApellidoMant.Location = new System.Drawing.Point(93, 51);
            this.txtApellidoMant.Name = "txtApellidoMant";
            this.txtApellidoMant.Size = new System.Drawing.Size(151, 25);
            this.txtApellidoMant.TabIndex = 31;
            this.txtApellidoMant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoMant_KeyPress);
            // 
            // txtNombreMant
            // 
            this.txtNombreMant.Location = new System.Drawing.Point(93, 22);
            this.txtNombreMant.Name = "txtNombreMant";
            this.txtNombreMant.Size = new System.Drawing.Size(151, 25);
            this.txtNombreMant.TabIndex = 30;
            this.txtNombreMant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMant_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(10, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Salario :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(10, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Especialidad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(10, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "Cédula :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(10, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Apellido :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(10, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "Nombre :";
            // 
            // FormMecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbListarMecanicos);
            this.Controls.Add(this.gbRegMecanicos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMecanico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mecanico";
            this.gbRegMecanicos.ResumeLayout(false);
            this.gbRegMecanicos.PerformLayout();
            this.gbListarMecanicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMecanicos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbRegMecanicos;
        private ComboBox cmbEspecialidad;
        private Button btnRegistrar;
        private TextBox txtSalario;
        private TextBox txtCedula;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gbListarMecanicos;
        private DataGridView dgvMecanicos;
        private GroupBox groupBox1;
        private Button btnEliminar;
        private ComboBox cmbEspecialidadMant;
        private Button btnEditar;
        private TextBox txtSalarioMant;
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