
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
			this.gpFecha = new System.Windows.Forms.GroupBox();
			this.cbFecha = new System.Windows.Forms.CheckBox();
			this.pnlFechas = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dtpSalida = new System.Windows.Forms.DateTimePicker();
			this.lbIngreso = new System.Windows.Forms.Label();
			this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
			this.lbSalida = new System.Windows.Forms.Label();
			this.pnlPrecio = new System.Windows.Forms.Panel();
			this.gbPrecio = new System.Windows.Forms.GroupBox();
			this.tlpPrecioMinMax = new System.Windows.Forms.TableLayoutPanel();
			this.nudMaxPrice = new System.Windows.Forms.NumericUpDown();
			this.nudMinPrice = new System.Windows.Forms.NumericUpDown();
			this.lbMin = new System.Windows.Forms.Label();
			this.lbMax = new System.Windows.Forms.Label();
			this.tlpFiltroResidencias = new System.Windows.Forms.TableLayoutPanel();
			this.rbCualquiera = new System.Windows.Forms.RadioButton();
			this.rbCasa = new System.Windows.Forms.RadioButton();
			this.rbCasaFinde = new System.Windows.Forms.RadioButton();
			this.rbHotel = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.btnMostrarResidencias = new System.Windows.Forms.Button();
			this.btnLimpiarFiltros = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
			this.pnlBotonesResidencias = new System.Windows.Forms.Panel();
			this.btnAgregarHotel = new System.Windows.Forms.Button();
			this.btnAgregarCasa = new System.Windows.Forms.Button();
			this.btnBorrarPropiedad = new System.Windows.Forms.Button();
			this.btnModificarPropiedad = new System.Windows.Forms.Button();
			this.btnConsultarPropiedad = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvResidencias)).BeginInit();
			this.pnlFiltro.SuspendLayout();
			this.pnlDestinosPasajeros.SuspendLayout();
			this.tlpDestinosPasajeros.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).BeginInit();
			this.pnlDisponibilidad.SuspendLayout();
			this.gpFecha.SuspendLayout();
			this.pnlFechas.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.pnlPrecio.SuspendLayout();
			this.gbPrecio.SuspendLayout();
			this.tlpPrecioMinMax.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).BeginInit();
			this.tlpFiltroResidencias.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.menuStrip1.SuspendLayout();
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
			this.dgvResidencias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.dgvResidencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvResidencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvResidencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
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
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
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
			this.dgvResidencias.Size = new System.Drawing.Size(820, 390);
			this.dgvResidencias.StandardTab = true;
			this.dgvResidencias.TabIndex = 1;
			this.dgvResidencias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResidencias_CellContentDoubleClick);
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
			this.pnlFiltro.Size = new System.Drawing.Size(844, 102);
			this.pnlFiltro.TabIndex = 1;
			// 
			// pnlDestinosPasajeros
			// 
			this.pnlDestinosPasajeros.Controls.Add(this.tlpDestinosPasajeros);
			this.pnlDestinosPasajeros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDestinosPasajeros.Location = new System.Drawing.Point(419, 6);
			this.pnlDestinosPasajeros.Name = "pnlDestinosPasajeros";
			this.pnlDestinosPasajeros.Padding = new System.Windows.Forms.Padding(0, 8, 4, 0);
			this.pnlDestinosPasajeros.Size = new System.Drawing.Size(307, 90);
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
			this.tlpDestinosPasajeros.Location = new System.Drawing.Point(0, 8);
			this.tlpDestinosPasajeros.Name = "tlpDestinosPasajeros";
			this.tlpDestinosPasajeros.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
			this.tlpDestinosPasajeros.RowCount = 2;
			this.tlpDestinosPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpDestinosPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpDestinosPasajeros.Size = new System.Drawing.Size(303, 82);
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
			this.lbCantPasajeros.Location = new System.Drawing.Point(3, 44);
			this.lbCantPasajeros.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
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
			this.cmbDestinos.Size = new System.Drawing.Size(221, 28);
			this.cmbDestinos.TabIndex = 0;
			// 
			// nudCantPersonas
			// 
			this.nudCantPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.nudCantPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudCantPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudCantPersonas.ForeColor = System.Drawing.Color.White;
			this.nudCantPersonas.Location = new System.Drawing.Point(79, 44);
			this.nudCantPersonas.Name = "nudCantPersonas";
			this.nudCantPersonas.Size = new System.Drawing.Size(221, 23);
			this.nudCantPersonas.TabIndex = 1;
			// 
			// pnlDisponibilidad
			// 
			this.pnlDisponibilidad.Controls.Add(this.gpFecha);
			this.pnlDisponibilidad.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlDisponibilidad.Location = new System.Drawing.Point(235, 6);
			this.pnlDisponibilidad.Name = "pnlDisponibilidad";
			this.pnlDisponibilidad.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.pnlDisponibilidad.Size = new System.Drawing.Size(184, 90);
			this.pnlDisponibilidad.TabIndex = 2;
			// 
			// gpFecha
			// 
			this.gpFecha.Controls.Add(this.cbFecha);
			this.gpFecha.Controls.Add(this.pnlFechas);
			this.gpFecha.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gpFecha.Font = new System.Drawing.Font("Lato Black", 9F);
			this.gpFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
			this.gpFecha.Location = new System.Drawing.Point(3, 0);
			this.gpFecha.Name = "gpFecha";
			this.gpFecha.Size = new System.Drawing.Size(178, 90);
			this.gpFecha.TabIndex = 0;
			this.gpFecha.TabStop = false;
			this.gpFecha.Text = "DISPONIBILIDAD";
			// 
			// cbFecha
			// 
			this.cbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbFecha.AutoSize = true;
			this.cbFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbFecha.Location = new System.Drawing.Point(159, 4);
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
			this.pnlFechas.Location = new System.Drawing.Point(3, 18);
			this.pnlFechas.Margin = new System.Windows.Forms.Padding(0);
			this.pnlFechas.Name = "pnlFechas";
			this.pnlFechas.Size = new System.Drawing.Size(172, 69);
			this.pnlFechas.TabIndex = 4;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.dtpSalida, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lbIngreso, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dtpIngreso, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbSalida, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(172, 69);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// dtpSalida
			// 
			this.dtpSalida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpSalida.Location = new System.Drawing.Point(67, 37);
			this.dtpSalida.Name = "dtpSalida";
			this.dtpSalida.Size = new System.Drawing.Size(102, 27);
			this.dtpSalida.TabIndex = 1;
			// 
			// lbIngreso
			// 
			this.lbIngreso.AutoSize = true;
			this.lbIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.lbIngreso.Location = new System.Drawing.Point(3, 5);
			this.lbIngreso.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
			this.lbIngreso.Name = "lbIngreso";
			this.lbIngreso.Size = new System.Drawing.Size(58, 20);
			this.lbIngreso.TabIndex = 0;
			this.lbIngreso.Text = "Ingreso";
			// 
			// dtpIngreso
			// 
			this.dtpIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpIngreso.Location = new System.Drawing.Point(67, 3);
			this.dtpIngreso.Name = "dtpIngreso";
			this.dtpIngreso.Size = new System.Drawing.Size(102, 27);
			this.dtpIngreso.TabIndex = 0;
			// 
			// lbSalida
			// 
			this.lbSalida.AutoSize = true;
			this.lbSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.lbSalida.Location = new System.Drawing.Point(3, 39);
			this.lbSalida.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
			this.lbSalida.Name = "lbSalida";
			this.lbSalida.Size = new System.Drawing.Size(50, 20);
			this.lbSalida.TabIndex = 1;
			this.lbSalida.Text = "Salida";
			// 
			// pnlPrecio
			// 
			this.pnlPrecio.Controls.Add(this.gbPrecio);
			this.pnlPrecio.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlPrecio.Location = new System.Drawing.Point(107, 6);
			this.pnlPrecio.Name = "pnlPrecio";
			this.pnlPrecio.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.pnlPrecio.Size = new System.Drawing.Size(128, 90);
			this.pnlPrecio.TabIndex = 1;
			// 
			// gbPrecio
			// 
			this.gbPrecio.Controls.Add(this.tlpPrecioMinMax);
			this.gbPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbPrecio.Font = new System.Drawing.Font("Lato Black", 9F);
			this.gbPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
			this.gbPrecio.Location = new System.Drawing.Point(3, 0);
			this.gbPrecio.Name = "gbPrecio";
			this.gbPrecio.Size = new System.Drawing.Size(122, 90);
			this.gbPrecio.TabIndex = 0;
			this.gbPrecio.TabStop = false;
			this.gbPrecio.Text = "PRECIO";
			// 
			// tlpPrecioMinMax
			// 
			this.tlpPrecioMinMax.ColumnCount = 2;
			this.tlpPrecioMinMax.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
			this.tlpPrecioMinMax.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpPrecioMinMax.Controls.Add(this.nudMaxPrice, 1, 1);
			this.tlpPrecioMinMax.Controls.Add(this.nudMinPrice, 1, 0);
			this.tlpPrecioMinMax.Controls.Add(this.lbMin, 0, 0);
			this.tlpPrecioMinMax.Controls.Add(this.lbMax, 0, 1);
			this.tlpPrecioMinMax.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpPrecioMinMax.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tlpPrecioMinMax.Location = new System.Drawing.Point(3, 18);
			this.tlpPrecioMinMax.Name = "tlpPrecioMinMax";
			this.tlpPrecioMinMax.RowCount = 2;
			this.tlpPrecioMinMax.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpPrecioMinMax.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpPrecioMinMax.Size = new System.Drawing.Size(116, 69);
			this.tlpPrecioMinMax.TabIndex = 0;
			// 
			// nudMaxPrice
			// 
			this.nudMaxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.nudMaxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudMaxPrice.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudMaxPrice.ForeColor = System.Drawing.Color.White;
			this.nudMaxPrice.Location = new System.Drawing.Point(50, 37);
			this.nudMaxPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.nudMaxPrice.Name = "nudMaxPrice";
			this.nudMaxPrice.Size = new System.Drawing.Size(63, 23);
			this.nudMaxPrice.TabIndex = 1;
			this.nudMaxPrice.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
			this.nudMaxPrice.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
			// 
			// nudMinPrice
			// 
			this.nudMinPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.nudMinPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudMinPrice.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudMinPrice.ForeColor = System.Drawing.Color.White;
			this.nudMinPrice.Location = new System.Drawing.Point(50, 3);
			this.nudMinPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.nudMinPrice.Name = "nudMinPrice";
			this.nudMinPrice.Size = new System.Drawing.Size(63, 23);
			this.nudMinPrice.TabIndex = 0;
			this.nudMinPrice.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
			this.nudMinPrice.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
			// 
			// lbMin
			// 
			this.lbMin.AutoSize = true;
			this.lbMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.lbMin.Location = new System.Drawing.Point(3, 3);
			this.lbMin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.lbMin.Name = "lbMin";
			this.lbMin.Size = new System.Drawing.Size(37, 20);
			this.lbMin.TabIndex = 16;
			this.lbMin.Text = "Mín.";
			// 
			// lbMax
			// 
			this.lbMax.AutoSize = true;
			this.lbMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.lbMax.Location = new System.Drawing.Point(3, 37);
			this.lbMax.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.lbMax.Name = "lbMax";
			this.lbMax.Size = new System.Drawing.Size(40, 20);
			this.lbMax.TabIndex = 15;
			this.lbMax.Text = "Máx.";
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
			this.tlpFiltroResidencias.Size = new System.Drawing.Size(101, 90);
			this.tlpFiltroResidencias.TabIndex = 0;
			// 
			// rbCualquiera
			// 
			this.rbCualquiera.AutoSize = true;
			this.rbCualquiera.Checked = true;
			this.rbCualquiera.Location = new System.Drawing.Point(3, 1);
			this.rbCualquiera.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
			this.rbCualquiera.Name = "rbCualquiera";
			this.rbCualquiera.Size = new System.Drawing.Size(90, 22);
			this.rbCualquiera.TabIndex = 0;
			this.rbCualquiera.TabStop = true;
			this.rbCualquiera.Text = "Cualquier";
			this.rbCualquiera.UseVisualStyleBackColor = true;
			// 
			// rbCasa
			// 
			this.rbCasa.AutoSize = true;
			this.rbCasa.Location = new System.Drawing.Point(3, 24);
			this.rbCasa.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
			this.rbCasa.Name = "rbCasa";
			this.rbCasa.Size = new System.Drawing.Size(58, 22);
			this.rbCasa.TabIndex = 1;
			this.rbCasa.Text = "Casa";
			this.rbCasa.UseVisualStyleBackColor = true;
			// 
			// rbCasaFinde
			// 
			this.rbCasaFinde.AutoSize = true;
			this.rbCasaFinde.Location = new System.Drawing.Point(3, 47);
			this.rbCasaFinde.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
			this.rbCasaFinde.Name = "rbCasaFinde";
			this.rbCasaFinde.Size = new System.Drawing.Size(94, 22);
			this.rbCasaFinde.TabIndex = 2;
			this.rbCasaFinde.Text = "CasaFinde";
			this.rbCasaFinde.UseVisualStyleBackColor = true;
			// 
			// rbHotel
			// 
			this.rbHotel.AutoSize = true;
			this.rbHotel.Location = new System.Drawing.Point(3, 70);
			this.rbHotel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
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
			this.tableLayoutPanel5.Size = new System.Drawing.Size(112, 90);
			this.tableLayoutPanel5.TabIndex = 4;
			// 
			// btnMostrarResidencias
			// 
			this.btnMostrarResidencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
			this.btnMostrarResidencias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnMostrarResidencias.FlatAppearance.BorderSize = 0;
			this.btnMostrarResidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMostrarResidencias.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnMostrarResidencias.ForeColor = System.Drawing.Color.Black;
			this.btnMostrarResidencias.Location = new System.Drawing.Point(3, 3);
			this.btnMostrarResidencias.Name = "btnMostrarResidencias";
			this.btnMostrarResidencias.Size = new System.Drawing.Size(106, 39);
			this.btnMostrarResidencias.TabIndex = 0;
			this.btnMostrarResidencias.Text = "Buscar";
			this.btnMostrarResidencias.UseVisualStyleBackColor = false;
			this.btnMostrarResidencias.Click += new System.EventHandler(this.BtnBuscarResidencias_Click);
			// 
			// btnLimpiarFiltros
			// 
			this.btnLimpiarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.btnLimpiarFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
			this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnLimpiarFiltros.Location = new System.Drawing.Point(3, 48);
			this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
			this.btnLimpiarFiltros.Size = new System.Drawing.Size(106, 39);
			this.btnLimpiarFiltros.TabIndex = 1;
			this.btnLimpiarFiltros.Text = "Limpiar";
			this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
			this.btnLimpiarFiltros.Click += new System.EventHandler(this.BtnLimpiarFiltros_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.graficarToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(844, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip";
			// 
			// inicioToolStripMenuItem
			// 
			this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.importarToolStripMenuItem,
            this.exportarToolStripMenuItem});
			this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Lato Black", 9F);
			this.inicioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
			this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
			this.inicioToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
			this.inicioToolStripMenuItem.Text = "&ARCHIVO";
			// 
			// guardarToolStripMenuItem
			// 
			this.guardarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
			this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.guardarToolStripMenuItem.Text = "&Guardar";
			this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
			// 
			// importarToolStripMenuItem
			// 
			this.importarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alquileresToolStripMenuItem});
			this.importarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
			this.importarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.importarToolStripMenuItem.Text = "&Importar...";
			// 
			// alquileresToolStripMenuItem
			// 
			this.alquileresToolStripMenuItem.Name = "alquileresToolStripMenuItem";
			this.alquileresToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.alquileresToolStripMenuItem.Text = "&Alquileres";
			this.alquileresToolStripMenuItem.Click += new System.EventHandler(this.AlquileresToolStripMenuItem_Click);
			// 
			// exportarToolStripMenuItem
			// 
			this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alquileresToolStripMenuItem1});
			this.exportarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
			this.exportarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exportarToolStripMenuItem.Text = "&Exportar...";
			// 
			// alquileresToolStripMenuItem1
			// 
			this.alquileresToolStripMenuItem1.Name = "alquileresToolStripMenuItem1";
			this.alquileresToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
			this.alquileresToolStripMenuItem1.Text = "Alquileres";
			this.alquileresToolStripMenuItem1.Click += new System.EventHandler(this.AlquileresToolStripMenuItem1_Click);
			// 
			// graficarToolStripMenuItem
			// 
			this.graficarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadPasajaerosToolStripMenuItem,
            this.propiedadesReservadasToolStripMenuItem});
			this.graficarToolStripMenuItem.Font = new System.Drawing.Font("Lato Black", 9F);
			this.graficarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
			this.graficarToolStripMenuItem.Name = "graficarToolStripMenuItem";
			this.graficarToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
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
			this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("Lato Black", 9F);
			this.usuarioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
			this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
			this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
			this.usuarioToolStripMenuItem.Text = "&USUARIO";
			// 
			// agregarUsuarioToolStripMenuItem
			// 
			this.agregarUsuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
			this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.agregarUsuarioToolStripMenuItem.Text = "&Agregar Nuevo";
			this.agregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.AgregarUsuarioToolStripMenuItem_Click);
			// 
			// eliminarUsuarioToolStripMenuItem
			// 
			this.eliminarUsuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
			this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.eliminarUsuarioToolStripMenuItem.Text = "&Eliminar Actual";
			this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.EliminarUsuarioToolStripMenuItem_Click);
			// 
			// cambiarContraseñaToolStripMenuItem
			// 
			this.cambiarContraseñaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
			this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar &Contraseña";
			this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.CambiarContraseñaToolStripMenuItem_Click);
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Lato Black", 9F);
			this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.ayudaToolStripMenuItem.Text = "A&YUDA";
			this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.AyudaToolStripMenuItem_Click);
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.Font = new System.Drawing.Font("Lato Black", 9F);
			this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
			this.acercaDeToolStripMenuItem.Text = "AC&ERCA DE...";
			this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
			// 
			// barraEstado
			// 
			this.barraEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.barraEstado.Font = new System.Drawing.Font("Lato Black", 9F);
			this.barraEstado.Location = new System.Drawing.Point(0, 579);
			this.barraEstado.Name = "barraEstado";
			this.barraEstado.Size = new System.Drawing.Size(844, 22);
			this.barraEstado.TabIndex = 5;
			// 
			// pnlResidencias
			// 
			this.pnlResidencias.Controls.Add(this.dgvResidencias);
			this.pnlResidencias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlResidencias.Location = new System.Drawing.Point(0, 126);
			this.pnlResidencias.Name = "pnlResidencias";
			this.pnlResidencias.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
			this.pnlResidencias.Size = new System.Drawing.Size(844, 402);
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
			// btnAgregarHotel
			// 
			this.btnAgregarHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
			this.btnAgregarHotel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAgregarHotel.FlatAppearance.BorderSize = 0;
			this.btnAgregarHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregarHotel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnAgregarHotel.ForeColor = System.Drawing.Color.Black;
			this.btnAgregarHotel.Image = global::tp2.Properties.Resources.plusblack24;
			this.btnAgregarHotel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregarHotel.Location = new System.Drawing.Point(169, 3);
			this.btnAgregarHotel.Name = "btnAgregarHotel";
			this.btnAgregarHotel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.btnAgregarHotel.Size = new System.Drawing.Size(160, 39);
			this.btnAgregarHotel.TabIndex = 1;
			this.btnAgregarHotel.Text = "Hotel";
			this.btnAgregarHotel.UseVisualStyleBackColor = false;
			this.btnAgregarHotel.Click += new System.EventHandler(this.BtnAgregarHotel_Click);
			// 
			// btnAgregarCasa
			// 
			this.btnAgregarCasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
			this.btnAgregarCasa.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAgregarCasa.FlatAppearance.BorderSize = 0;
			this.btnAgregarCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregarCasa.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnAgregarCasa.ForeColor = System.Drawing.Color.Black;
			this.btnAgregarCasa.Image = global::tp2.Properties.Resources.plusblack24;
			this.btnAgregarCasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregarCasa.Location = new System.Drawing.Point(3, 3);
			this.btnAgregarCasa.Name = "btnAgregarCasa";
			this.btnAgregarCasa.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.btnAgregarCasa.Size = new System.Drawing.Size(160, 39);
			this.btnAgregarCasa.TabIndex = 0;
			this.btnAgregarCasa.Text = "Casa";
			this.btnAgregarCasa.UseVisualStyleBackColor = false;
			this.btnAgregarCasa.Click += new System.EventHandler(this.BtnAgregarCasa_Click);
			// 
			// btnBorrarPropiedad
			// 
			this.btnBorrarPropiedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(61)))), ((int)(((byte)(67)))));
			this.btnBorrarPropiedad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnBorrarPropiedad.FlatAppearance.BorderSize = 0;
			this.btnBorrarPropiedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBorrarPropiedad.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnBorrarPropiedad.ForeColor = System.Drawing.Color.White;
			this.btnBorrarPropiedad.Image = global::tp2.Properties.Resources.xwhite24;
			this.btnBorrarPropiedad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBorrarPropiedad.Location = new System.Drawing.Point(667, 3);
			this.btnBorrarPropiedad.Name = "btnBorrarPropiedad";
			this.btnBorrarPropiedad.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.btnBorrarPropiedad.Size = new System.Drawing.Size(162, 39);
			this.btnBorrarPropiedad.TabIndex = 4;
			this.btnBorrarPropiedad.Text = "Eliminar";
			this.btnBorrarPropiedad.UseVisualStyleBackColor = false;
			this.btnBorrarPropiedad.Click += new System.EventHandler(this.BtnBorrarPropiedad_Click);
			// 
			// btnModificarPropiedad
			// 
			this.btnModificarPropiedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.btnModificarPropiedad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnModificarPropiedad.FlatAppearance.BorderSize = 0;
			this.btnModificarPropiedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificarPropiedad.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnModificarPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnModificarPropiedad.Image = global::tp2.Properties.Resources.pencilwhite24;
			this.btnModificarPropiedad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificarPropiedad.Location = new System.Drawing.Point(501, 3);
			this.btnModificarPropiedad.Name = "btnModificarPropiedad";
			this.btnModificarPropiedad.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.btnModificarPropiedad.Size = new System.Drawing.Size(160, 39);
			this.btnModificarPropiedad.TabIndex = 3;
			this.btnModificarPropiedad.Text = "Modificar";
			this.btnModificarPropiedad.UseVisualStyleBackColor = false;
			this.btnModificarPropiedad.Click += new System.EventHandler(this.BtnModificarPropiedad_Click);
			// 
			// btnConsultarPropiedad
			// 
			this.btnConsultarPropiedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.btnConsultarPropiedad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnConsultarPropiedad.FlatAppearance.BorderSize = 0;
			this.btnConsultarPropiedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultarPropiedad.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnConsultarPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnConsultarPropiedad.Image = global::tp2.Properties.Resources.eyewhite24;
			this.btnConsultarPropiedad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConsultarPropiedad.Location = new System.Drawing.Point(335, 3);
			this.btnConsultarPropiedad.Name = "btnConsultarPropiedad";
			this.btnConsultarPropiedad.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.btnConsultarPropiedad.Size = new System.Drawing.Size(160, 39);
			this.btnConsultarPropiedad.TabIndex = 2;
			this.btnConsultarPropiedad.Text = "Consultar";
			this.btnConsultarPropiedad.UseVisualStyleBackColor = false;
			this.btnConsultarPropiedad.Click += new System.EventHandler(this.BtnConsultarPropiedad_Click);
			// 
			// FPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
			this.ClientSize = new System.Drawing.Size(844, 601);
			this.Controls.Add(this.pnlResidencias);
			this.Controls.Add(this.pnlBotonesResidencias);
			this.Controls.Add(this.pnlFiltro);
			this.Controls.Add(this.barraEstado);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimizeBox = false;
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
			this.gpFecha.ResumeLayout(false);
			this.gpFecha.PerformLayout();
			this.pnlFechas.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.pnlPrecio.ResumeLayout(false);
			this.gbPrecio.ResumeLayout(false);
			this.tlpPrecioMinMax.ResumeLayout(false);
			this.tlpPrecioMinMax.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).EndInit();
			this.tlpFiltroResidencias.ResumeLayout(false);
			this.tlpFiltroResidencias.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
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
		private System.Windows.Forms.Label lbMin;
		private System.Windows.Forms.Label lbMax;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbFecha;
        private System.Windows.Forms.Label lbSalida;
        private System.Windows.Forms.Label lbIngreso;
        public System.Windows.Forms.DateTimePicker dtpSalida;
        public System.Windows.Forms.DateTimePicker dtpIngreso;
        public System.Windows.Forms.GroupBox gpFecha;
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
	}
}

