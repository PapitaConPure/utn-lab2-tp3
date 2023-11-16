
namespace tp2 {
	partial class FPrincipal {
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ofdDatos = new System.Windows.Forms.OpenFileDialog();
			this.sfdDatos = new System.Windows.Forms.SaveFileDialog();
			this.dgvResidencias = new System.Windows.Forms.DataGridView();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Servicios = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnlFiltro = new System.Windows.Forms.Panel();
			this.pnlDestinosPasajeros = new System.Windows.Forms.Panel();
			this.tlpDestinosPasajeros = new System.Windows.Forms.TableLayoutPanel();
			this.lbDestino = new System.Windows.Forms.Label();
			this.lbCantPasajeros = new System.Windows.Forms.Label();
			this.cmbDestinos = new System.Windows.Forms.ComboBox();
			this.nudCantPersonas = new System.Windows.Forms.NumericUpDown();
			this.pnlDisponibilidad = new System.Windows.Forms.Panel();
			this.gbFecha = new System.Windows.Forms.GroupBox();
			this.cbFecha = new System.Windows.Forms.CheckBox();
			this.pnlFechas = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dtpSalida = new System.Windows.Forms.DateTimePicker();
			this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pnlPrecio = new System.Windows.Forms.Panel();
			this.gbPrecio = new System.Windows.Forms.GroupBox();
			this.tlpPrecioMinMax = new System.Windows.Forms.TableLayoutPanel();
			this.nudMaxPrice = new System.Windows.Forms.NumericUpDown();
			this.nudMinPrice = new System.Windows.Forms.NumericUpDown();
			this.pbMínPrecio = new System.Windows.Forms.PictureBox();
			this.pbMaxPrecio = new System.Windows.Forms.PictureBox();
			this.tlpFiltroResidencias = new System.Windows.Forms.TableLayoutPanel();
			this.rbCualquiera = new System.Windows.Forms.RadioButton();
			this.rbCasa = new System.Windows.Forms.RadioButton();
			this.rbCasaFinde = new System.Windows.Forms.RadioButton();
			this.rbHotel = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.btnMostrarResidencias = new System.Windows.Forms.Button();
			this.btnLimpiarFiltros = new System.Windows.Forms.Button();
			this.barraMenú = new System.Windows.Forms.MenuStrip();
			this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alquileresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alquileresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.graficarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cantidadPasajaerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.propiedadesReservadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.barraEstado = new System.Windows.Forms.StatusStrip();
			this.pnlResidencias = new System.Windows.Forms.Panel();
			this.tlpBotonesPropiedades = new System.Windows.Forms.TableLayoutPanel();
			this.btnAgregarHotel = new System.Windows.Forms.Button();
			this.btnAgregarCasa = new System.Windows.Forms.Button();
			this.btnBorrarPropiedad = new System.Windows.Forms.Button();
			this.btnModificarPropiedad = new System.Windows.Forms.Button();
			this.btnConsultarPropiedad = new System.Windows.Forms.Button();
			this.pnlBotonesResidencias = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgvResidencias)).BeginInit();
			this.pnlFiltro.SuspendLayout();
			this.pnlDestinosPasajeros.SuspendLayout();
			this.tlpDestinosPasajeros.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).BeginInit();
			this.pnlDisponibilidad.SuspendLayout();
			this.gbFecha.SuspendLayout();
			this.pnlFechas.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.pnlPrecio.SuspendLayout();
			this.gbPrecio.SuspendLayout();
			this.tlpPrecioMinMax.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMínPrecio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMaxPrecio)).BeginInit();
			this.tlpFiltroResidencias.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.barraMenú.SuspendLayout();
			this.pnlResidencias.SuspendLayout();
			this.tlpBotonesPropiedades.SuspendLayout();
			this.pnlBotonesResidencias.SuspendLayout();
			this.SuspendLayout();
			// 
			// ofdDatos
			// 
			this.ofdDatos.DefaultExt = "*.csv";
			this.ofdDatos.FileName = "datos.csv";
			this.ofdDatos.Filter = "Archivos CSV (*.csv)|*.csv";
			this.ofdDatos.InitialDirectory = ".";
			// 
			// sfdDatos
			// 
			this.sfdDatos.DefaultExt = "*.csv";
			this.sfdDatos.FileName = "alquileres.csv";
			this.sfdDatos.Filter = "Archivos CSV (*.csv)|*.csv";
			this.sfdDatos.InitialDirectory = ".";
			// 
			// dgvResidencias
			// 
			this.dgvResidencias.AllowUserToAddRows = false;
			this.dgvResidencias.AllowUserToDeleteRows = false;
			this.dgvResidencias.AllowUserToResizeColumns = false;
			this.dgvResidencias.AllowUserToResizeRows = false;
			this.dgvResidencias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
			this.dgvResidencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvResidencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvResidencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvResidencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvResidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvResidencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Dirección,
            this.Número,
            this.Servicios});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvResidencias.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvResidencias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvResidencias.EnableHeadersVisualStyles = false;
			this.dgvResidencias.Location = new System.Drawing.Point(12, 6);
			this.dgvResidencias.MultiSelect = false;
			this.dgvResidencias.Name = "dgvResidencias";
			this.dgvResidencias.ReadOnly = true;
			this.dgvResidencias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvResidencias.RowHeadersVisible = false;
			this.dgvResidencias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvResidencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvResidencias.Size = new System.Drawing.Size(820, 368);
			this.dgvResidencias.StandardTab = true;
			this.dgvResidencias.TabIndex = 1;
			this.dgvResidencias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResidencias_CellContentDoubleClick);
			// 
			// Tipo
			// 
			this.Tipo.Frozen = true;
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Dirección
			// 
			this.Dirección.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Dirección.FillWeight = 50F;
			this.Dirección.HeaderText = "Dirección";
			this.Dirección.Name = "Dirección";
			this.Dirección.ReadOnly = true;
			this.Dirección.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Dirección.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Número
			// 
			this.Número.HeaderText = "Número";
			this.Número.Name = "Número";
			this.Número.ReadOnly = true;
			this.Número.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Número.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Servicios
			// 
			this.Servicios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Servicios.FillWeight = 50F;
			this.Servicios.HeaderText = "Servicios";
			this.Servicios.Name = "Servicios";
			this.Servicios.ReadOnly = true;
			// 
			// pnlFiltro
			// 
			this.pnlFiltro.Controls.Add(this.pnlDestinosPasajeros);
			this.pnlFiltro.Controls.Add(this.pnlDisponibilidad);
			this.pnlFiltro.Controls.Add(this.pnlPrecio);
			this.pnlFiltro.Controls.Add(this.tlpFiltroResidencias);
			this.pnlFiltro.Controls.Add(this.tableLayoutPanel5);
			this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.pnlFiltro.Location = new System.Drawing.Point(0, 24);
			this.pnlFiltro.Name = "pnlFiltro";
			this.pnlFiltro.Padding = new System.Windows.Forms.Padding(6);
			this.pnlFiltro.Size = new System.Drawing.Size(844, 124);
			this.pnlFiltro.TabIndex = 1;
			// 
			// pnlDestinosPasajeros
			// 
			this.pnlDestinosPasajeros.Controls.Add(this.tlpDestinosPasajeros);
			this.pnlDestinosPasajeros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDestinosPasajeros.Location = new System.Drawing.Point(423, 6);
			this.pnlDestinosPasajeros.Name = "pnlDestinosPasajeros";
			this.pnlDestinosPasajeros.Padding = new System.Windows.Forms.Padding(2, 8, 10, 0);
			this.pnlDestinosPasajeros.Size = new System.Drawing.Size(303, 112);
			this.pnlDestinosPasajeros.TabIndex = 3;
			// 
			// tlpDestinosPasajeros
			// 
			this.tlpDestinosPasajeros.ColumnCount = 2;
			this.tlpDestinosPasajeros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
			this.tlpDestinosPasajeros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpDestinosPasajeros.Controls.Add(this.lbDestino, 0, 0);
			this.tlpDestinosPasajeros.Controls.Add(this.lbCantPasajeros, 0, 1);
			this.tlpDestinosPasajeros.Controls.Add(this.cmbDestinos, 1, 0);
			this.tlpDestinosPasajeros.Controls.Add(this.nudCantPersonas, 1, 1);
			this.tlpDestinosPasajeros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpDestinosPasajeros.Location = new System.Drawing.Point(2, 8);
			this.tlpDestinosPasajeros.Name = "tlpDestinosPasajeros";
			this.tlpDestinosPasajeros.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
			this.tlpDestinosPasajeros.RowCount = 2;
			this.tlpDestinosPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpDestinosPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpDestinosPasajeros.Size = new System.Drawing.Size(291, 104);
			this.tlpDestinosPasajeros.TabIndex = 0;
			// 
			// lbDestino
			// 
			this.lbDestino.AutoSize = true;
			this.lbDestino.Location = new System.Drawing.Point(3, 12);
			this.lbDestino.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
			this.lbDestino.Name = "lbDestino";
			this.lbDestino.Size = new System.Drawing.Size(66, 20);
			this.lbDestino.TabIndex = 12;
			this.lbDestino.Text = "Destinos";
			// 
			// lbCantPasajeros
			// 
			this.lbCantPasajeros.AutoSize = true;
			this.lbCantPasajeros.Location = new System.Drawing.Point(3, 64);
			this.lbCantPasajeros.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
			this.lbCantPasajeros.Name = "lbCantPasajeros";
			this.lbCantPasajeros.Size = new System.Drawing.Size(70, 20);
			this.lbCantPasajeros.TabIndex = 18;
			this.lbCantPasajeros.Text = "Pasajeros";
			// 
			// cmbDestinos
			// 
			this.cmbDestinos.BackColor = System.Drawing.SystemColors.Window;
			this.cmbDestinos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbDestinos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDestinos.FormattingEnabled = true;
			this.cmbDestinos.Location = new System.Drawing.Point(79, 9);
			this.cmbDestinos.Name = "cmbDestinos";
			this.cmbDestinos.Size = new System.Drawing.Size(209, 28);
			this.cmbDestinos.TabIndex = 0;
			// 
			// nudCantPersonas
			// 
			this.nudCantPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.nudCantPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudCantPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudCantPersonas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.nudCantPersonas.Location = new System.Drawing.Point(79, 64);
			this.nudCantPersonas.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
			this.nudCantPersonas.Name = "nudCantPersonas";
			this.nudCantPersonas.Size = new System.Drawing.Size(209, 23);
			this.nudCantPersonas.TabIndex = 1;
			this.nudCantPersonas.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
			this.nudCantPersonas.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
			// 
			// pnlDisponibilidad
			// 
			this.pnlDisponibilidad.Controls.Add(this.gbFecha);
			this.pnlDisponibilidad.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlDisponibilidad.Location = new System.Drawing.Point(259, 6);
			this.pnlDisponibilidad.Name = "pnlDisponibilidad";
			this.pnlDisponibilidad.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.pnlDisponibilidad.Size = new System.Drawing.Size(164, 112);
			this.pnlDisponibilidad.TabIndex = 2;
			// 
			// gbFecha
			// 
			this.gbFecha.Controls.Add(this.cbFecha);
			this.gbFecha.Controls.Add(this.pnlFechas);
			this.gbFecha.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.gbFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
			this.gbFecha.Location = new System.Drawing.Point(9, 0);
			this.gbFecha.Name = "gbFecha";
			this.gbFecha.Size = new System.Drawing.Size(146, 112);
			this.gbFecha.TabIndex = 0;
			this.gbFecha.TabStop = false;
			this.gbFecha.Text = "DISPONIBILIDAD";
			// 
			// cbFecha
			// 
			this.cbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbFecha.AutoSize = true;
			this.cbFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(43)))), ((int)(((byte)(101)))));
			this.cbFecha.Location = new System.Drawing.Point(127, 4);
			this.cbFecha.Name = "cbFecha";
			this.cbFecha.Size = new System.Drawing.Size(15, 14);
			this.cbFecha.TabIndex = 2;
			this.cbFecha.UseVisualStyleBackColor = true;
			this.cbFecha.CheckedChanged += new System.EventHandler(this.CbFecha_CheckedChanged);
			// 
			// pnlFechas
			// 
			this.pnlFechas.Controls.Add(this.tableLayoutPanel1);
			this.pnlFechas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlFechas.Enabled = false;
			this.pnlFechas.Location = new System.Drawing.Point(3, 17);
			this.pnlFechas.Margin = new System.Windows.Forms.Padding(0);
			this.pnlFechas.Name = "pnlFechas";
			this.pnlFechas.Size = new System.Drawing.Size(140, 92);
			this.pnlFechas.TabIndex = 4;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.dtpSalida, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.dtpIngreso, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(140, 92);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// dtpSalida
			// 
			this.dtpSalida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpSalida.Location = new System.Drawing.Point(38, 54);
			this.dtpSalida.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.dtpSalida.Name = "dtpSalida";
			this.dtpSalida.Size = new System.Drawing.Size(99, 27);
			this.dtpSalida.TabIndex = 1;
			// 
			// dtpIngreso
			// 
			this.dtpIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpIngreso.Location = new System.Drawing.Point(38, 8);
			this.dtpIngreso.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.dtpIngreso.Name = "dtpIngreso";
			this.dtpIngreso.Size = new System.Drawing.Size(99, 27);
			this.dtpIngreso.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::tp2.Properties.Resources.bracketopenaccent24;
			this.pictureBox1.Location = new System.Drawing.Point(3, 7);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(29, 29);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::tp2.Properties.Resources.bracketcloseaccent24;
			this.pictureBox2.Location = new System.Drawing.Point(3, 53);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(29, 29);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pnlPrecio
			// 
			this.pnlPrecio.Controls.Add(this.gbPrecio);
			this.pnlPrecio.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlPrecio.Location = new System.Drawing.Point(113, 6);
			this.pnlPrecio.Name = "pnlPrecio";
			this.pnlPrecio.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.pnlPrecio.Size = new System.Drawing.Size(146, 112);
			this.pnlPrecio.TabIndex = 1;
			// 
			// gbPrecio
			// 
			this.gbPrecio.Controls.Add(this.tlpPrecioMinMax);
			this.gbPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.gbPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
			this.gbPrecio.Location = new System.Drawing.Point(9, 0);
			this.gbPrecio.Name = "gbPrecio";
			this.gbPrecio.Size = new System.Drawing.Size(128, 112);
			this.gbPrecio.TabIndex = 0;
			this.gbPrecio.TabStop = false;
			this.gbPrecio.Text = "PRECIO";
			// 
			// tlpPrecioMinMax
			// 
			this.tlpPrecioMinMax.ColumnCount = 2;
			this.tlpPrecioMinMax.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpPrecioMinMax.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpPrecioMinMax.Controls.Add(this.nudMaxPrice, 1, 1);
			this.tlpPrecioMinMax.Controls.Add(this.nudMinPrice, 1, 0);
			this.tlpPrecioMinMax.Controls.Add(this.pbMínPrecio, 0, 0);
			this.tlpPrecioMinMax.Controls.Add(this.pbMaxPrecio, 0, 1);
			this.tlpPrecioMinMax.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpPrecioMinMax.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tlpPrecioMinMax.Location = new System.Drawing.Point(3, 17);
			this.tlpPrecioMinMax.Name = "tlpPrecioMinMax";
			this.tlpPrecioMinMax.RowCount = 2;
			this.tlpPrecioMinMax.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpPrecioMinMax.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpPrecioMinMax.Size = new System.Drawing.Size(122, 92);
			this.tlpPrecioMinMax.TabIndex = 0;
			// 
			// nudMaxPrice
			// 
			this.nudMaxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.nudMaxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudMaxPrice.DecimalPlaces = 2;
			this.nudMaxPrice.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudMaxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.nudMaxPrice.Location = new System.Drawing.Point(38, 55);
			this.nudMaxPrice.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.nudMaxPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.nudMaxPrice.Name = "nudMaxPrice";
			this.nudMaxPrice.Size = new System.Drawing.Size(81, 23);
			this.nudMaxPrice.TabIndex = 1;
			this.nudMaxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nudMaxPrice.ThousandsSeparator = true;
			this.nudMaxPrice.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
			this.nudMaxPrice.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
			// 
			// nudMinPrice
			// 
			this.nudMinPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.nudMinPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudMinPrice.DecimalPlaces = 2;
			this.nudMinPrice.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudMinPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.nudMinPrice.Location = new System.Drawing.Point(38, 9);
			this.nudMinPrice.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.nudMinPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.nudMinPrice.Name = "nudMinPrice";
			this.nudMinPrice.Size = new System.Drawing.Size(81, 23);
			this.nudMinPrice.TabIndex = 0;
			this.nudMinPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nudMinPrice.ThousandsSeparator = true;
			this.nudMinPrice.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
			this.nudMinPrice.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
			// 
			// pbMínPrecio
			// 
			this.pbMínPrecio.Image = global::tp2.Properties.Resources.bracketopenaccent24;
			this.pbMínPrecio.Location = new System.Drawing.Point(3, 7);
			this.pbMínPrecio.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
			this.pbMínPrecio.Name = "pbMínPrecio";
			this.pbMínPrecio.Size = new System.Drawing.Size(29, 29);
			this.pbMínPrecio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbMínPrecio.TabIndex = 2;
			this.pbMínPrecio.TabStop = false;
			// 
			// pbMaxPrecio
			// 
			this.pbMaxPrecio.Image = global::tp2.Properties.Resources.bracketcloseaccent24;
			this.pbMaxPrecio.Location = new System.Drawing.Point(3, 53);
			this.pbMaxPrecio.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
			this.pbMaxPrecio.Name = "pbMaxPrecio";
			this.pbMaxPrecio.Size = new System.Drawing.Size(29, 29);
			this.pbMaxPrecio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbMaxPrecio.TabIndex = 2;
			this.pbMaxPrecio.TabStop = false;
			// 
			// tlpFiltroResidencias
			// 
			this.tlpFiltroResidencias.ColumnCount = 1;
			this.tlpFiltroResidencias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpFiltroResidencias.Controls.Add(this.rbCualquiera, 0, 0);
			this.tlpFiltroResidencias.Controls.Add(this.rbCasa, 0, 1);
			this.tlpFiltroResidencias.Controls.Add(this.rbCasaFinde, 0, 2);
			this.tlpFiltroResidencias.Controls.Add(this.rbHotel, 0, 3);
			this.tlpFiltroResidencias.Dock = System.Windows.Forms.DockStyle.Left;
			this.tlpFiltroResidencias.Location = new System.Drawing.Point(6, 6);
			this.tlpFiltroResidencias.Name = "tlpFiltroResidencias";
			this.tlpFiltroResidencias.RowCount = 4;
			this.tlpFiltroResidencias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpFiltroResidencias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpFiltroResidencias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpFiltroResidencias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpFiltroResidencias.Size = new System.Drawing.Size(107, 112);
			this.tlpFiltroResidencias.TabIndex = 0;
			// 
			// rbCualquiera
			// 
			this.rbCualquiera.AutoSize = true;
			this.rbCualquiera.Checked = true;
			this.rbCualquiera.Location = new System.Drawing.Point(6, 1);
			this.rbCualquiera.Margin = new System.Windows.Forms.Padding(6, 1, 3, 1);
			this.rbCualquiera.Name = "rbCualquiera";
			this.rbCualquiera.Size = new System.Drawing.Size(98, 24);
			this.rbCualquiera.TabIndex = 0;
			this.rbCualquiera.TabStop = true;
			this.rbCualquiera.Text = "Cualquiera";
			this.rbCualquiera.UseVisualStyleBackColor = true;
			// 
			// rbCasa
			// 
			this.rbCasa.AutoSize = true;
			this.rbCasa.Location = new System.Drawing.Point(6, 31);
			this.rbCasa.Margin = new System.Windows.Forms.Padding(6, 1, 3, 1);
			this.rbCasa.Name = "rbCasa";
			this.rbCasa.Size = new System.Drawing.Size(58, 24);
			this.rbCasa.TabIndex = 1;
			this.rbCasa.Text = "Casa";
			this.rbCasa.UseVisualStyleBackColor = true;
			// 
			// rbCasaFinde
			// 
			this.rbCasaFinde.AutoSize = true;
			this.rbCasaFinde.Location = new System.Drawing.Point(6, 61);
			this.rbCasaFinde.Margin = new System.Windows.Forms.Padding(6, 1, 3, 1);
			this.rbCasaFinde.Name = "rbCasaFinde";
			this.rbCasaFinde.Size = new System.Drawing.Size(94, 24);
			this.rbCasaFinde.TabIndex = 2;
			this.rbCasaFinde.Text = "CasaFinde";
			this.rbCasaFinde.UseVisualStyleBackColor = true;
			// 
			// rbHotel
			// 
			this.rbHotel.AutoSize = true;
			this.rbHotel.Location = new System.Drawing.Point(6, 91);
			this.rbHotel.Margin = new System.Windows.Forms.Padding(6, 1, 3, 1);
			this.rbHotel.Name = "rbHotel";
			this.rbHotel.Size = new System.Drawing.Size(64, 20);
			this.rbHotel.TabIndex = 3;
			this.rbHotel.Text = "Hotel";
			this.rbHotel.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 1;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Controls.Add(this.btnMostrarResidencias, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.btnLimpiarFiltros, 0, 1);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(726, 6);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 2;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(112, 112);
			this.tableLayoutPanel5.TabIndex = 4;
			// 
			// btnMostrarResidencias
			// 
			this.btnMostrarResidencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
			this.btnMostrarResidencias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnMostrarResidencias.FlatAppearance.BorderSize = 0;
			this.btnMostrarResidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMostrarResidencias.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnMostrarResidencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btnMostrarResidencias.Location = new System.Drawing.Point(6, 6);
			this.btnMostrarResidencias.Margin = new System.Windows.Forms.Padding(6, 6, 6, 3);
			this.btnMostrarResidencias.Name = "btnMostrarResidencias";
			this.btnMostrarResidencias.Size = new System.Drawing.Size(100, 47);
			this.btnMostrarResidencias.TabIndex = 0;
			this.btnMostrarResidencias.Text = "&Buscar";
			this.btnMostrarResidencias.UseVisualStyleBackColor = false;
			this.btnMostrarResidencias.Click += new System.EventHandler(this.BtnBuscarResidencias_Click);
			// 
			// btnLimpiarFiltros
			// 
			this.btnLimpiarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
			this.btnLimpiarFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
			this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnLimpiarFiltros.Location = new System.Drawing.Point(6, 59);
			this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(6, 3, 6, 6);
			this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
			this.btnLimpiarFiltros.Size = new System.Drawing.Size(100, 47);
			this.btnLimpiarFiltros.TabIndex = 1;
			this.btnLimpiarFiltros.Text = "Limpiar";
			this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
			this.btnLimpiarFiltros.Click += new System.EventHandler(this.BtnLimpiarFiltros_Click);
			// 
			// barraMenú
			// 
			this.barraMenú.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.barraMenú.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.barraMenú.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.graficarToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
			this.barraMenú.Location = new System.Drawing.Point(0, 0);
			this.barraMenú.Name = "barraMenú";
			this.barraMenú.Size = new System.Drawing.Size(844, 24);
			this.barraMenú.TabIndex = 4;
			this.barraMenú.Text = "menuStrip";
			// 
			// inicioToolStripMenuItem
			// 
			this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.importarToolStripMenuItem,
            this.exportarToolStripMenuItem});
			this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.inicioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(211)))));
			this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
			this.inicioToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.inicioToolStripMenuItem.Text = "&ARCHIVO";
			// 
			// guardarToolStripMenuItem
			// 
			this.guardarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
			this.guardarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.guardarToolStripMenuItem.Text = "&Guardar Todo Como...";
			this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
			// 
			// importarToolStripMenuItem
			// 
			this.importarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alquileresToolStripMenuItem});
			this.importarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
			this.importarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.importarToolStripMenuItem.Text = "&Importar...";
			// 
			// alquileresToolStripMenuItem
			// 
			this.alquileresToolStripMenuItem.Name = "alquileresToolStripMenuItem";
			this.alquileresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.alquileresToolStripMenuItem.Text = "&Alquileres";
			this.alquileresToolStripMenuItem.Click += new System.EventHandler(this.ImportarAlquileresToolStripMenuItem_Click);
			// 
			// exportarToolStripMenuItem
			// 
			this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alquileresToolStripMenuItem1});
			this.exportarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
			this.exportarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.exportarToolStripMenuItem.Text = "&Exportar...";
			// 
			// alquileresToolStripMenuItem1
			// 
			this.alquileresToolStripMenuItem1.Name = "alquileresToolStripMenuItem1";
			this.alquileresToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.alquileresToolStripMenuItem1.Text = "Alquileres";
			this.alquileresToolStripMenuItem1.Click += new System.EventHandler(this.ExportarAlquileresToolStripMenuItem_Click);
			// 
			// graficarToolStripMenuItem
			// 
			this.graficarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadPasajaerosToolStripMenuItem,
            this.propiedadesReservadasToolStripMenuItem});
			this.graficarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.graficarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(211)))));
			this.graficarToolStripMenuItem.Name = "graficarToolStripMenuItem";
			this.graficarToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
			this.graficarToolStripMenuItem.Text = "&GRAFICAR";
			// 
			// cantidadPasajaerosToolStripMenuItem
			// 
			this.cantidadPasajaerosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.cantidadPasajaerosToolStripMenuItem.Name = "cantidadPasajaerosToolStripMenuItem";
			this.cantidadPasajaerosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.cantidadPasajaerosToolStripMenuItem.Text = "&Cantidad de Pasajeros";
			this.cantidadPasajaerosToolStripMenuItem.Click += new System.EventHandler(this.CantidadPasajaerosToolStripMenuItem_Click);
			// 
			// propiedadesReservadasToolStripMenuItem
			// 
			this.propiedadesReservadasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.propiedadesReservadasToolStripMenuItem.Name = "propiedadesReservadasToolStripMenuItem";
			this.propiedadesReservadasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.propiedadesReservadasToolStripMenuItem.Text = "Propiedades &Reservadas";
			this.propiedadesReservadasToolStripMenuItem.Click += new System.EventHandler(this.PropiedadesReservadasToolStripMenuItem_Click);
			// 
			// usuarioToolStripMenuItem
			// 
			this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem});
			this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.usuarioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(211)))));
			this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
			this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.usuarioToolStripMenuItem.Text = "&USUARIO";
			// 
			// agregarUsuarioToolStripMenuItem
			// 
			this.agregarUsuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
			this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.agregarUsuarioToolStripMenuItem.Text = "&Agregar";
			this.agregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.AgregarUsuarioToolStripMenuItem_Click);
			// 
			// eliminarUsuarioToolStripMenuItem
			// 
			this.eliminarUsuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
			this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.eliminarUsuarioToolStripMenuItem.Text = "&Eliminar";
			this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.EliminarUsuarioToolStripMenuItem_Click);
			// 
			// cambiarContraseñaToolStripMenuItem
			// 
			this.cambiarContraseñaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
			this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.cambiarContraseñaToolStripMenuItem.Text = "&Contraseña...";
			this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.CambiarContraseñaToolStripMenuItem_Click);
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(211)))));
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.ayudaToolStripMenuItem.Text = "A&YUDA";
			this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.AyudaToolStripMenuItem_Click);
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(182)))));
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.acercaDeToolStripMenuItem.Text = "AC&ERCA DE...";
			this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
			// 
			// barraEstado
			// 
			this.barraEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.barraEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.barraEstado.Location = new System.Drawing.Point(0, 579);
			this.barraEstado.Name = "barraEstado";
			this.barraEstado.Size = new System.Drawing.Size(844, 22);
			this.barraEstado.TabIndex = 5;
			// 
			// pnlResidencias
			// 
			this.pnlResidencias.Controls.Add(this.dgvResidencias);
			this.pnlResidencias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlResidencias.Location = new System.Drawing.Point(0, 148);
			this.pnlResidencias.Name = "pnlResidencias";
			this.pnlResidencias.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
			this.pnlResidencias.Size = new System.Drawing.Size(844, 380);
			this.pnlResidencias.TabIndex = 23;
			// 
			// tlpBotonesPropiedades
			// 
			this.tlpBotonesPropiedades.ColumnCount = 5;
			this.tlpBotonesPropiedades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpBotonesPropiedades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpBotonesPropiedades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpBotonesPropiedades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpBotonesPropiedades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpBotonesPropiedades.Controls.Add(this.btnAgregarHotel, 1, 0);
			this.tlpBotonesPropiedades.Controls.Add(this.btnAgregarCasa, 0, 0);
			this.tlpBotonesPropiedades.Controls.Add(this.btnBorrarPropiedad, 4, 0);
			this.tlpBotonesPropiedades.Controls.Add(this.btnModificarPropiedad, 3, 0);
			this.tlpBotonesPropiedades.Controls.Add(this.btnConsultarPropiedad, 2, 0);
			this.tlpBotonesPropiedades.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpBotonesPropiedades.Location = new System.Drawing.Point(6, 3);
			this.tlpBotonesPropiedades.Name = "tlpBotonesPropiedades";
			this.tlpBotonesPropiedades.RowCount = 1;
			this.tlpBotonesPropiedades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpBotonesPropiedades.Size = new System.Drawing.Size(832, 45);
			this.tlpBotonesPropiedades.TabIndex = 22;
			// 
			// btnAgregarHotel
			// 
			this.btnAgregarHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
			this.btnAgregarHotel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAgregarHotel.FlatAppearance.BorderSize = 0;
			this.btnAgregarHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregarHotel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnAgregarHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btnAgregarHotel.Image = global::tp2.Properties.Resources.plusblack24;
			this.btnAgregarHotel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregarHotel.Location = new System.Drawing.Point(172, 0);
			this.btnAgregarHotel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
			this.btnAgregarHotel.Name = "btnAgregarHotel";
			this.btnAgregarHotel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.btnAgregarHotel.Size = new System.Drawing.Size(154, 39);
			this.btnAgregarHotel.TabIndex = 1;
			this.btnAgregarHotel.Text = "      &Hotel";
			this.btnAgregarHotel.UseVisualStyleBackColor = false;
			this.btnAgregarHotel.Click += new System.EventHandler(this.BtnAgregarHotel_Click);
			// 
			// btnAgregarCasa
			// 
			this.btnAgregarCasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
			this.btnAgregarCasa.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAgregarCasa.FlatAppearance.BorderSize = 0;
			this.btnAgregarCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregarCasa.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnAgregarCasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btnAgregarCasa.Image = global::tp2.Properties.Resources.plusblack24;
			this.btnAgregarCasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregarCasa.Location = new System.Drawing.Point(6, 0);
			this.btnAgregarCasa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
			this.btnAgregarCasa.Name = "btnAgregarCasa";
			this.btnAgregarCasa.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.btnAgregarCasa.Size = new System.Drawing.Size(154, 39);
			this.btnAgregarCasa.TabIndex = 0;
			this.btnAgregarCasa.Text = "      &Casa";
			this.btnAgregarCasa.UseVisualStyleBackColor = false;
			this.btnAgregarCasa.Click += new System.EventHandler(this.BtnAgregarCasa_Click);
			// 
			// btnBorrarPropiedad
			// 
			this.btnBorrarPropiedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
			this.btnBorrarPropiedad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnBorrarPropiedad.FlatAppearance.BorderSize = 0;
			this.btnBorrarPropiedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBorrarPropiedad.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnBorrarPropiedad.ForeColor = System.Drawing.Color.White;
			this.btnBorrarPropiedad.Image = global::tp2.Properties.Resources.xwhite24;
			this.btnBorrarPropiedad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBorrarPropiedad.Location = new System.Drawing.Point(670, 0);
			this.btnBorrarPropiedad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
			this.btnBorrarPropiedad.Name = "btnBorrarPropiedad";
			this.btnBorrarPropiedad.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.btnBorrarPropiedad.Size = new System.Drawing.Size(156, 39);
			this.btnBorrarPropiedad.TabIndex = 4;
			this.btnBorrarPropiedad.Text = "      Eliminar";
			this.btnBorrarPropiedad.UseVisualStyleBackColor = false;
			this.btnBorrarPropiedad.Click += new System.EventHandler(this.BtnBorrarPropiedad_Click);
			// 
			// btnModificarPropiedad
			// 
			this.btnModificarPropiedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
			this.btnModificarPropiedad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnModificarPropiedad.FlatAppearance.BorderSize = 0;
			this.btnModificarPropiedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificarPropiedad.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnModificarPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnModificarPropiedad.Image = global::tp2.Properties.Resources.pencilwhite24;
			this.btnModificarPropiedad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificarPropiedad.Location = new System.Drawing.Point(504, 0);
			this.btnModificarPropiedad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
			this.btnModificarPropiedad.Name = "btnModificarPropiedad";
			this.btnModificarPropiedad.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.btnModificarPropiedad.Size = new System.Drawing.Size(154, 39);
			this.btnModificarPropiedad.TabIndex = 3;
			this.btnModificarPropiedad.Text = "      Modificar";
			this.btnModificarPropiedad.UseVisualStyleBackColor = false;
			this.btnModificarPropiedad.Click += new System.EventHandler(this.BtnModificarPropiedad_Click);
			// 
			// btnConsultarPropiedad
			// 
			this.btnConsultarPropiedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
			this.btnConsultarPropiedad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnConsultarPropiedad.FlatAppearance.BorderSize = 0;
			this.btnConsultarPropiedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultarPropiedad.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnConsultarPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnConsultarPropiedad.Image = global::tp2.Properties.Resources.eyewhite24;
			this.btnConsultarPropiedad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConsultarPropiedad.Location = new System.Drawing.Point(338, 0);
			this.btnConsultarPropiedad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
			this.btnConsultarPropiedad.Name = "btnConsultarPropiedad";
			this.btnConsultarPropiedad.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.btnConsultarPropiedad.Size = new System.Drawing.Size(154, 39);
			this.btnConsultarPropiedad.TabIndex = 2;
			this.btnConsultarPropiedad.Text = "      Consultar";
			this.btnConsultarPropiedad.UseVisualStyleBackColor = false;
			this.btnConsultarPropiedad.Click += new System.EventHandler(this.BtnConsultarPropiedad_Click);
			// 
			// pnlBotonesResidencias
			// 
			this.pnlBotonesResidencias.Controls.Add(this.tlpBotonesPropiedades);
			this.pnlBotonesResidencias.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBotonesResidencias.Location = new System.Drawing.Point(0, 528);
			this.pnlBotonesResidencias.Name = "pnlBotonesResidencias";
			this.pnlBotonesResidencias.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
			this.pnlBotonesResidencias.Size = new System.Drawing.Size(844, 51);
			this.pnlBotonesResidencias.TabIndex = 0;
			// 
			// FPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
			this.ClientSize = new System.Drawing.Size(844, 601);
			this.Controls.Add(this.pnlResidencias);
			this.Controls.Add(this.pnlBotonesResidencias);
			this.Controls.Add(this.pnlFiltro);
			this.Controls.Add(this.barraEstado);
			this.Controls.Add(this.barraMenú);
			this.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(826, 480);
			this.Name = "FPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Empresa de Alquileres";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FPrincipal_FormClosed);
			this.Load += new System.EventHandler(this.FPrincipal_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvResidencias)).EndInit();
			this.pnlFiltro.ResumeLayout(false);
			this.pnlDestinosPasajeros.ResumeLayout(false);
			this.tlpDestinosPasajeros.ResumeLayout(false);
			this.tlpDestinosPasajeros.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).EndInit();
			this.pnlDisponibilidad.ResumeLayout(false);
			this.gbFecha.ResumeLayout(false);
			this.gbFecha.PerformLayout();
			this.pnlFechas.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.pnlPrecio.ResumeLayout(false);
			this.gbPrecio.ResumeLayout(false);
			this.tlpPrecioMinMax.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMínPrecio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMaxPrecio)).EndInit();
			this.tlpFiltroResidencias.ResumeLayout(false);
			this.tlpFiltroResidencias.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.barraMenú.ResumeLayout(false);
			this.barraMenú.PerformLayout();
			this.pnlResidencias.ResumeLayout(false);
			this.tlpBotonesPropiedades.ResumeLayout(false);
			this.pnlBotonesResidencias.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.Button btnAgregarCasa;
        private System.Windows.Forms.Button btnAgregarHotel;
		private System.Windows.Forms.OpenFileDialog ofdDatos;
		private System.Windows.Forms.SaveFileDialog sfdDatos;
        private System.Windows.Forms.Button btnMostrarResidencias;
        private System.Windows.Forms.RadioButton rbCasaFinde;
        private System.Windows.Forms.RadioButton rbCasa;
        private System.Windows.Forms.NumericUpDown nudMinPrice;
        private System.Windows.Forms.NumericUpDown nudMaxPrice;
        private System.Windows.Forms.Button btnLimpiarFiltros;
		private System.Windows.Forms.Panel pnlFiltro;
		private System.Windows.Forms.TableLayoutPanel tlpFiltroResidencias;
		private System.Windows.Forms.GroupBox gbPrecio;
		private System.Windows.Forms.TableLayoutPanel tlpPrecioMinMax;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.MenuStrip barraMenú;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbFecha;
        public System.Windows.Forms.DateTimePicker dtpSalida;
        public System.Windows.Forms.DateTimePicker dtpIngreso;
        public System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.ToolStripMenuItem graficarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadPasajaerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadesReservadasToolStripMenuItem;
		private System.Windows.Forms.Panel pnlFechas;
        public System.Windows.Forms.StatusStrip barraEstado;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
		private System.Windows.Forms.DataGridView dgvResidencias;
		private System.Windows.Forms.Panel pnlDestinosPasajeros;
		private System.Windows.Forms.TableLayoutPanel tlpDestinosPasajeros;
		private System.Windows.Forms.Label lbDestino;
		private System.Windows.Forms.Label lbCantPasajeros;
		private System.Windows.Forms.ComboBox cmbDestinos;
		private System.Windows.Forms.NumericUpDown nudCantPersonas;
		private System.Windows.Forms.Panel pnlDisponibilidad;
		private System.Windows.Forms.Panel pnlPrecio;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel pnlResidencias;
		private System.Windows.Forms.TableLayoutPanel tlpBotonesPropiedades;
		private System.Windows.Forms.Button btnBorrarPropiedad;
		private System.Windows.Forms.Button btnModificarPropiedad;
		private System.Windows.Forms.Button btnConsultarPropiedad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
		private System.Windows.Forms.DataGridViewTextBoxColumn Número;
		private System.Windows.Forms.DataGridViewTextBoxColumn Servicios;
		private System.Windows.Forms.RadioButton rbHotel;
		private System.Windows.Forms.RadioButton rbCualquiera;
		private System.Windows.Forms.Panel pnlBotonesResidencias;
		private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alquileresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alquileresToolStripMenuItem1;
		private System.Windows.Forms.PictureBox pbMínPrecio;
		private System.Windows.Forms.PictureBox pbMaxPrecio;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

