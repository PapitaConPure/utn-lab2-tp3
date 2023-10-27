namespace tp2
{
    partial class FFechaAlquiler
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
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.calendario = new System.Windows.Forms.MonthCalendar();
			this.SuspendLayout();
			// 
			// btnAceptar
			// 
			this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAceptar.Location = new System.Drawing.Point(7, 212);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(219, 23);
			this.btnAceptar.TabIndex = 1;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			// 
			// btnCancelar
			// 
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.Location = new System.Drawing.Point(288, 212);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(219, 23);
			this.btnCancelar.TabIndex = 2;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// calindario
			// 
			this.calendario.CalendarDimensions = new System.Drawing.Size(2, 1);
			this.calendario.Location = new System.Drawing.Point(7, 18);
			this.calendario.MaxDate = new System.DateTime(2024, 2, 1, 0, 0, 0, 0);
			this.calendario.MaxSelectionCount = 31;
			this.calendario.Name = "calindario";
			this.calendario.TabIndex = 3;
			this.calendario.TodayDate = new System.DateTime(((long)(0)));
			// 
			// FAlquiler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(512, 259);
			this.Controls.Add(this.calendario);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Name = "FAlquiler";
			this.Text = "FM1";
			this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.MonthCalendar calendario;
    }
}