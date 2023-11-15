
namespace tp2
{
    partial class FPasajero
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
			this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
			this.nudDniPasajero = new System.Windows.Forms.NumericUpDown();
			this.tbNombrePasajero = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.tbApellido = new System.Windows.Forms.TextBox();
			this.gbNombre = new System.Windows.Forms.GroupBox();
			this.gbApellido = new System.Windows.Forms.GroupBox();
			this.gbDni = new System.Windows.Forms.GroupBox();
			this.gbFechaNacimiento = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.nudDniPasajero)).BeginInit();
			this.gbNombre.SuspendLayout();
			this.gbApellido.SuspendLayout();
			this.gbDni.SuspendLayout();
			this.gbFechaNacimiento.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtpFechaNacimiento
			// 
			this.dtpFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.dtpFechaNacimiento.Location = new System.Drawing.Point(3, 17);
			this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dtpFechaNacimiento.MaxDate = new System.DateTime(2023, 11, 12, 0, 0, 0, 0);
			this.dtpFechaNacimiento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
			this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
			this.dtpFechaNacimiento.Size = new System.Drawing.Size(278, 27);
			this.dtpFechaNacimiento.TabIndex = 0;
			this.dtpFechaNacimiento.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
			// 
			// nudDniPasajero
			// 
			this.nudDniPasajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.nudDniPasajero.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudDniPasajero.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudDniPasajero.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.nudDniPasajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.nudDniPasajero.Location = new System.Drawing.Point(3, 19);
			this.nudDniPasajero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudDniPasajero.Maximum = new decimal(new int[] {
            99000000,
            0,
            0,
            0});
			this.nudDniPasajero.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.nudDniPasajero.Name = "nudDniPasajero";
			this.nudDniPasajero.Size = new System.Drawing.Size(278, 23);
			this.nudDniPasajero.TabIndex = 0;
			this.nudDniPasajero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudDniPasajero.ThousandsSeparator = true;
			this.nudDniPasajero.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			// 
			// tbNombrePasajero
			// 
			this.tbNombrePasajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.tbNombrePasajero.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbNombrePasajero.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbNombrePasajero.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tbNombrePasajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.tbNombrePasajero.Location = new System.Drawing.Point(3, 19);
			this.tbNombrePasajero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbNombrePasajero.MaxLength = 16;
			this.tbNombrePasajero.Name = "tbNombrePasajero";
			this.tbNombrePasajero.Size = new System.Drawing.Size(278, 20);
			this.tbNombrePasajero.TabIndex = 0;
			// 
			// btnAceptar
			// 
			this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
			this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnAceptar.FlatAppearance.BorderSize = 0;
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btnAceptar.Image = global::tp2.Properties.Resources.plusblack24;
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.Location = new System.Drawing.Point(12, 221);
			this.btnAceptar.Margin = new System.Windows.Forms.Padding(0, 3, 6, 3);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(284, 39);
			this.btnAceptar.TabIndex = 0;
			this.btnAceptar.Text = "      Siguiente";
			this.btnAceptar.UseVisualStyleBackColor = false;
			// 
			// tbApellido
			// 
			this.tbApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.tbApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbApellido.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbApellido.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tbApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.tbApellido.Location = new System.Drawing.Point(3, 19);
			this.tbApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbApellido.MaxLength = 16;
			this.tbApellido.Name = "tbApellido";
			this.tbApellido.Size = new System.Drawing.Size(278, 20);
			this.tbApellido.TabIndex = 0;
			// 
			// gbNombre
			// 
			this.gbNombre.Controls.Add(this.tbNombrePasajero);
			this.gbNombre.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.gbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
			this.gbNombre.Location = new System.Drawing.Point(12, 110);
			this.gbNombre.Name = "gbNombre";
			this.gbNombre.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.gbNombre.Size = new System.Drawing.Size(284, 49);
			this.gbNombre.TabIndex = 2;
			this.gbNombre.TabStop = false;
			this.gbNombre.Text = "NOMBRE";
			// 
			// gbApellido
			// 
			this.gbApellido.Controls.Add(this.tbApellido);
			this.gbApellido.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.gbApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
			this.gbApellido.Location = new System.Drawing.Point(12, 61);
			this.gbApellido.Name = "gbApellido";
			this.gbApellido.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.gbApellido.Size = new System.Drawing.Size(284, 49);
			this.gbApellido.TabIndex = 1;
			this.gbApellido.TabStop = false;
			this.gbApellido.Text = "APELLIDO";
			// 
			// gbDni
			// 
			this.gbDni.Controls.Add(this.nudDniPasajero);
			this.gbDni.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.gbDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
			this.gbDni.Location = new System.Drawing.Point(12, 12);
			this.gbDni.Name = "gbDni";
			this.gbDni.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.gbDni.Size = new System.Drawing.Size(284, 49);
			this.gbDni.TabIndex = 0;
			this.gbDni.TabStop = false;
			this.gbDni.Text = "DNI";
			// 
			// gbFechaNacimiento
			// 
			this.gbFechaNacimiento.Controls.Add(this.dtpFechaNacimiento);
			this.gbFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.gbFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
			this.gbFechaNacimiento.Location = new System.Drawing.Point(12, 159);
			this.gbFechaNacimiento.Name = "gbFechaNacimiento";
			this.gbFechaNacimiento.Size = new System.Drawing.Size(284, 49);
			this.gbFechaNacimiento.TabIndex = 3;
			this.gbFechaNacimiento.TabStop = false;
			this.gbFechaNacimiento.Text = "F. DE NACIMIENTO";
			// 
			// FPasajero
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
			this.ClientSize = new System.Drawing.Size(308, 272);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.gbFechaNacimiento);
			this.Controls.Add(this.gbNombre);
			this.Controls.Add(this.gbApellido);
			this.Controls.Add(this.gbDni);
			this.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FPasajero";
			this.Padding = new System.Windows.Forms.Padding(12);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FPasajero";
			this.Load += new System.EventHandler(this.FPasajero_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FPasajero_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FPasajero_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FPasajero_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.nudDniPasajero)).EndInit();
			this.gbNombre.ResumeLayout(false);
			this.gbNombre.PerformLayout();
			this.gbApellido.ResumeLayout(false);
			this.gbApellido.PerformLayout();
			this.gbDni.ResumeLayout(false);
			this.gbFechaNacimiento.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        public System.Windows.Forms.NumericUpDown nudDniPasajero;
        public System.Windows.Forms.TextBox tbNombrePasajero;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.TextBox tbApellido;
		private System.Windows.Forms.GroupBox gbNombre;
		private System.Windows.Forms.GroupBox gbApellido;
		private System.Windows.Forms.GroupBox gbDni;
		private System.Windows.Forms.GroupBox gbFechaNacimiento;
	}
}