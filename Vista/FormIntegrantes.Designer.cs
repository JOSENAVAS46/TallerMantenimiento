namespace TallerMantenimiento.Vista
{
    partial class FormIntegrantes
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
            this.flpTarjetas = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpTarjetas
            // 
            this.flpTarjetas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.flpTarjetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTarjetas.Location = new System.Drawing.Point(0, 0);
            this.flpTarjetas.Name = "flpTarjetas";
            this.flpTarjetas.Size = new System.Drawing.Size(642, 399);
            this.flpTarjetas.TabIndex = 0;
            // 
            // FormIntegrantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(642, 399);
            this.Controls.Add(this.flpTarjetas);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIntegrantes";
            this.Text = "Integrantes";
            this.Load += new System.EventHandler(this.FormIntegrantes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flpTarjetas;
    }
}