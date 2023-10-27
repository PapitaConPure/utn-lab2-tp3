
namespace tp2 {
	partial class FNuevoSistema {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.gbPrecioBase = new System.Windows.Forms.GroupBox();
			this.nudPrecioBase = new System.Windows.Forms.NumericUpDown();
			this.pnlAceptar = new System.Windows.Forms.Panel();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.gbPrecioBase.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPrecioBase)).BeginInit();
			this.pnlAceptar.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbPrecioBase
			// 
			this.gbPrecioBase.Controls.Add(this.nudPrecioBase);
			this.gbPrecioBase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbPrecioBase.Location = new System.Drawing.Point(16, 18);
			this.gbPrecioBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbPrecioBase.Name = "gbPrecioBase";
			this.gbPrecioBase.Padding = new System.Windows.Forms.Padding(4, 2, 4, 5);
			this.gbPrecioBase.Size = new System.Drawing.Size(252, 55);
			this.gbPrecioBase.TabIndex = 0;
			this.gbPrecioBase.TabStop = false;
			this.gbPrecioBase.Text = "Precio Base de Residencias";
			// 
			// nudPrecioBase
			// 
			this.nudPrecioBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nudPrecioBase.DecimalPlaces = 2;
			this.nudPrecioBase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudPrecioBase.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.nudPrecioBase.Location = new System.Drawing.Point(4, 22);
			this.nudPrecioBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudPrecioBase.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.nudPrecioBase.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudPrecioBase.Name = "nudPrecioBase";
			this.nudPrecioBase.Size = new System.Drawing.Size(244, 27);
			this.nudPrecioBase.TabIndex = 4;
			this.nudPrecioBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudPrecioBase.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// pnlAceptar
			// 
			this.pnlAceptar.Controls.Add(this.btnAceptar);
			this.pnlAceptar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlAceptar.Location = new System.Drawing.Point(16, 73);
			this.pnlAceptar.Name = "pnlAceptar";
			this.pnlAceptar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pnlAceptar.Size = new System.Drawing.Size(252, 42);
			this.pnlAceptar.TabIndex = 6;
			// 
			// btnAceptar
			// 
			this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(70)))));
			this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAceptar.FlatAppearance.BorderSize = 0;
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.btnAceptar.Location = new System.Drawing.Point(4, 5);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(244, 32);
			this.btnAceptar.TabIndex = 6;
			this.btnAceptar.Text = "Confirmar";
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
			// 
			// FPrecioBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 133);
			this.ControlBox = false;
			this.Controls.Add(this.gbPrecioBase);
			this.Controls.Add(this.pnlAceptar);
			this.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximumSize = new System.Drawing.Size(300, 172);
			this.MinimumSize = new System.Drawing.Size(300, 172);
			this.Name = "FPrecioBase";
			this.Padding = new System.Windows.Forms.Padding(16, 18, 16, 18);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Base del Sistema";
			this.gbPrecioBase.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudPrecioBase)).EndInit();
			this.pnlAceptar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbPrecioBase;
		private System.Windows.Forms.Panel pnlAceptar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.NumericUpDown nudPrecioBase;
	}
}