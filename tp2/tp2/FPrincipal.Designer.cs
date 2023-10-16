
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
			this.button1 = new System.Windows.Forms.Button();
			this.btnAgregarCasa = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btnAlquilar = new System.Windows.Forms.Button();
			this.btnCancelarAlquiler = new System.Windows.Forms.Button();
			this.gbAlquileres = new System.Windows.Forms.GroupBox();
			this.gbReservaNueva = new System.Windows.Forms.GroupBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lblNroAlquiler = new System.Windows.Forms.Label();
			this.nudNroAlquiler = new System.Windows.Forms.NumericUpDown();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tbDirección = new System.Windows.Forms.TextBox();
			this.lblDirección = new System.Windows.Forms.Label();
			this.gbServicios = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cbMascotas = new System.Windows.Forms.CheckBox();
			this.cbCochera = new System.Windows.Forms.CheckBox();
			this.cbDesayuno = new System.Windows.Forms.CheckBox();
			this.cbPileta = new System.Windows.Forms.CheckBox();
			this.cbLimpieza = new System.Windows.Forms.CheckBox();
			this.cbWifi = new System.Windows.Forms.CheckBox();
			this.gbPropiedades = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnElegirImagen = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.nudMaxPasajeros = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.nudNroPropiedad = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.ofdElegirImagen = new System.Windows.Forms.OpenFileDialog();
			this.gbAlquileres.SuspendLayout();
			this.gbReservaNueva.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNroAlquiler)).BeginInit();
			this.tableLayoutPanel3.SuspendLayout();
			this.gbServicios.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.gbPropiedades.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxPasajeros)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNroPropiedad)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button1.Location = new System.Drawing.Point(248, 5);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 50);
			this.button1.TabIndex = 2;
			this.button1.Text = "Agregar Hotel";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnAgregarCasa
			// 
			this.btnAgregarCasa.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAgregarCasa.Location = new System.Drawing.Point(126, 5);
			this.btnAgregarCasa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAgregarCasa.Name = "btnAgregarCasa";
			this.btnAgregarCasa.Size = new System.Drawing.Size(114, 50);
			this.btnAgregarCasa.TabIndex = 1;
			this.btnAgregarCasa.Text = "Agregar Casa";
			this.btnAgregarCasa.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button3.Location = new System.Drawing.Point(4, 4);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(113, 33);
			this.button3.TabIndex = 0;
			this.button3.Text = "Consultar";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// btnAlquilar
			// 
			this.btnAlquilar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAlquilar.Location = new System.Drawing.Point(4, 86);
			this.btnAlquilar.Margin = new System.Windows.Forms.Padding(4);
			this.btnAlquilar.Name = "btnAlquilar";
			this.btnAlquilar.Size = new System.Drawing.Size(113, 34);
			this.btnAlquilar.TabIndex = 2;
			this.btnAlquilar.Text = "Alquilar";
			this.btnAlquilar.UseVisualStyleBackColor = true;
			// 
			// btnCancelarAlquiler
			// 
			this.btnCancelarAlquiler.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCancelarAlquiler.Location = new System.Drawing.Point(4, 45);
			this.btnCancelarAlquiler.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancelarAlquiler.Name = "btnCancelarAlquiler";
			this.btnCancelarAlquiler.Size = new System.Drawing.Size(113, 33);
			this.btnCancelarAlquiler.TabIndex = 1;
			this.btnCancelarAlquiler.Text = "Cancelar";
			this.btnCancelarAlquiler.UseVisualStyleBackColor = true;
			// 
			// gbAlquileres
			// 
			this.gbAlquileres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbAlquileres.Controls.Add(this.gbReservaNueva);
			this.gbAlquileres.Controls.Add(this.panel4);
			this.gbAlquileres.Controls.Add(this.tableLayoutPanel3);
			this.gbAlquileres.Location = new System.Drawing.Point(16, 281);
			this.gbAlquileres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbAlquileres.Name = "gbAlquileres";
			this.gbAlquileres.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbAlquileres.Size = new System.Drawing.Size(494, 154);
			this.gbAlquileres.TabIndex = 1;
			this.gbAlquileres.TabStop = false;
			this.gbAlquileres.Text = "Alquileres";
			// 
			// gbReservaNueva
			// 
			this.gbReservaNueva.Controls.Add(this.dateTimePicker1);
			this.gbReservaNueva.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbReservaNueva.Location = new System.Drawing.Point(4, 71);
			this.gbReservaNueva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbReservaNueva.Name = "gbReservaNueva";
			this.gbReservaNueva.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbReservaNueva.Size = new System.Drawing.Size(365, 78);
			this.gbReservaNueva.TabIndex = 1;
			this.gbReservaNueva.TabStop = false;
			this.gbReservaNueva.Text = "Reserva Nueva";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker1.CustomFormat = "dd/MM/YYYY HH:mm";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(8, 30);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(349, 27);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.lblNroAlquiler);
			this.panel4.Controls.Add(this.nudNroAlquiler);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(4, 25);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(365, 46);
			this.panel4.TabIndex = 0;
			// 
			// lblNroAlquiler
			// 
			this.lblNroAlquiler.AutoSize = true;
			this.lblNroAlquiler.Location = new System.Drawing.Point(4, 7);
			this.lblNroAlquiler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNroAlquiler.Name = "lblNroAlquiler";
			this.lblNroAlquiler.Size = new System.Drawing.Size(93, 20);
			this.lblNroAlquiler.TabIndex = 4;
			this.lblNroAlquiler.Text = "Nro. Alquiler";
			// 
			// nudNroAlquiler
			// 
			this.nudNroAlquiler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudNroAlquiler.Location = new System.Drawing.Point(105, 5);
			this.nudNroAlquiler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudNroAlquiler.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.nudNroAlquiler.Name = "nudNroAlquiler";
			this.nudNroAlquiler.Size = new System.Drawing.Size(252, 27);
			this.nudNroAlquiler.TabIndex = 0;
			this.nudNroAlquiler.ThousandsSeparator = true;
			this.nudNroAlquiler.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
			this.nudNroAlquiler.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.button3, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnCancelarAlquiler, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.btnAlquilar, 0, 2);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(369, 25);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(121, 124);
			this.tableLayoutPanel3.TabIndex = 2;
			// 
			// tbDirección
			// 
			this.tbDirección.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbDirección.Location = new System.Drawing.Point(108, 5);
			this.tbDirección.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbDirección.Name = "tbDirección";
			this.tbDirección.Size = new System.Drawing.Size(252, 27);
			this.tbDirección.TabIndex = 0;
			this.tbDirección.Click += new System.EventHandler(this.SeleccionarTextBox);
			this.tbDirección.Enter += new System.EventHandler(this.SeleccionarTextBox);
			// 
			// lblDirección
			// 
			this.lblDirección.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblDirección.Location = new System.Drawing.Point(3, 5);
			this.lblDirección.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDirección.Name = "lblDirección";
			this.lblDirección.Size = new System.Drawing.Size(105, 30);
			this.lblDirección.TabIndex = 4;
			this.lblDirección.Text = "Dirección";
			this.lblDirección.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gbServicios
			// 
			this.gbServicios.Controls.Add(this.tableLayoutPanel1);
			this.gbServicios.Dock = System.Windows.Forms.DockStyle.Right;
			this.gbServicios.Location = new System.Drawing.Point(370, 25);
			this.gbServicios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbServicios.Name = "gbServicios";
			this.gbServicios.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbServicios.Size = new System.Drawing.Size(120, 223);
			this.gbServicios.TabIndex = 3;
			this.gbServicios.TabStop = false;
			this.gbServicios.Text = "Servicios";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.cbMascotas, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.cbCochera, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.cbDesayuno, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.cbPileta, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.cbLimpieza, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.cbWifi, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 25);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(112, 193);
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// cbMascotas
			// 
			this.cbMascotas.AutoSize = true;
			this.cbMascotas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbMascotas.Location = new System.Drawing.Point(4, 165);
			this.cbMascotas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbMascotas.Name = "cbMascotas";
			this.cbMascotas.Size = new System.Drawing.Size(104, 23);
			this.cbMascotas.TabIndex = 5;
			this.cbMascotas.Text = "Mascotas";
			this.cbMascotas.UseVisualStyleBackColor = true;
			// 
			// cbCochera
			// 
			this.cbCochera.AutoSize = true;
			this.cbCochera.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbCochera.Location = new System.Drawing.Point(4, 5);
			this.cbCochera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbCochera.Name = "cbCochera";
			this.cbCochera.Size = new System.Drawing.Size(104, 22);
			this.cbCochera.TabIndex = 0;
			this.cbCochera.Text = "Cochera";
			this.cbCochera.UseVisualStyleBackColor = true;
			// 
			// cbDesayuno
			// 
			this.cbDesayuno.AutoSize = true;
			this.cbDesayuno.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbDesayuno.Location = new System.Drawing.Point(4, 133);
			this.cbDesayuno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbDesayuno.Name = "cbDesayuno";
			this.cbDesayuno.Size = new System.Drawing.Size(104, 22);
			this.cbDesayuno.TabIndex = 4;
			this.cbDesayuno.Text = "Desayuno";
			this.cbDesayuno.UseVisualStyleBackColor = true;
			// 
			// cbPileta
			// 
			this.cbPileta.AutoSize = true;
			this.cbPileta.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbPileta.Location = new System.Drawing.Point(4, 37);
			this.cbPileta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbPileta.Name = "cbPileta";
			this.cbPileta.Size = new System.Drawing.Size(104, 22);
			this.cbPileta.TabIndex = 1;
			this.cbPileta.Text = "Pileta";
			this.cbPileta.UseVisualStyleBackColor = true;
			// 
			// cbLimpieza
			// 
			this.cbLimpieza.AutoSize = true;
			this.cbLimpieza.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbLimpieza.Location = new System.Drawing.Point(4, 101);
			this.cbLimpieza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbLimpieza.Name = "cbLimpieza";
			this.cbLimpieza.Size = new System.Drawing.Size(104, 22);
			this.cbLimpieza.TabIndex = 3;
			this.cbLimpieza.Text = "Limpieza";
			this.cbLimpieza.UseVisualStyleBackColor = true;
			// 
			// cbWifi
			// 
			this.cbWifi.AutoSize = true;
			this.cbWifi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbWifi.Location = new System.Drawing.Point(4, 69);
			this.cbWifi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbWifi.Name = "cbWifi";
			this.cbWifi.Size = new System.Drawing.Size(104, 22);
			this.cbWifi.TabIndex = 2;
			this.cbWifi.Text = "WI-FI";
			this.cbWifi.UseVisualStyleBackColor = true;
			// 
			// gbPropiedades
			// 
			this.gbPropiedades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbPropiedades.Controls.Add(this.tableLayoutPanel2);
			this.gbPropiedades.Controls.Add(this.panel1);
			this.gbPropiedades.Controls.Add(this.panel2);
			this.gbPropiedades.Controls.Add(this.panel3);
			this.gbPropiedades.Controls.Add(this.gbServicios);
			this.gbPropiedades.Location = new System.Drawing.Point(16, 18);
			this.gbPropiedades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbPropiedades.Name = "gbPropiedades";
			this.gbPropiedades.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbPropiedades.Size = new System.Drawing.Size(494, 253);
			this.gbPropiedades.TabIndex = 0;
			this.gbPropiedades.TabStop = false;
			this.gbPropiedades.Text = "Propiedades";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.btnElegirImagen, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnAgregarCasa, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 188);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(366, 60);
			this.tableLayoutPanel2.TabIndex = 4;
			// 
			// btnElegirImagen
			// 
			this.btnElegirImagen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnElegirImagen.Location = new System.Drawing.Point(4, 5);
			this.btnElegirImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnElegirImagen.Name = "btnElegirImagen";
			this.btnElegirImagen.Size = new System.Drawing.Size(114, 50);
			this.btnElegirImagen.TabIndex = 0;
			this.btnElegirImagen.Text = "Elegir Imagen";
			this.btnElegirImagen.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.nudMaxPasajeros);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(4, 127);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(3, 5, 6, 16);
			this.panel1.Size = new System.Drawing.Size(366, 51);
			this.panel1.TabIndex = 2;
			// 
			// nudMaxPasajeros
			// 
			this.nudMaxPasajeros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudMaxPasajeros.Location = new System.Drawing.Point(108, 5);
			this.nudMaxPasajeros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudMaxPasajeros.Name = "nudMaxPasajeros";
			this.nudMaxPasajeros.Size = new System.Drawing.Size(252, 27);
			this.nudMaxPasajeros.TabIndex = 0;
			this.nudMaxPasajeros.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
			this.nudMaxPasajeros.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Left;
			this.label2.Location = new System.Drawing.Point(3, 5);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 30);
			this.label2.TabIndex = 6;
			this.label2.Text = "Máx. Pasajeros";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.nudNroPropiedad);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(4, 76);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(3, 5, 6, 16);
			this.panel2.Size = new System.Drawing.Size(366, 51);
			this.panel2.TabIndex = 1;
			// 
			// nudNroPropiedad
			// 
			this.nudNroPropiedad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudNroPropiedad.Location = new System.Drawing.Point(108, 5);
			this.nudNroPropiedad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudNroPropiedad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.nudNroPropiedad.Name = "nudNroPropiedad";
			this.nudNroPropiedad.Size = new System.Drawing.Size(252, 27);
			this.nudNroPropiedad.TabIndex = 0;
			this.nudNroPropiedad.ThousandsSeparator = true;
			this.nudNroPropiedad.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
			this.nudNroPropiedad.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Location = new System.Drawing.Point(3, 5);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 30);
			this.label1.TabIndex = 6;
			this.label1.Text = "Nro. Propiedad";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.tbDirección);
			this.panel3.Controls.Add(this.lblDirección);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(4, 25);
			this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(3, 5, 6, 16);
			this.panel3.Size = new System.Drawing.Size(366, 51);
			this.panel3.TabIndex = 0;
			// 
			// ofdElegirImagen
			// 
			this.ofdElegirImagen.DefaultExt = "*.png";
			this.ofdElegirImagen.Filter = "Imagen PNG | *.png | Imagen JPG | *.jpg | Todos los archivos | *.*";
			this.ofdElegirImagen.InitialDirectory = ".";
			// 
			// FPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 449);
			this.Controls.Add(this.gbPropiedades);
			this.Controls.Add(this.gbAlquileres);
			this.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(420, 480);
			this.Name = "FPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alquileres";
			this.Load += new System.EventHandler(this.FPrincipal_Load);
			this.gbAlquileres.ResumeLayout(false);
			this.gbReservaNueva.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNroAlquiler)).EndInit();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.gbServicios.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.gbPropiedades.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudMaxPasajeros)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudNroPropiedad)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnAgregarCasa;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnAlquilar;
		private System.Windows.Forms.Button btnCancelarAlquiler;
		private System.Windows.Forms.GroupBox gbAlquileres;
		private System.Windows.Forms.Label lblNroAlquiler;
		private System.Windows.Forms.NumericUpDown nudNroAlquiler;
		private System.Windows.Forms.TextBox tbDirección;
		private System.Windows.Forms.Label lblDirección;
		private System.Windows.Forms.GroupBox gbServicios;
		private System.Windows.Forms.GroupBox gbPropiedades;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.CheckBox cbMascotas;
		private System.Windows.Forms.CheckBox cbCochera;
		private System.Windows.Forms.CheckBox cbDesayuno;
		private System.Windows.Forms.CheckBox cbPileta;
		private System.Windows.Forms.CheckBox cbLimpieza;
		private System.Windows.Forms.CheckBox cbWifi;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudMaxPasajeros;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nudNroPropiedad;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btnElegirImagen;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.GroupBox gbReservaNueva;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.OpenFileDialog ofdElegirImagen;
	}
}

