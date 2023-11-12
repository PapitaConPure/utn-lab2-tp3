
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
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.ofdDatos = new System.Windows.Forms.OpenFileDialog();
            this.sfdDatos = new System.Windows.Forms.SaveFileDialog();
            this.gbAgregar = new System.Windows.Forms.GroupBox();
            this.tlpBotonesAgregar = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarCasa = new System.Windows.Forms.Button();
            this.btnAgregarHotel = new System.Windows.Forms.Button();
            this.tlpBotonesDatos = new System.Windows.Forms.TableLayoutPanel();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.lsbResidencias = new System.Windows.Forms.ListBox();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.gpFecha = new System.Windows.Forms.GroupBox();
            this.pnlFecha = new System.Windows.Forms.Panel();
            this.lbIngreso = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.lbSalida = new System.Windows.Forms.Label();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.cbFecha = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbDestino = new System.Windows.Forms.Label();
            this.lbCantPasajeros = new System.Windows.Forms.Label();
            this.cmbDestinos = new System.Windows.Forms.ComboBox();
            this.nudCantPersonas = new System.Windows.Forms.NumericUpDown();
            this.gbPrecio = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.nudMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.nudMinPrice = new System.Windows.Forms.NumericUpDown();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rbCasa = new System.Windows.Forms.RadioButton();
            this.rbCasaFinde = new System.Windows.Forms.RadioButton();
            this.rbHotel = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMostrarResidencias = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.tlpBotonesPropiedades = new System.Windows.Forms.TableLayoutPanel();
            this.btnBorrarPropiedad = new System.Windows.Forms.Button();
            this.btnModificarPropiedad = new System.Windows.Forms.Button();
            this.btnConsultarPropiedad = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadPasajaerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesReservadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAgregar.SuspendLayout();
            this.tlpBotonesAgregar.SuspendLayout();
            this.tlpBotonesDatos.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.gbBuscar.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.gpFecha.SuspendLayout();
            this.pnlFecha.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).BeginInit();
            this.gbPrecio.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tlpBotonesPropiedades.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnImportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImportar.FlatAppearance.BorderSize = 0;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnImportar.Location = new System.Drawing.Point(3, 3);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(572, 42);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.BtnImportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnExportar.Location = new System.Drawing.Point(709, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(574, 42);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
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
            // gbAgregar
            // 
            this.gbAgregar.Controls.Add(this.tlpBotonesAgregar);
            this.gbAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAgregar.Location = new System.Drawing.Point(0, 24);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(1292, 79);
            this.gbAgregar.TabIndex = 0;
            this.gbAgregar.TabStop = false;
            this.gbAgregar.Text = "Agregar Residencias";
            // 
            // tlpBotonesAgregar
            // 
            this.tlpBotonesAgregar.ColumnCount = 3;
            this.tlpBotonesAgregar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotonesAgregar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpBotonesAgregar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotonesAgregar.Controls.Add(this.btnAgregarCasa, 0, 0);
            this.tlpBotonesAgregar.Controls.Add(this.btnAgregarHotel, 2, 0);
            this.tlpBotonesAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBotonesAgregar.Location = new System.Drawing.Point(3, 23);
            this.tlpBotonesAgregar.Name = "tlpBotonesAgregar";
            this.tlpBotonesAgregar.RowCount = 1;
            this.tlpBotonesAgregar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotonesAgregar.Size = new System.Drawing.Size(1286, 52);
            this.tlpBotonesAgregar.TabIndex = 0;
            // 
            // btnAgregarCasa
            // 
            this.btnAgregarCasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(70)))));
            this.btnAgregarCasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarCasa.FlatAppearance.BorderSize = 0;
            this.btnAgregarCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCasa.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnAgregarCasa.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCasa.Image = global::tp2.Properties.Resources.plusblack32;
            this.btnAgregarCasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCasa.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarCasa.Name = "btnAgregarCasa";
            this.btnAgregarCasa.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnAgregarCasa.Size = new System.Drawing.Size(631, 46);
            this.btnAgregarCasa.TabIndex = 0;
            this.btnAgregarCasa.Text = "Casa";
            this.btnAgregarCasa.UseVisualStyleBackColor = false;
            this.btnAgregarCasa.Click += new System.EventHandler(this.BtnAgregarCasa_Click);
            // 
            // btnAgregarHotel
            // 
            this.btnAgregarHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(70)))));
            this.btnAgregarHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarHotel.FlatAppearance.BorderSize = 0;
            this.btnAgregarHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarHotel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnAgregarHotel.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarHotel.Image = global::tp2.Properties.Resources.plusblack32;
            this.btnAgregarHotel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarHotel.Location = new System.Drawing.Point(652, 3);
            this.btnAgregarHotel.Name = "btnAgregarHotel";
            this.btnAgregarHotel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnAgregarHotel.Size = new System.Drawing.Size(631, 46);
            this.btnAgregarHotel.TabIndex = 1;
            this.btnAgregarHotel.Text = "Hotel";
            this.btnAgregarHotel.UseVisualStyleBackColor = false;
            this.btnAgregarHotel.Click += new System.EventHandler(this.BtnAgregarHotel_Click);
            // 
            // tlpBotonesDatos
            // 
            this.tlpBotonesDatos.ColumnCount = 3;
            this.tlpBotonesDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpBotonesDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBotonesDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpBotonesDatos.Controls.Add(this.btnImportar, 0, 0);
            this.tlpBotonesDatos.Controls.Add(this.btnExportar, 2, 0);
            this.tlpBotonesDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotonesDatos.Location = new System.Drawing.Point(3, 23);
            this.tlpBotonesDatos.Name = "tlpBotonesDatos";
            this.tlpBotonesDatos.RowCount = 1;
            this.tlpBotonesDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotonesDatos.Size = new System.Drawing.Size(1286, 48);
            this.tlpBotonesDatos.TabIndex = 13;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.tlpBotonesDatos);
            this.gbDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDatos.Location = new System.Drawing.Point(0, 544);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(1292, 74);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Alquileres";
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.lsbResidencias);
            this.gbBuscar.Controls.Add(this.pnlFiltro);
            this.gbBuscar.Controls.Add(this.tlpBotonesPropiedades);
            this.gbBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBuscar.Location = new System.Drawing.Point(0, 103);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(1292, 441);
            this.gbBuscar.TabIndex = 2;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Administrar Residencias";
            // 
            // lsbResidencias
            // 
            this.lsbResidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbResidencias.FormattingEnabled = true;
            this.lsbResidencias.IntegralHeight = false;
            this.lsbResidencias.ItemHeight = 20;
            this.lsbResidencias.Location = new System.Drawing.Point(3, 109);
            this.lsbResidencias.Name = "lsbResidencias";
            this.lsbResidencias.Size = new System.Drawing.Size(1286, 281);
            this.lsbResidencias.TabIndex = 1;
            this.lsbResidencias.DoubleClick += new System.EventHandler(this.BtnConsultarPropiedad_Click);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.gpFecha);
            this.pnlFiltro.Controls.Add(this.tableLayoutPanel4);
            this.pnlFiltro.Controls.Add(this.gbPrecio);
            this.pnlFiltro.Controls.Add(this.tableLayoutPanel2);
            this.pnlFiltro.Controls.Add(this.tableLayoutPanel5);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(3, 23);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlFiltro.Size = new System.Drawing.Size(1286, 86);
            this.pnlFiltro.TabIndex = 21;
            // 
            // gpFecha
            // 
            this.gpFecha.Controls.Add(this.pnlFecha);
            this.gpFecha.Controls.Add(this.cbFecha);
            this.gpFecha.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpFecha.Location = new System.Drawing.Point(510, 0);
            this.gpFecha.Name = "gpFecha";
            this.gpFecha.Size = new System.Drawing.Size(348, 86);
            this.gpFecha.TabIndex = 3;
            this.gpFecha.TabStop = false;
            this.gpFecha.Text = "Disponibilidad";
            // 
            // pnlFecha
            // 
            this.pnlFecha.Controls.Add(this.lbIngreso);
            this.pnlFecha.Controls.Add(this.dtpSalida);
            this.pnlFecha.Controls.Add(this.lbSalida);
            this.pnlFecha.Controls.Add(this.dtpIngreso);
            this.pnlFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFecha.Enabled = false;
            this.pnlFecha.Location = new System.Drawing.Point(3, 23);
            this.pnlFecha.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(342, 60);
            this.pnlFecha.TabIndex = 4;
            // 
            // lbIngreso
            // 
            this.lbIngreso.AutoSize = true;
            this.lbIngreso.Location = new System.Drawing.Point(9, 8);
            this.lbIngreso.Name = "lbIngreso";
            this.lbIngreso.Size = new System.Drawing.Size(58, 20);
            this.lbIngreso.TabIndex = 0;
            this.lbIngreso.Text = "Ingreso";
            // 
            // dtpSalida
            // 
            this.dtpSalida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSalida.Location = new System.Drawing.Point(73, 33);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(266, 27);
            this.dtpSalida.TabIndex = 1;
            // 
            // lbSalida
            // 
            this.lbSalida.AutoSize = true;
            this.lbSalida.Location = new System.Drawing.Point(9, 38);
            this.lbSalida.Name = "lbSalida";
            this.lbSalida.Size = new System.Drawing.Size(50, 20);
            this.lbSalida.TabIndex = 1;
            this.lbSalida.Text = "Salida";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpIngreso.Location = new System.Drawing.Point(73, 3);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(266, 27);
            this.dtpIngreso.TabIndex = 0;
            // 
            // cbFecha
            // 
            this.cbFecha.AutoSize = true;
            this.cbFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbFecha.Location = new System.Drawing.Point(279, 0);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(87, 24);
            this.cbFecha.TabIndex = 26;
            this.cbFecha.Text = "Activado";
            this.cbFecha.UseVisualStyleBackColor = true;
            this.cbFecha.CheckedChanged += new System.EventHandler(this.cbFecha_CheckedChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lbDestino, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbCantPasajeros, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cmbDestinos, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.nudCantPersonas, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(226, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(284, 86);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // lbDestino
            // 
            this.lbDestino.AutoSize = true;
            this.lbDestino.Location = new System.Drawing.Point(3, 6);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(66, 20);
            this.lbDestino.TabIndex = 12;
            this.lbDestino.Text = "Destinos";
            // 
            // lbCantPasajeros
            // 
            this.lbCantPasajeros.AutoSize = true;
            this.lbCantPasajeros.Location = new System.Drawing.Point(3, 43);
            this.lbCantPasajeros.Name = "lbCantPasajeros";
            this.lbCantPasajeros.Size = new System.Drawing.Size(70, 20);
            this.lbCantPasajeros.TabIndex = 18;
            this.lbCantPasajeros.Text = "Pasajeros";
            // 
            // cmbDestinos
            // 
            this.cmbDestinos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDestinos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinos.FormattingEnabled = true;
            this.cmbDestinos.Location = new System.Drawing.Point(79, 9);
            this.cmbDestinos.Name = "cmbDestinos";
            this.cmbDestinos.Size = new System.Drawing.Size(202, 28);
            this.cmbDestinos.TabIndex = 11;
            // 
            // nudCantPersonas
            // 
            this.nudCantPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCantPersonas.Location = new System.Drawing.Point(79, 46);
            this.nudCantPersonas.Name = "nudCantPersonas";
            this.nudCantPersonas.Size = new System.Drawing.Size(202, 27);
            this.nudCantPersonas.TabIndex = 19;
            // 
            // gbPrecio
            // 
            this.gbPrecio.Controls.Add(this.tableLayoutPanel3);
            this.gbPrecio.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPrecio.Location = new System.Drawing.Point(104, 0);
            this.gbPrecio.Name = "gbPrecio";
            this.gbPrecio.Size = new System.Drawing.Size(122, 86);
            this.gbPrecio.TabIndex = 1;
            this.gbPrecio.TabStop = false;
            this.gbPrecio.Text = "Precio";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.nudMaxPrice, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.nudMinPrice, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbMin, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbMax, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(116, 60);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // nudMaxPrice
            // 
            this.nudMaxPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudMaxPrice.Location = new System.Drawing.Point(50, 33);
            this.nudMaxPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudMaxPrice.Name = "nudMaxPrice";
            this.nudMaxPrice.Size = new System.Drawing.Size(63, 27);
            this.nudMaxPrice.TabIndex = 13;
            this.nudMaxPrice.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // nudMinPrice
            // 
            this.nudMinPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudMinPrice.Location = new System.Drawing.Point(50, 3);
            this.nudMinPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMinPrice.Name = "nudMinPrice";
            this.nudMinPrice.Size = new System.Drawing.Size(63, 27);
            this.nudMinPrice.TabIndex = 14;
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(3, 0);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(37, 20);
            this.lbMin.TabIndex = 16;
            this.lbMin.Text = "Mín.";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(3, 30);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(40, 20);
            this.lbMax.TabIndex = 15;
            this.lbMax.Text = "Máx.";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.rbCasa, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbCasaFinde, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.rbHotel, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(101, 86);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // rbCasa
            // 
            this.rbCasa.AutoSize = true;
            this.rbCasa.Location = new System.Drawing.Point(3, 3);
            this.rbCasa.Name = "rbCasa";
            this.rbCasa.Size = new System.Drawing.Size(58, 22);
            this.rbCasa.TabIndex = 6;
            this.rbCasa.TabStop = true;
            this.rbCasa.Text = "Casa";
            this.rbCasa.UseVisualStyleBackColor = true;
            // 
            // rbCasaFinde
            // 
            this.rbCasaFinde.AutoSize = true;
            this.rbCasaFinde.Location = new System.Drawing.Point(3, 31);
            this.rbCasaFinde.Name = "rbCasaFinde";
            this.rbCasaFinde.Size = new System.Drawing.Size(94, 22);
            this.rbCasaFinde.TabIndex = 7;
            this.rbCasaFinde.TabStop = true;
            this.rbCasaFinde.Text = "CasaFinde";
            this.rbCasaFinde.UseVisualStyleBackColor = true;
            // 
            // rbHotel
            // 
            this.rbHotel.AutoSize = true;
            this.rbHotel.Location = new System.Drawing.Point(3, 59);
            this.rbHotel.Name = "rbHotel";
            this.rbHotel.Size = new System.Drawing.Size(64, 24);
            this.rbHotel.TabIndex = 9;
            this.rbHotel.TabStop = true;
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
            this.tableLayoutPanel5.Location = new System.Drawing.Point(1171, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(112, 86);
            this.tableLayoutPanel5.TabIndex = 24;
            // 
            // btnMostrarResidencias
            // 
            this.btnMostrarResidencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(70)))));
            this.btnMostrarResidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMostrarResidencias.FlatAppearance.BorderSize = 0;
            this.btnMostrarResidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarResidencias.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnMostrarResidencias.Location = new System.Drawing.Point(3, 3);
            this.btnMostrarResidencias.Name = "btnMostrarResidencias";
            this.btnMostrarResidencias.Size = new System.Drawing.Size(106, 37);
            this.btnMostrarResidencias.TabIndex = 4;
            this.btnMostrarResidencias.Text = "Buscar";
            this.btnMostrarResidencias.UseVisualStyleBackColor = false;
            this.btnMostrarResidencias.Click += new System.EventHandler(this.BtnBuscarResidencias_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnLimpiarFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(3, 46);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(106, 37);
            this.btnLimpiarFiltros.TabIndex = 5;
            this.btnLimpiarFiltros.Text = "Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.BtnLimpiarFiltros_Click);
            // 
            // tlpBotonesPropiedades
            // 
            this.tlpBotonesPropiedades.ColumnCount = 3;
            this.tlpBotonesPropiedades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBotonesPropiedades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBotonesPropiedades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBotonesPropiedades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBotonesPropiedades.Controls.Add(this.btnBorrarPropiedad, 2, 0);
            this.tlpBotonesPropiedades.Controls.Add(this.btnModificarPropiedad, 0, 0);
            this.tlpBotonesPropiedades.Controls.Add(this.btnConsultarPropiedad, 1, 0);
            this.tlpBotonesPropiedades.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpBotonesPropiedades.Location = new System.Drawing.Point(3, 390);
            this.tlpBotonesPropiedades.Name = "tlpBotonesPropiedades";
            this.tlpBotonesPropiedades.RowCount = 1;
            this.tlpBotonesPropiedades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotonesPropiedades.Size = new System.Drawing.Size(1286, 48);
            this.tlpBotonesPropiedades.TabIndex = 22;
            // 
            // btnBorrarPropiedad
            // 
            this.btnBorrarPropiedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
            this.btnBorrarPropiedad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrarPropiedad.FlatAppearance.BorderSize = 0;
            this.btnBorrarPropiedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarPropiedad.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnBorrarPropiedad.ForeColor = System.Drawing.Color.White;
            this.btnBorrarPropiedad.Image = global::tp2.Properties.Resources.xwhite32;
            this.btnBorrarPropiedad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarPropiedad.Location = new System.Drawing.Point(859, 3);
            this.btnBorrarPropiedad.Name = "btnBorrarPropiedad";
            this.btnBorrarPropiedad.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnBorrarPropiedad.Size = new System.Drawing.Size(424, 42);
            this.btnBorrarPropiedad.TabIndex = 2;
            this.btnBorrarPropiedad.Text = "Eliminar";
            this.btnBorrarPropiedad.UseVisualStyleBackColor = false;
            this.btnBorrarPropiedad.Click += new System.EventHandler(this.BtnBorrarPropiedad_Click);
            // 
            // btnModificarPropiedad
            // 
            this.btnModificarPropiedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnModificarPropiedad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificarPropiedad.FlatAppearance.BorderSize = 0;
            this.btnModificarPropiedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPropiedad.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnModificarPropiedad.Location = new System.Drawing.Point(3, 3);
            this.btnModificarPropiedad.Name = "btnModificarPropiedad";
            this.btnModificarPropiedad.Size = new System.Drawing.Size(422, 42);
            this.btnModificarPropiedad.TabIndex = 0;
            this.btnModificarPropiedad.Text = "Modificar";
            this.btnModificarPropiedad.UseVisualStyleBackColor = false;
            this.btnModificarPropiedad.Click += new System.EventHandler(this.BtnModificarPropiedad_Click);
            // 
            // btnConsultarPropiedad
            // 
            this.btnConsultarPropiedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.btnConsultarPropiedad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConsultarPropiedad.FlatAppearance.BorderSize = 0;
            this.btnConsultarPropiedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPropiedad.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnConsultarPropiedad.ForeColor = System.Drawing.Color.White;
            this.btnConsultarPropiedad.Location = new System.Drawing.Point(431, 3);
            this.btnConsultarPropiedad.Name = "btnConsultarPropiedad";
            this.btnConsultarPropiedad.Size = new System.Drawing.Size(422, 42);
            this.btnConsultarPropiedad.TabIndex = 1;
            this.btnConsultarPropiedad.Text = "Consultar";
            this.btnConsultarPropiedad.UseVisualStyleBackColor = false;
            this.btnConsultarPropiedad.Click += new System.EventHandler(this.BtnConsultarPropiedad_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.graficarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // graficarToolStripMenuItem
            // 
            this.graficarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadPasajaerosToolStripMenuItem,
            this.propiedadesReservadasToolStripMenuItem});
            this.graficarToolStripMenuItem.Name = "graficarToolStripMenuItem";
            this.graficarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.graficarToolStripMenuItem.Text = "Graficar";
            // 
            // cantidadPasajaerosToolStripMenuItem
            // 
            this.cantidadPasajaerosToolStripMenuItem.Name = "cantidadPasajaerosToolStripMenuItem";
            this.cantidadPasajaerosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cantidadPasajaerosToolStripMenuItem.Text = "Cantidad Pasajeros";
            this.cantidadPasajaerosToolStripMenuItem.Click += new System.EventHandler(this.cantidadPasajaerosToolStripMenuItem_Click);
            // 
            // propiedadesReservadasToolStripMenuItem
            // 
            this.propiedadesReservadasToolStripMenuItem.Name = "propiedadesReservadasToolStripMenuItem";
            this.propiedadesReservadasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.propiedadesReservadasToolStripMenuItem.Text = "Propiedades Reservadas";
            this.propiedadesReservadasToolStripMenuItem.Click += new System.EventHandler(this.propiedadesReservadasToolStripMenuItem_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 618);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.gbAgregar);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa de Alquileres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            this.gbAgregar.ResumeLayout(false);
            this.tlpBotonesAgregar.ResumeLayout(false);
            this.tlpBotonesDatos.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbBuscar.ResumeLayout(false);
            this.pnlFiltro.ResumeLayout(false);
            this.gpFecha.ResumeLayout(false);
            this.gpFecha.PerformLayout();
            this.pnlFecha.ResumeLayout(false);
            this.pnlFecha.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).EndInit();
            this.gbPrecio.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tlpBotonesPropiedades.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.Button btnAgregarCasa;
        private System.Windows.Forms.Button btnAgregarHotel;
		private System.Windows.Forms.Button btnImportar;
		private System.Windows.Forms.Button btnExportar;
		private System.Windows.Forms.OpenFileDialog ofdDatos;
		private System.Windows.Forms.SaveFileDialog sfdDatos;
		private System.Windows.Forms.GroupBox gbAgregar;
		private System.Windows.Forms.TableLayoutPanel tlpBotonesDatos;
		private System.Windows.Forms.GroupBox gbDatos;
		private System.Windows.Forms.TableLayoutPanel tlpBotonesAgregar;
		private System.Windows.Forms.GroupBox gbBuscar;
		private System.Windows.Forms.ListBox lsbResidencias;
        private System.Windows.Forms.Button btnMostrarResidencias;
        private System.Windows.Forms.RadioButton rbHotel;
        private System.Windows.Forms.RadioButton rbCasaFinde;
        private System.Windows.Forms.RadioButton rbCasa;
        private System.Windows.Forms.Label lbDestino;
        private System.Windows.Forms.ComboBox cmbDestinos;
        private System.Windows.Forms.NumericUpDown nudMinPrice;
        private System.Windows.Forms.NumericUpDown nudMaxPrice;
        private System.Windows.Forms.NumericUpDown nudCantPersonas;
        private System.Windows.Forms.Label lbCantPasajeros;
        private System.Windows.Forms.Button btnLimpiarFiltros;
		private System.Windows.Forms.Panel pnlFiltro;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox gbPrecio;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label lbMin;
		private System.Windows.Forms.Label lbMax;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.TableLayoutPanel tlpBotonesPropiedades;
		private System.Windows.Forms.Button btnBorrarPropiedad;
		private System.Windows.Forms.Button btnModificarPropiedad;
		private System.Windows.Forms.Button btnConsultarPropiedad;
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
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
		private System.Windows.Forms.Panel pnlFecha;
	}
}

