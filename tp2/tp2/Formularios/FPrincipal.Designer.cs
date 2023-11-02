
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
            this.btnAgregarCasa = new System.Windows.Forms.Button();
            this.btnAgregarHotel = new System.Windows.Forms.Button();
            this.btnBorrarPropiedad = new System.Windows.Forms.Button();
            this.btnModificarPropiedad = new System.Windows.Forms.Button();
            this.btnVerPropiedad = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.ofdDatos = new System.Windows.Forms.OpenFileDialog();
            this.sfdDatos = new System.Windows.Forms.SaveFileDialog();
            this.tlpBotonesPropiedades = new System.Windows.Forms.TableLayoutPanel();
            this.gbResidencias = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbResidencias = new System.Windows.Forms.ComboBox();
            this.tlpBotonesAgregar = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBotonesDatos = new System.Windows.Forms.TableLayoutPanel();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.nudCantPersonas = new System.Windows.Forms.NumericUpDown();
            this.lbCantPasajeros = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.nudMinPrice = new System.Windows.Forms.NumericUpDown();
            this.nudMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.lbDestino = new System.Windows.Forms.Label();
            this.cbDestinos = new System.Windows.Forms.ComboBox();
            this.rbHotel = new System.Windows.Forms.RadioButton();
            this.rbCasaFinde = new System.Windows.Forms.RadioButton();
            this.rbCasa = new System.Windows.Forms.RadioButton();
            this.btnVerAlquiler = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.lbResidencias = new System.Windows.Forms.ListBox();
            this.tlpBotonesPropiedades.SuspendLayout();
            this.gbResidencias.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpBotonesAgregar.SuspendLayout();
            this.tlpBotonesDatos.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.gbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarCasa
            // 
            this.btnAgregarCasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(70)))));
            this.btnAgregarCasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarCasa.FlatAppearance.BorderSize = 0;
            this.btnAgregarCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCasa.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnAgregarCasa.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCasa.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarCasa.Name = "btnAgregarCasa";
            this.btnAgregarCasa.Size = new System.Drawing.Size(358, 46);
            this.btnAgregarCasa.TabIndex = 0;
            this.btnAgregarCasa.Text = "Agregar Casa";
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
            this.btnAgregarHotel.Location = new System.Drawing.Point(379, 3);
            this.btnAgregarHotel.Name = "btnAgregarHotel";
            this.btnAgregarHotel.Size = new System.Drawing.Size(358, 46);
            this.btnAgregarHotel.TabIndex = 1;
            this.btnAgregarHotel.Text = "Agregar Hotel";
            this.btnAgregarHotel.UseVisualStyleBackColor = false;
            this.btnAgregarHotel.Click += new System.EventHandler(this.BtnAgregarHotel_Click);
            // 
            // btnBorrarPropiedad
            // 
            this.btnBorrarPropiedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
            this.btnBorrarPropiedad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrarPropiedad.FlatAppearance.BorderSize = 0;
            this.btnBorrarPropiedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarPropiedad.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnBorrarPropiedad.ForeColor = System.Drawing.Color.White;
            this.btnBorrarPropiedad.Location = new System.Drawing.Point(495, 3);
            this.btnBorrarPropiedad.Name = "btnBorrarPropiedad";
            this.btnBorrarPropiedad.Size = new System.Drawing.Size(242, 36);
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
            this.btnModificarPropiedad.Size = new System.Drawing.Size(240, 36);
            this.btnModificarPropiedad.TabIndex = 0;
            this.btnModificarPropiedad.Text = "Modificar";
            this.btnModificarPropiedad.UseVisualStyleBackColor = false;
            this.btnModificarPropiedad.Click += new System.EventHandler(this.BtnModificarPropiedad_Click);
            // 
            // btnVerPropiedad
            // 
            this.btnVerPropiedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.btnVerPropiedad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerPropiedad.FlatAppearance.BorderSize = 0;
            this.btnVerPropiedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPropiedad.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnVerPropiedad.ForeColor = System.Drawing.Color.White;
            this.btnVerPropiedad.Location = new System.Drawing.Point(249, 3);
            this.btnVerPropiedad.Name = "btnVerPropiedad";
            this.btnVerPropiedad.Size = new System.Drawing.Size(240, 36);
            this.btnVerPropiedad.TabIndex = 1;
            this.btnVerPropiedad.Text = "Consultar";
            this.btnVerPropiedad.UseVisualStyleBackColor = false;
            this.btnVerPropiedad.Click += new System.EventHandler(this.BtnVerPropiedad_Click);
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
            this.btnImportar.Size = new System.Drawing.Size(327, 31);
            this.btnImportar.TabIndex = 9;
            this.btnImportar.Text = "Importar Alquileres";
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
            this.btnExportar.Location = new System.Drawing.Point(410, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(327, 31);
            this.btnExportar.TabIndex = 10;
            this.btnExportar.Text = "Exportar Alquileres";
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
            // tlpBotonesPropiedades
            // 
            this.tlpBotonesPropiedades.ColumnCount = 3;
            this.tlpBotonesPropiedades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotonesPropiedades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotonesPropiedades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotonesPropiedades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotonesPropiedades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotonesPropiedades.Controls.Add(this.btnBorrarPropiedad, 2, 0);
            this.tlpBotonesPropiedades.Controls.Add(this.btnModificarPropiedad, 0, 0);
            this.tlpBotonesPropiedades.Controls.Add(this.btnVerPropiedad, 1, 0);
            this.tlpBotonesPropiedades.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpBotonesPropiedades.Location = new System.Drawing.Point(3, 119);
            this.tlpBotonesPropiedades.Name = "tlpBotonesPropiedades";
            this.tlpBotonesPropiedades.RowCount = 1;
            this.tlpBotonesPropiedades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotonesPropiedades.Size = new System.Drawing.Size(740, 42);
            this.tlpBotonesPropiedades.TabIndex = 2;
            // 
            // gbResidencias
            // 
            this.gbResidencias.Controls.Add(this.tableLayoutPanel1);
            this.gbResidencias.Controls.Add(this.tlpBotonesPropiedades);
            this.gbResidencias.Controls.Add(this.tlpBotonesAgregar);
            this.gbResidencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbResidencias.Location = new System.Drawing.Point(0, 0);
            this.gbResidencias.Name = "gbResidencias";
            this.gbResidencias.Size = new System.Drawing.Size(746, 164);
            this.gbResidencias.TabIndex = 0;
            this.gbResidencias.TabStop = false;
            this.gbResidencias.Text = "Residencias";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cmbResidencias, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 44);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cmbResidencias
            // 
            this.cmbResidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbResidencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResidencias.FormattingEnabled = true;
            this.cmbResidencias.Location = new System.Drawing.Point(3, 17);
            this.cmbResidencias.Name = "cmbResidencias";
            this.cmbResidencias.Size = new System.Drawing.Size(734, 28);
            this.cmbResidencias.TabIndex = 6;
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
            this.tlpBotonesAgregar.Size = new System.Drawing.Size(740, 52);
            this.tlpBotonesAgregar.TabIndex = 0;
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
            this.tlpBotonesDatos.Size = new System.Drawing.Size(740, 37);
            this.tlpBotonesDatos.TabIndex = 13;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.tlpBotonesDatos);
            this.gbDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDatos.Location = new System.Drawing.Point(0, 524);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(746, 63);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.btnLimpiarFiltros);
            this.gbBuscar.Controls.Add(this.btnVerAlquiler);
            this.gbBuscar.Controls.Add(this.nudCantPersonas);
            this.gbBuscar.Controls.Add(this.lbCantPasajeros);
            this.gbBuscar.Controls.Add(this.lbPrecio);
            this.gbBuscar.Controls.Add(this.lbMin);
            this.gbBuscar.Controls.Add(this.lbMax);
            this.gbBuscar.Controls.Add(this.nudMinPrice);
            this.gbBuscar.Controls.Add(this.nudMaxPrice);
            this.gbBuscar.Controls.Add(this.lbDestino);
            this.gbBuscar.Controls.Add(this.cbDestinos);
            this.gbBuscar.Controls.Add(this.rbHotel);
            this.gbBuscar.Controls.Add(this.rbCasaFinde);
            this.gbBuscar.Controls.Add(this.rbCasa);
            this.gbBuscar.Controls.Add(this.btnVer);
            this.gbBuscar.Controls.Add(this.btnAlquilar);
            this.gbBuscar.Controls.Add(this.lbResidencias);
            this.gbBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBuscar.Location = new System.Drawing.Point(0, 164);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(746, 360);
            this.gbBuscar.TabIndex = 2;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Búsqueda de Residencias";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(643, 129);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(91, 35);
            this.btnLimpiarFiltros.TabIndex = 20;
            this.btnLimpiarFiltros.Text = "Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // nudCantPersonas
            // 
            this.nudCantPersonas.Location = new System.Drawing.Point(436, 137);
            this.nudCantPersonas.Name = "nudCantPersonas";
            this.nudCantPersonas.Size = new System.Drawing.Size(120, 27);
            this.nudCantPersonas.TabIndex = 19;
            // 
            // lbCantPasajeros
            // 
            this.lbCantPasajeros.AutoSize = true;
            this.lbCantPasajeros.Location = new System.Drawing.Point(330, 142);
            this.lbCantPasajeros.Name = "lbCantPasajeros";
            this.lbCantPasajeros.Size = new System.Drawing.Size(100, 20);
            this.lbCantPasajeros.TabIndex = 18;
            this.lbCantPasajeros.Text = "Cant Personas";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(162, 89);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(50, 20);
            this.lbPrecio.TabIndex = 17;
            this.lbPrecio.Text = "Precio";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(162, 114);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(60, 20);
            this.lbMin.TabIndex = 16;
            this.lbMin.Text = "Minimo";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(162, 142);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(63, 20);
            this.lbMax.TabIndex = 15;
            this.lbMax.Text = "Maximo";
            // 
            // nudMinPrice
            // 
            this.nudMinPrice.Location = new System.Drawing.Point(234, 112);
            this.nudMinPrice.Name = "nudMinPrice";
            this.nudMinPrice.Size = new System.Drawing.Size(66, 27);
            this.nudMinPrice.TabIndex = 14;
            // 
            // nudMaxPrice
            // 
            this.nudMaxPrice.Location = new System.Drawing.Point(234, 138);
            this.nudMaxPrice.Name = "nudMaxPrice";
            this.nudMaxPrice.Size = new System.Drawing.Size(66, 27);
            this.nudMaxPrice.TabIndex = 13;
            // 
            // lbDestino
            // 
            this.lbDestino.AutoSize = true;
            this.lbDestino.Location = new System.Drawing.Point(330, 91);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(66, 20);
            this.lbDestino.TabIndex = 12;
            this.lbDestino.Text = "Destinos";
            // 
            // cbDestinos
            // 
            this.cbDestinos.FormattingEnabled = true;
            this.cbDestinos.Location = new System.Drawing.Point(435, 88);
            this.cbDestinos.Name = "cbDestinos";
            this.cbDestinos.Size = new System.Drawing.Size(121, 28);
            this.cbDestinos.TabIndex = 11;
            // 
            // rbHotel
            // 
            this.rbHotel.AutoSize = true;
            this.rbHotel.Location = new System.Drawing.Point(27, 147);
            this.rbHotel.Name = "rbHotel";
            this.rbHotel.Size = new System.Drawing.Size(64, 24);
            this.rbHotel.TabIndex = 9;
            this.rbHotel.TabStop = true;
            this.rbHotel.Text = "Hotel";
            this.rbHotel.UseVisualStyleBackColor = true;
            // 
            // rbCasaFinde
            // 
            this.rbCasaFinde.AutoSize = true;
            this.rbCasaFinde.Location = new System.Drawing.Point(27, 118);
            this.rbCasaFinde.Name = "rbCasaFinde";
            this.rbCasaFinde.Size = new System.Drawing.Size(94, 24);
            this.rbCasaFinde.TabIndex = 7;
            this.rbCasaFinde.TabStop = true;
            this.rbCasaFinde.Text = "CasaFinde";
            this.rbCasaFinde.UseVisualStyleBackColor = true;
            // 
            // rbCasa
            // 
            this.rbCasa.AutoSize = true;
            this.rbCasa.Location = new System.Drawing.Point(27, 87);
            this.rbCasa.Name = "rbCasa";
            this.rbCasa.Size = new System.Drawing.Size(58, 24);
            this.rbCasa.TabIndex = 6;
            this.rbCasa.TabStop = true;
            this.rbCasa.Text = "Casa";
            this.rbCasa.UseVisualStyleBackColor = true;
            // 
            // btnVerAlquiler
            // 
            this.btnVerAlquiler.Location = new System.Drawing.Point(572, 166);
            this.btnVerAlquiler.Name = "btnVerAlquiler";
            this.btnVerAlquiler.Size = new System.Drawing.Size(162, 30);
            this.btnVerAlquiler.TabIndex = 5;
            this.btnVerAlquiler.Text = "Ver alquiler";
            this.btnVerAlquiler.UseVisualStyleBackColor = true;
            this.btnVerAlquiler.Click += new System.EventHandler(this.btnVerAlquiler_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(643, 94);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(91, 30);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Mostrar Resultados";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.Location = new System.Drawing.Point(12, 312);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(118, 30);
            this.btnAlquilar.TabIndex = 3;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            this.btnAlquilar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbResidencias
            // 
            this.lbResidencias.FormattingEnabled = true;
            this.lbResidencias.ItemHeight = 20;
            this.lbResidencias.Location = new System.Drawing.Point(6, 202);
            this.lbResidencias.Name = "lbResidencias";
            this.lbResidencias.Size = new System.Drawing.Size(740, 104);
            this.lbResidencias.TabIndex = 1;
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 587);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.gbResidencias);
            this.Controls.Add(this.gbDatos);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 360);
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa de Alquileres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            this.tlpBotonesPropiedades.ResumeLayout(false);
            this.gbResidencias.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpBotonesAgregar.ResumeLayout(false);
            this.tlpBotonesDatos.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.Button btnAgregarCasa;
        private System.Windows.Forms.Button btnAgregarHotel;
        private System.Windows.Forms.Button btnBorrarPropiedad;
        private System.Windows.Forms.Button btnModificarPropiedad;
        private System.Windows.Forms.Button btnVerPropiedad;
		private System.Windows.Forms.Button btnImportar;
		private System.Windows.Forms.Button btnExportar;
		private System.Windows.Forms.OpenFileDialog ofdDatos;
		private System.Windows.Forms.SaveFileDialog sfdDatos;
		private System.Windows.Forms.TableLayoutPanel tlpBotonesPropiedades;
		private System.Windows.Forms.GroupBox gbResidencias;
		private System.Windows.Forms.TableLayoutPanel tlpBotonesDatos;
		private System.Windows.Forms.GroupBox gbDatos;
		private System.Windows.Forms.TableLayoutPanel tlpBotonesAgregar;
		private System.Windows.Forms.ComboBox cmbResidencias;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox gbBuscar;
		private System.Windows.Forms.ListBox lbResidencias;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnVerAlquiler;
        private System.Windows.Forms.RadioButton rbHotel;
        private System.Windows.Forms.RadioButton rbCasaFinde;
        private System.Windows.Forms.RadioButton rbCasa;
        private System.Windows.Forms.Label lbDestino;
        private System.Windows.Forms.ComboBox cbDestinos;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.NumericUpDown nudMinPrice;
        private System.Windows.Forms.NumericUpDown nudMaxPrice;
        private System.Windows.Forms.NumericUpDown nudCantPersonas;
        private System.Windows.Forms.Label lbCantPasajeros;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Button btnLimpiarFiltros;
    }
}

