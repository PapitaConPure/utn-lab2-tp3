
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
			this.tlpBotonesMes = new System.Windows.Forms.TableLayoutPanel();
			this.btnMes1 = new System.Windows.Forms.Button();
			this.btnMes2 = new System.Windows.Forms.Button();
			this.btnMes3 = new System.Windows.Forms.Button();
			this.tlpBotonesAlquiler = new System.Windows.Forms.TableLayoutPanel();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.pnlBotonesAceptar = new System.Windows.Forms.Panel();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnAlquilar = new System.Windows.Forms.Button();
			this.gbPropietario = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.lbDNI = new System.Windows.Forms.Label();
			this.nudTel = new System.Windows.Forms.NumericUpDown();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.lbTel = new System.Windows.Forms.Label();
			this.tbApellido = new System.Windows.Forms.TextBox();
			this.nudDNI = new System.Windows.Forms.NumericUpDown();
			this.lbNombres = new System.Windows.Forms.Label();
			this.lbApellido = new System.Windows.Forms.Label();
			this.nudCantPasajeros = new System.Windows.Forms.NumericUpDown();
			this.pnlControl = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.gbCantPasajeros = new System.Windows.Forms.GroupBox();
			this.gbCantDías = new System.Windows.Forms.GroupBox();
			this.nudCantDias = new System.Windows.Forms.NumericUpDown();
			this.tlpCalendario.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCalendario)).BeginInit();
			this.tlpBotonesMes.SuspendLayout();
			this.tlpBotonesAlquiler.SuspendLayout();
			this.pnlBotonesAceptar.SuspendLayout();
			this.gbPropietario.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDNI)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantPasajeros)).BeginInit();
			this.pnlControl.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.gbCantPasajeros.SuspendLayout();
			this.gbCantDías.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantDias)).BeginInit();
			this.SuspendLayout();
			// 
			// tlpCalendario
			// 
			this.tlpCalendario.AutoSize = true;
			this.tlpCalendario.ColumnCount = 1;
			this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpCalendario.Controls.Add(this.dgvCalendario, 0, 1);
			this.tlpCalendario.Controls.Add(this.tlpBotonesMes, 0, 2);
			this.tlpCalendario.Dock = System.Windows.Forms.DockStyle.Left;
			this.tlpCalendario.Location = new System.Drawing.Point(0, 0);
			this.tlpCalendario.Name = "tlpCalendario";
			this.tlpCalendario.Padding = new System.Windows.Forms.Padding(3);
			this.tlpCalendario.RowCount = 4;
			this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
			this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpCalendario.Size = new System.Drawing.Size(206, 325);
			this.tlpCalendario.TabIndex = 0;
			// 
			// dgvCalendario
			// 
			this.dgvCalendario.AllowUserToAddRows = false;
			this.dgvCalendario.AllowUserToDeleteRows = false;
			this.dgvCalendario.AllowUserToResizeColumns = false;
			this.dgvCalendario.AllowUserToResizeRows = false;
			this.dgvCalendario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
			this.dgvCalendario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvCalendario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
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
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCalendario.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCalendario.EnableHeadersVisualStyles = false;
			this.dgvCalendario.Location = new System.Drawing.Point(6, 63);
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
			// tlpBotonesMes
			// 
			this.tlpBotonesMes.ColumnCount = 3;
			this.tlpBotonesMes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpBotonesMes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpBotonesMes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpBotonesMes.Controls.Add(this.btnMes1, 0, 0);
			this.tlpBotonesMes.Controls.Add(this.btnMes2, 1, 0);
			this.tlpBotonesMes.Controls.Add(this.btnMes3, 2, 0);
			this.tlpBotonesMes.Location = new System.Drawing.Point(6, 219);
			this.tlpBotonesMes.Name = "tlpBotonesMes";
			this.tlpBotonesMes.RowCount = 1;
			this.tlpBotonesMes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpBotonesMes.Size = new System.Drawing.Size(194, 43);
			this.tlpBotonesMes.TabIndex = 1;
			// 
			// btnMes1
			// 
			this.btnMes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
			this.btnMes1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnMes1.FlatAppearance.BorderSize = 0;
			this.btnMes1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMes1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnMes1.Location = new System.Drawing.Point(3, 6);
			this.btnMes1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.btnMes1.Name = "btnMes1";
			this.btnMes1.Size = new System.Drawing.Size(58, 31);
			this.btnMes1.TabIndex = 0;
			this.btnMes1.Text = "MES";
			this.btnMes1.UseVisualStyleBackColor = false;
			this.btnMes1.Click += new System.EventHandler(this.BtnMes_Click);
			// 
			// btnMes2
			// 
			this.btnMes2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
			this.btnMes2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnMes2.FlatAppearance.BorderSize = 0;
			this.btnMes2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMes2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnMes2.Location = new System.Drawing.Point(67, 6);
			this.btnMes2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.btnMes2.Name = "btnMes2";
			this.btnMes2.Size = new System.Drawing.Size(58, 31);
			this.btnMes2.TabIndex = 1;
			this.btnMes2.Text = "MES";
			this.btnMes2.UseVisualStyleBackColor = false;
			this.btnMes2.Click += new System.EventHandler(this.BtnMes_Click);
			// 
			// btnMes3
			// 
			this.btnMes3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
			this.btnMes3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnMes3.FlatAppearance.BorderSize = 0;
			this.btnMes3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMes3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnMes3.Location = new System.Drawing.Point(131, 6);
			this.btnMes3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.btnMes3.Name = "btnMes3";
			this.btnMes3.Size = new System.Drawing.Size(60, 31);
			this.btnMes3.TabIndex = 2;
			this.btnMes3.Text = "MES";
			this.btnMes3.UseVisualStyleBackColor = false;
			this.btnMes3.Click += new System.EventHandler(this.BtnMes_Click);
			// 
			// tlpBotonesAlquiler
			// 
			this.tlpBotonesAlquiler.ColumnCount = 3;
			this.tlpBotonesAlquiler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tlpBotonesAlquiler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpBotonesAlquiler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tlpBotonesAlquiler.Controls.Add(this.btnCerrar, 2, 0);
			this.tlpBotonesAlquiler.Controls.Add(this.pnlBotonesAceptar, 0, 0);
			this.tlpBotonesAlquiler.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tlpBotonesAlquiler.Location = new System.Drawing.Point(0, 325);
			this.tlpBotonesAlquiler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tlpBotonesAlquiler.Name = "tlpBotonesAlquiler";
			this.tlpBotonesAlquiler.RowCount = 1;
			this.tlpBotonesAlquiler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpBotonesAlquiler.Size = new System.Drawing.Size(564, 56);
			this.tlpBotonesAlquiler.TabIndex = 2;
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
			this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Abort;
			this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCerrar.FlatAppearance.BorderSize = 0;
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCerrar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnCerrar.Location = new System.Drawing.Point(341, 4);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(219, 48);
			this.btnCerrar.TabIndex = 2;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			// 
			// pnlBotonesAceptar
			// 
			this.pnlBotonesAceptar.Controls.Add(this.btnModificar);
			this.pnlBotonesAceptar.Controls.Add(this.btnAlquilar);
			this.pnlBotonesAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBotonesAceptar.Location = new System.Drawing.Point(3, 3);
			this.pnlBotonesAceptar.Name = "pnlBotonesAceptar";
			this.pnlBotonesAceptar.Size = new System.Drawing.Size(219, 50);
			this.pnlBotonesAceptar.TabIndex = 0;
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
			this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnModificar.FlatAppearance.BorderSize = 0;
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btnModificar.Image = global::tp2.Properties.Resources.pencilblack24;
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificar.Location = new System.Drawing.Point(0, 0);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.btnModificar.Size = new System.Drawing.Size(219, 50);
			this.btnModificar.TabIndex = 1;
			this.btnModificar.Text = "      Modificar Alquiler";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Visible = false;
			// 
			// btnAlquilar
			// 
			this.btnAlquilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
			this.btnAlquilar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAlquilar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAlquilar.FlatAppearance.BorderSize = 0;
			this.btnAlquilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlquilar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnAlquilar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btnAlquilar.Image = global::tp2.Properties.Resources.plusblack24;
			this.btnAlquilar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAlquilar.Location = new System.Drawing.Point(0, 0);
			this.btnAlquilar.Margin = new System.Windows.Forms.Padding(4);
			this.btnAlquilar.Name = "btnAlquilar";
			this.btnAlquilar.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.btnAlquilar.Size = new System.Drawing.Size(219, 50);
			this.btnAlquilar.TabIndex = 0;
			this.btnAlquilar.Text = "      Alquilar";
			this.btnAlquilar.UseVisualStyleBackColor = false;
			this.btnAlquilar.Click += new System.EventHandler(this.BtnAlquilar_Click);
			// 
			// gbPropietario
			// 
			this.gbPropietario.Controls.Add(this.tableLayoutPanel3);
			this.gbPropietario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.gbPropietario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
			this.gbPropietario.Location = new System.Drawing.Point(12, 12);
			this.gbPropietario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbPropietario.Name = "gbPropietario";
			this.gbPropietario.Padding = new System.Windows.Forms.Padding(5, 2, 6, 5);
			this.gbPropietario.Size = new System.Drawing.Size(334, 243);
			this.gbPropietario.TabIndex = 0;
			this.gbPropietario.TabStop = false;
			this.gbPropietario.Text = "CLIENTE REPRESENTANTE";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.lbDNI, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.nudTel, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.tbNombre, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.lbTel, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.tbApellido, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.nudDNI, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.lbNombres, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.lbApellido, 0, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 16);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 4;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(323, 222);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// lbDNI
			// 
			this.lbDNI.AutoSize = true;
			this.lbDNI.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbDNI.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lbDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.lbDNI.Location = new System.Drawing.Point(4, 8);
			this.lbDNI.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.lbDNI.Name = "lbDNI";
			this.lbDNI.Size = new System.Drawing.Size(70, 39);
			this.lbDNI.TabIndex = 21;
			this.lbDNI.Text = "DNI";
			// 
			// nudTel
			// 
			this.nudTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.nudTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudTel.Dock = System.Windows.Forms.DockStyle.Right;
			this.nudTel.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.nudTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.nudTel.Location = new System.Drawing.Point(199, 173);
			this.nudTel.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
			this.nudTel.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.nudTel.Name = "nudTel";
			this.nudTel.Size = new System.Drawing.Size(120, 23);
			this.nudTel.TabIndex = 3;
			this.nudTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbNombre
			// 
			this.tbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbNombre.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.tbNombre.Location = new System.Drawing.Point(82, 118);
			this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
			this.tbNombre.MaxLength = 16;
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(237, 20);
			this.tbNombre.TabIndex = 2;
			// 
			// lbTel
			// 
			this.lbTel.AutoSize = true;
			this.lbTel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbTel.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lbTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.lbTel.Location = new System.Drawing.Point(4, 173);
			this.lbTel.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.lbTel.Name = "lbTel";
			this.lbTel.Size = new System.Drawing.Size(70, 41);
			this.lbTel.TabIndex = 28;
			this.lbTel.Text = "Telefono";
			// 
			// tbApellido
			// 
			this.tbApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.tbApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbApellido.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbApellido.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tbApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.tbApellido.Location = new System.Drawing.Point(82, 63);
			this.tbApellido.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
			this.tbApellido.MaxLength = 16;
			this.tbApellido.Name = "tbApellido";
			this.tbApellido.Size = new System.Drawing.Size(237, 20);
			this.tbApellido.TabIndex = 1;
			// 
			// nudDNI
			// 
			this.nudDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.nudDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudDNI.Dock = System.Windows.Forms.DockStyle.Right;
			this.nudDNI.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.nudDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.nudDNI.Location = new System.Drawing.Point(226, 8);
			this.nudDNI.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
			this.nudDNI.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
			this.nudDNI.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.nudDNI.Name = "nudDNI";
			this.nudDNI.Size = new System.Drawing.Size(93, 23);
			this.nudDNI.TabIndex = 0;
			this.nudDNI.ThousandsSeparator = true;
			this.nudDNI.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			// 
			// lbNombres
			// 
			this.lbNombres.AutoSize = true;
			this.lbNombres.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbNombres.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lbNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.lbNombres.Location = new System.Drawing.Point(4, 118);
			this.lbNombres.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.lbNombres.Name = "lbNombres";
			this.lbNombres.Size = new System.Drawing.Size(70, 39);
			this.lbNombres.TabIndex = 27;
			this.lbNombres.Text = "Nombres";
			// 
			// lbApellido
			// 
			this.lbApellido.AutoSize = true;
			this.lbApellido.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbApellido.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lbApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.lbApellido.Location = new System.Drawing.Point(4, 63);
			this.lbApellido.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.lbApellido.Name = "lbApellido";
			this.lbApellido.Size = new System.Drawing.Size(70, 39);
			this.lbApellido.TabIndex = 26;
			this.lbApellido.Text = "Apellido";
			// 
			// nudCantPasajeros
			// 
			this.nudCantPasajeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.nudCantPasajeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudCantPasajeros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudCantPasajeros.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.nudCantPasajeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.nudCantPasajeros.Location = new System.Drawing.Point(6, 20);
			this.nudCantPasajeros.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudCantPasajeros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudCantPasajeros.Name = "nudCantPasajeros";
			this.nudCantPasajeros.Size = new System.Drawing.Size(149, 23);
			this.nudCantPasajeros.TabIndex = 0;
			this.nudCantPasajeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudCantPasajeros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// pnlControl
			// 
			this.pnlControl.Controls.Add(this.gbPropietario);
			this.pnlControl.Controls.Add(this.tableLayoutPanel1);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlControl.Location = new System.Drawing.Point(206, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Padding = new System.Windows.Forms.Padding(12);
			this.pnlControl.Size = new System.Drawing.Size(358, 325);
			this.pnlControl.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.gbCantPasajeros, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.gbCantDías, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 255);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 58);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// gbCantPasajeros
			// 
			this.gbCantPasajeros.Controls.Add(this.nudCantPasajeros);
			this.gbCantPasajeros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbCantPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.gbCantPasajeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
			this.gbCantPasajeros.Location = new System.Drawing.Point(3, 3);
			this.gbCantPasajeros.Name = "gbCantPasajeros";
			this.gbCantPasajeros.Padding = new System.Windows.Forms.Padding(6, 6, 6, 3);
			this.gbCantPasajeros.Size = new System.Drawing.Size(161, 52);
			this.gbCantPasajeros.TabIndex = 1;
			this.gbCantPasajeros.TabStop = false;
			this.gbCantPasajeros.Text = "PASAJEROS";
			// 
			// gbCantDías
			// 
			this.gbCantDías.Controls.Add(this.nudCantDias);
			this.gbCantDías.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbCantDías.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.gbCantDías.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
			this.gbCantDías.Location = new System.Drawing.Point(170, 3);
			this.gbCantDías.Name = "gbCantDías";
			this.gbCantDías.Padding = new System.Windows.Forms.Padding(6, 6, 6, 3);
			this.gbCantDías.Size = new System.Drawing.Size(161, 52);
			this.gbCantDías.TabIndex = 2;
			this.gbCantDías.TabStop = false;
			this.gbCantDías.Text = "DÍAS DE ALQUILER";
			// 
			// nudCantDias
			// 
			this.nudCantDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.nudCantDias.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudCantDias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudCantDias.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.nudCantDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.nudCantDias.Location = new System.Drawing.Point(6, 20);
			this.nudCantDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudCantDias.Name = "nudCantDias";
			this.nudCantDias.Size = new System.Drawing.Size(149, 23);
			this.nudCantDias.TabIndex = 0;
			this.nudCantDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudCantDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// FAlquiler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
			this.ClientSize = new System.Drawing.Size(564, 381);
			this.Controls.Add(this.pnlControl);
			this.Controls.Add(this.tlpCalendario);
			this.Controls.Add(this.tlpBotonesAlquiler);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.MinimumSize = new System.Drawing.Size(540, 382);
			this.Name = "FAlquiler";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Alquiler";
			this.Load += new System.EventHandler(this.FAlquilar_Load);
			this.tlpCalendario.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCalendario)).EndInit();
			this.tlpBotonesMes.ResumeLayout(false);
			this.tlpBotonesAlquiler.ResumeLayout(false);
			this.pnlBotonesAceptar.ResumeLayout(false);
			this.gbPropietario.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDNI)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantPasajeros)).EndInit();
			this.pnlControl.ResumeLayout(false);
			this.pnlControl.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.gbCantPasajeros.ResumeLayout(false);
			this.gbCantDías.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudCantDias)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.TableLayoutPanel tlpBotonesAlquiler;
		private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbDNI;
        public System.Windows.Forms.NumericUpDown nudTel;
        public System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbTel;
        public System.Windows.Forms.TextBox tbApellido;
        public System.Windows.Forms.NumericUpDown nudDNI;
        private System.Windows.Forms.Label lbNombres;
        private System.Windows.Forms.Label lbApellido;
        public System.Windows.Forms.NumericUpDown nudCantPasajeros;
        public System.Windows.Forms.GroupBox gbPropietario;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnAlquilar;
		private System.Windows.Forms.Panel pnlBotonesAceptar;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.GroupBox gbCantDías;
		public System.Windows.Forms.NumericUpDown nudCantDias;
		private System.Windows.Forms.TableLayoutPanel tlpBotonesMes;
		private System.Windows.Forms.Button btnMes1;
		private System.Windows.Forms.Button btnMes2;
		private System.Windows.Forms.Button btnMes3;
		private System.Windows.Forms.GroupBox gbCantPasajeros;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}