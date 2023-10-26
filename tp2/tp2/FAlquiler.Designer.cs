
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
            this.gbAlquileres = new System.Windows.Forms.GroupBox();
            this.gbReservaNueva = new System.Windows.Forms.GroupBox();
            this.pnlCalendario = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCalendario = new System.Windows.Forms.DataGridView();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miércoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sábado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tlpNrosAlquiler = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nudNroPropiedadAlquiler = new System.Windows.Forms.NumericUpDown();
            this.lblNroPropiedad = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nudNroAlquiler = new System.Windows.Forms.NumericUpDown();
            this.lblNroAlquiler = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.btnCancelarAlquiler = new System.Windows.Forms.Button();
            this.gbAlquileres.SuspendLayout();
            this.gbReservaNueva.SuspendLayout();
            this.pnlCalendario.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendario)).BeginInit();
            this.panel4.SuspendLayout();
            this.tlpNrosAlquiler.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroPropiedadAlquiler)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroAlquiler)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAlquileres
            // 
            this.gbAlquileres.Controls.Add(this.gbReservaNueva);
            this.gbAlquileres.Controls.Add(this.panel4);
            this.gbAlquileres.Controls.Add(this.tableLayoutPanel3);
            this.gbAlquileres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAlquileres.Location = new System.Drawing.Point(0, 0);
            this.gbAlquileres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAlquileres.Name = "gbAlquileres";
            this.gbAlquileres.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAlquileres.Size = new System.Drawing.Size(551, 450);
            this.gbAlquileres.TabIndex = 2;
            this.gbAlquileres.TabStop = false;
            this.gbAlquileres.Text = "Alquileres";
            // 
            // gbReservaNueva
            // 
            this.gbReservaNueva.Controls.Add(this.pnlCalendario);
            this.gbReservaNueva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbReservaNueva.Location = new System.Drawing.Point(4, 68);
            this.gbReservaNueva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbReservaNueva.MinimumSize = new System.Drawing.Size(0, 198);
            this.gbReservaNueva.Name = "gbReservaNueva";
            this.gbReservaNueva.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbReservaNueva.Size = new System.Drawing.Size(422, 377);
            this.gbReservaNueva.TabIndex = 1;
            this.gbReservaNueva.TabStop = false;
            this.gbReservaNueva.Text = "Reserva Nueva";
            // 
            // pnlCalendario
            // 
            this.pnlCalendario.Controls.Add(this.tableLayoutPanel4);
            this.pnlCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCalendario.Location = new System.Drawing.Point(4, 18);
            this.pnlCalendario.Name = "pnlCalendario";
            this.pnlCalendario.Padding = new System.Windows.Forms.Padding(12);
            this.pnlCalendario.Size = new System.Drawing.Size(414, 354);
            this.pnlCalendario.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.dgvCalendario, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.cmbMes, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(390, 330);
            this.tableLayoutPanel4.TabIndex = 1;
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
            this.dgvCalendario.Location = new System.Drawing.Point(193, 90);
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
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(0, 90);
            this.cmbMes.Margin = new System.Windows.Forms.Padding(0, 3, 8, 8);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(182, 21);
            this.cmbMes.TabIndex = 1;
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.CmbMes_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tlpNrosAlquiler);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(4, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(422, 50);
            this.panel4.TabIndex = 0;
            // 
            // tlpNrosAlquiler
            // 
            this.tlpNrosAlquiler.ColumnCount = 2;
            this.tlpNrosAlquiler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNrosAlquiler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNrosAlquiler.Controls.Add(this.panel5, 0, 0);
            this.tlpNrosAlquiler.Controls.Add(this.panel6, 1, 0);
            this.tlpNrosAlquiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNrosAlquiler.Location = new System.Drawing.Point(0, 0);
            this.tlpNrosAlquiler.Name = "tlpNrosAlquiler";
            this.tlpNrosAlquiler.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tlpNrosAlquiler.RowCount = 1;
            this.tlpNrosAlquiler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNrosAlquiler.Size = new System.Drawing.Size(422, 50);
            this.tlpNrosAlquiler.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.nudNroPropiedadAlquiler);
            this.panel5.Controls.Add(this.lblNroPropiedad);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(6, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 50);
            this.panel5.TabIndex = 3;
            // 
            // nudNroPropiedadAlquiler
            // 
            this.nudNroPropiedadAlquiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudNroPropiedadAlquiler.Location = new System.Drawing.Point(0, 13);
            this.nudNroPropiedadAlquiler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudNroPropiedadAlquiler.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNroPropiedadAlquiler.Name = "nudNroPropiedadAlquiler";
            this.nudNroPropiedadAlquiler.Size = new System.Drawing.Size(202, 20);
            this.nudNroPropiedadAlquiler.TabIndex = 8;
            this.nudNroPropiedadAlquiler.ThousandsSeparator = true;
            // 
            // lblNroPropiedad
            // 
            this.lblNroPropiedad.AutoSize = true;
            this.lblNroPropiedad.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNroPropiedad.Location = new System.Drawing.Point(0, 0);
            this.lblNroPropiedad.Name = "lblNroPropiedad";
            this.lblNroPropiedad.Size = new System.Drawing.Size(78, 13);
            this.lblNroPropiedad.TabIndex = 7;
            this.lblNroPropiedad.Text = "Nro. Propiedad";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nudNroAlquiler);
            this.panel6.Controls.Add(this.lblNroAlquiler);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(214, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 50);
            this.panel6.TabIndex = 2;
            // 
            // nudNroAlquiler
            // 
            this.nudNroAlquiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudNroAlquiler.Location = new System.Drawing.Point(0, 13);
            this.nudNroAlquiler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudNroAlquiler.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNroAlquiler.Name = "nudNroAlquiler";
            this.nudNroAlquiler.Size = new System.Drawing.Size(202, 20);
            this.nudNroAlquiler.TabIndex = 5;
            this.nudNroAlquiler.ThousandsSeparator = true;
            // 
            // lblNroAlquiler
            // 
            this.lblNroAlquiler.AutoSize = true;
            this.lblNroAlquiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNroAlquiler.Location = new System.Drawing.Point(0, 0);
            this.lblNroAlquiler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroAlquiler.Name = "lblNroAlquiler";
            this.lblNroAlquiler.Size = new System.Drawing.Size(64, 13);
            this.lblNroAlquiler.TabIndex = 6;
            this.lblNroAlquiler.Text = "Nro. Alquiler";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnAlquilar, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnCancelarAlquiler, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(426, 18);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(121, 427);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(70)))));
            this.btnAlquilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlquilar.FlatAppearance.BorderSize = 0;
            this.btnAlquilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlquilar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnAlquilar.Location = new System.Drawing.Point(4, 217);
            this.btnAlquilar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(113, 206);
            this.btnAlquilar.TabIndex = 4;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = false;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // btnCancelarAlquiler
            // 
            this.btnCancelarAlquiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnCancelarAlquiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelarAlquiler.FlatAppearance.BorderSize = 0;
            this.btnCancelarAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAlquiler.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnCancelarAlquiler.Location = new System.Drawing.Point(4, 4);
            this.btnCancelarAlquiler.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarAlquiler.Name = "btnCancelarAlquiler";
            this.btnCancelarAlquiler.Size = new System.Drawing.Size(113, 205);
            this.btnCancelarAlquiler.TabIndex = 3;
            this.btnCancelarAlquiler.Text = "Cancelar";
            this.btnCancelarAlquiler.UseVisualStyleBackColor = false;
            this.btnCancelarAlquiler.Click += new System.EventHandler(this.btnCancelarAlquiler_Click);
            // 
            // FAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.gbAlquileres);
            this.Name = "FAlquiler";
            this.Text = "Alquiler";
            this.Load += new System.EventHandler(this.FAlquilar_Load);
            this.gbAlquileres.ResumeLayout(false);
            this.gbReservaNueva.ResumeLayout(false);
            this.pnlCalendario.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendario)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tlpNrosAlquiler.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroPropiedadAlquiler)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroAlquiler)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbAlquileres;
		private System.Windows.Forms.GroupBox gbReservaNueva;
		private System.Windows.Forms.Panel pnlCalendario;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.DataGridView dgvCalendario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
		private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
		private System.Windows.Forms.DataGridViewTextBoxColumn Miércoles;
		private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
		private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sábado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Domingo;
		private System.Windows.Forms.ComboBox cmbMes;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TableLayoutPanel tlpNrosAlquiler;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.NumericUpDown nudNroPropiedadAlquiler;
		private System.Windows.Forms.Label lblNroPropiedad;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.NumericUpDown nudNroAlquiler;
		private System.Windows.Forms.Label lblNroAlquiler;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button btnAlquilar;
		private System.Windows.Forms.Button btnCancelarAlquiler;
	}
}