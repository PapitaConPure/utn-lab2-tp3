
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
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
			this.lsbResidencias = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.pnlTérmino = new System.Windows.Forms.Panel();
			this.cmbTérmino = new System.Windows.Forms.ComboBox();
			this.lblTérmino = new System.Windows.Forms.Label();
			this.tbBúsqueda = new System.Windows.Forms.TextBox();
			this.tlpBotonesPropiedades.SuspendLayout();
			this.gbResidencias.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tlpBotonesAgregar.SuspendLayout();
			this.tlpBotonesDatos.SuspendLayout();
			this.gbDatos.SuspendLayout();
			this.gbBuscar.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.pnlTérmino.SuspendLayout();
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
			this.btnImportar.Size = new System.Drawing.Size(327, 36);
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
			this.btnExportar.Size = new System.Drawing.Size(327, 36);
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
			this.cmbResidencias.Location = new System.Drawing.Point(3, 10);
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
			this.tlpBotonesDatos.Size = new System.Drawing.Size(740, 42);
			this.tlpBotonesDatos.TabIndex = 13;
			// 
			// gbDatos
			// 
			this.gbDatos.Controls.Add(this.tlpBotonesDatos);
			this.gbDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gbDatos.Location = new System.Drawing.Point(0, 417);
			this.gbDatos.Name = "gbDatos";
			this.gbDatos.Size = new System.Drawing.Size(746, 68);
			this.gbDatos.TabIndex = 3;
			this.gbDatos.TabStop = false;
			this.gbDatos.Text = "Datos";
			// 
			// gbBuscar
			// 
			this.gbBuscar.Controls.Add(this.lsbResidencias);
			this.gbBuscar.Controls.Add(this.label1);
			this.gbBuscar.Controls.Add(this.tableLayoutPanel2);
			this.gbBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbBuscar.Location = new System.Drawing.Point(0, 164);
			this.gbBuscar.Name = "gbBuscar";
			this.gbBuscar.Size = new System.Drawing.Size(746, 253);
			this.gbBuscar.TabIndex = 2;
			this.gbBuscar.TabStop = false;
			this.gbBuscar.Text = "Búsqueda de Residencias";
			// 
			// lsbResidencias
			// 
			this.lsbResidencias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsbResidencias.FormattingEnabled = true;
			this.lsbResidencias.ItemHeight = 20;
			this.lsbResidencias.Location = new System.Drawing.Point(3, 146);
			this.lsbResidencias.Name = "lsbResidencias";
			this.lsbResidencias.Size = new System.Drawing.Size(740, 104);
			this.lsbResidencias.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Red;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(740, 88);
			this.label1.TabIndex = 0;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.pnlTérmino, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tbBúsqueda, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(740, 35);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// pnlTérmino
			// 
			this.pnlTérmino.Controls.Add(this.cmbTérmino);
			this.pnlTérmino.Controls.Add(this.lblTérmino);
			this.pnlTérmino.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlTérmino.Location = new System.Drawing.Point(3, 3);
			this.pnlTérmino.Name = "pnlTérmino";
			this.pnlTérmino.Size = new System.Drawing.Size(172, 29);
			this.pnlTérmino.TabIndex = 0;
			// 
			// cmbTérmino
			// 
			this.cmbTérmino.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbTérmino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTérmino.FormattingEnabled = true;
			this.cmbTérmino.Location = new System.Drawing.Point(63, 0);
			this.cmbTérmino.Name = "cmbTérmino";
			this.cmbTérmino.Size = new System.Drawing.Size(109, 28);
			this.cmbTérmino.TabIndex = 0;
			// 
			// lblTérmino
			// 
			this.lblTérmino.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblTérmino.Location = new System.Drawing.Point(0, 0);
			this.lblTérmino.Name = "lblTérmino";
			this.lblTérmino.Size = new System.Drawing.Size(63, 29);
			this.lblTérmino.TabIndex = 4;
			this.lblTérmino.Text = "Término";
			this.lblTérmino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbBúsqueda
			// 
			this.tbBúsqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbBúsqueda.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbBúsqueda.Location = new System.Drawing.Point(181, 3);
			this.tbBúsqueda.Name = "tbBúsqueda";
			this.tbBúsqueda.Size = new System.Drawing.Size(556, 27);
			this.tbBúsqueda.TabIndex = 1;
			// 
			// FPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(746, 485);
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
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.pnlTérmino.ResumeLayout(false);
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbBúsqueda;
		private System.Windows.Forms.ComboBox cmbTérmino;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Panel pnlTérmino;
		private System.Windows.Forms.Label lblTérmino;
		private System.Windows.Forms.ListBox lsbResidencias;
	}
}

