
namespace tp2 {
	partial class FAlquiler {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tlpCalendario = new System.Windows.Forms.TableLayoutPanel();
			this.dgvCalendario = new System.Windows.Forms.DataGridView();
			this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Miércoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sábado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmbMes = new System.Windows.Forms.ComboBox();
			this.tlpBotonesAlquiler = new System.Windows.Forms.TableLayoutPanel();
			this.btnAlquilar = new System.Windows.Forms.Button();
			this.btnCancelarAlquiler = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.tlpCalendario.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCalendario)).BeginInit();
			this.tlpBotonesAlquiler.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpCalendario
			// 
			this.tlpCalendario.ColumnCount = 2;
			this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpCalendario.Controls.Add(this.dgvCalendario, 1, 1);
			this.tlpCalendario.Controls.Add(this.cmbMes, 0, 1);
			this.tlpCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpCalendario.Location = new System.Drawing.Point(0, 0);
			this.tlpCalendario.Name = "tlpCalendario";
			this.tlpCalendario.RowCount = 3;
			this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
			this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCalendario.Size = new System.Drawing.Size(380, 205);
			this.tlpCalendario.TabIndex = 1;
			// 
			// dgvCalendario
			// 
			this.dgvCalendario.AllowUserToAddRows = false;
			this.dgvCalendario.AllowUserToDeleteRows = false;
			this.dgvCalendario.AllowUserToResizeColumns = false;
			this.dgvCalendario.AllowUserToResizeRows = false;
			this.dgvCalendario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.dgvCalendario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvCalendario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCalendario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCalendario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lunes,
            this.Martes,
            this.Miércoles,
            this.Jueves,
            this.Viernes,
            this.Sábado,
            this.Domingo});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCalendario.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCalendario.EnableHeadersVisualStyles = false;
			this.dgvCalendario.Location = new System.Drawing.Point(183, 27);
			this.dgvCalendario.MultiSelect = false;
			this.dgvCalendario.Name = "dgvCalendario";
			this.dgvCalendario.ReadOnly = true;
			this.dgvCalendario.RowHeadersVisible = false;
			this.dgvCalendario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvCalendario.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dgvCalendario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvCalendario.Size = new System.Drawing.Size(194, 150);
			this.dgvCalendario.TabIndex = 0;
			// 
			// Lunes
			// 
			this.Lunes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Lunes.FillWeight = 14.28571F;
			this.Lunes.HeaderText = "L";
			this.Lunes.Name = "Lunes";
			this.Lunes.ReadOnly = true;
			this.Lunes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Martes
			// 
			this.Martes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Martes.FillWeight = 14.28571F;
			this.Martes.HeaderText = "M";
			this.Martes.Name = "Martes";
			this.Martes.ReadOnly = true;
			this.Martes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Miércoles
			// 
			this.Miércoles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Miércoles.FillWeight = 14.28571F;
			this.Miércoles.HeaderText = "M";
			this.Miércoles.Name = "Miércoles";
			this.Miércoles.ReadOnly = true;
			this.Miércoles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Jueves
			// 
			this.Jueves.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Jueves.FillWeight = 14.28571F;
			this.Jueves.HeaderText = "J";
			this.Jueves.Name = "Jueves";
			this.Jueves.ReadOnly = true;
			this.Jueves.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Viernes
			// 
			this.Viernes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Viernes.FillWeight = 14.28571F;
			this.Viernes.HeaderText = "V";
			this.Viernes.Name = "Viernes";
			this.Viernes.ReadOnly = true;
			this.Viernes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Sábado
			// 
			this.Sábado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Sábado.FillWeight = 14.28571F;
			this.Sábado.HeaderText = "S";
			this.Sábado.Name = "Sábado";
			this.Sábado.ReadOnly = true;
			this.Sábado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Domingo
			// 
			this.Domingo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Domingo.FillWeight = 14.28571F;
			this.Domingo.HeaderText = "D";
			this.Domingo.Name = "Domingo";
			this.Domingo.ReadOnly = true;
			this.Domingo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// cmbMes
			// 
			this.cmbMes.Dock = System.Windows.Forms.DockStyle.Top;
			this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMes.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.cmbMes.FormattingEnabled = true;
			this.cmbMes.Location = new System.Drawing.Point(8, 27);
			this.cmbMes.Margin = new System.Windows.Forms.Padding(8, 3, 8, 8);
			this.cmbMes.Name = "cmbMes";
			this.cmbMes.Size = new System.Drawing.Size(164, 28);
			this.cmbMes.TabIndex = 1;
			this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.CmbMes_SelectedIndexChanged);
			// 
			// tlpBotonesAlquiler
			// 
			this.tlpBotonesAlquiler.ColumnCount = 3;
			this.tlpBotonesAlquiler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpBotonesAlquiler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpBotonesAlquiler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpBotonesAlquiler.Controls.Add(this.btnAlquilar, 0, 0);
			this.tlpBotonesAlquiler.Controls.Add(this.btnCancelarAlquiler, 1, 0);
			this.tlpBotonesAlquiler.Controls.Add(this.btnCerrar, 2, 0);
			this.tlpBotonesAlquiler.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tlpBotonesAlquiler.Location = new System.Drawing.Point(0, 205);
			this.tlpBotonesAlquiler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tlpBotonesAlquiler.Name = "tlpBotonesAlquiler";
			this.tlpBotonesAlquiler.RowCount = 1;
			this.tlpBotonesAlquiler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpBotonesAlquiler.Size = new System.Drawing.Size(380, 56);
			this.tlpBotonesAlquiler.TabIndex = 2;
			// 
			// btnAlquilar
			// 
			this.btnAlquilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(70)))));
			this.btnAlquilar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAlquilar.FlatAppearance.BorderSize = 0;
			this.btnAlquilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlquilar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnAlquilar.Location = new System.Drawing.Point(4, 4);
			this.btnAlquilar.Margin = new System.Windows.Forms.Padding(4);
			this.btnAlquilar.Name = "btnAlquilar";
			this.btnAlquilar.Size = new System.Drawing.Size(118, 48);
			this.btnAlquilar.TabIndex = 1;
			this.btnAlquilar.Text = "Alquilar Residencia";
			this.btnAlquilar.UseVisualStyleBackColor = false;
			this.btnAlquilar.Click += new System.EventHandler(this.BtnAlquilar_Click);
			// 
			// btnCancelarAlquiler
			// 
			this.btnCancelarAlquiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
			this.btnCancelarAlquiler.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCancelarAlquiler.FlatAppearance.BorderSize = 0;
			this.btnCancelarAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelarAlquiler.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnCancelarAlquiler.ForeColor = System.Drawing.Color.White;
			this.btnCancelarAlquiler.Location = new System.Drawing.Point(130, 4);
			this.btnCancelarAlquiler.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancelarAlquiler.Name = "btnCancelarAlquiler";
			this.btnCancelarAlquiler.Size = new System.Drawing.Size(118, 48);
			this.btnCancelarAlquiler.TabIndex = 0;
			this.btnCancelarAlquiler.Text = "Cancelar Alquiler";
			this.btnCancelarAlquiler.UseVisualStyleBackColor = false;
			this.btnCancelarAlquiler.Click += new System.EventHandler(this.BtnCancelarAlquiler_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
			this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Abort;
			this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCerrar.FlatAppearance.BorderSize = 0;
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCerrar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnCerrar.Location = new System.Drawing.Point(256, 4);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(120, 48);
			this.btnCerrar.TabIndex = 0;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			// 
			// FAlquiler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 261);
			this.Controls.Add(this.tlpCalendario);
			this.Controls.Add(this.tlpBotonesAlquiler);
			this.MinimumSize = new System.Drawing.Size(380, 300);
			this.Name = "FAlquiler";
			this.Text = "Alquiler";
			this.Load += new System.EventHandler(this.FAlquilar_Load);
			this.tlpCalendario.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCalendario)).EndInit();
			this.tlpBotonesAlquiler.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tlpCalendario;
		private System.Windows.Forms.DataGridView dgvCalendario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
		private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
		private System.Windows.Forms.DataGridViewTextBoxColumn Miércoles;
		private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
		private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sábado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Domingo;
		private System.Windows.Forms.ComboBox cmbMes;
		private System.Windows.Forms.TableLayoutPanel tlpBotonesAlquiler;
		private System.Windows.Forms.Button btnAlquilar;
		private System.Windows.Forms.Button btnCancelarAlquiler;
		private System.Windows.Forms.Button btnCerrar;
	}
}