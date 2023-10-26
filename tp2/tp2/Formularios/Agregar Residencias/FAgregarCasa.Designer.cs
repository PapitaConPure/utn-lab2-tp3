
namespace tp2
{
    partial class FAgregarCasa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.rbCasa = new System.Windows.Forms.RadioButton();
			this.rbCasaFinde = new System.Windows.Forms.RadioButton();
			this.nudMinDias = new System.Windows.Forms.NumericUpDown();
			this.nudCantCamas = new System.Windows.Forms.NumericUpDown();
			this.chbPileta = new System.Windows.Forms.CheckBox();
			this.chbGarage = new System.Windows.Forms.CheckBox();
			this.chbWIFI = new System.Windows.Forms.CheckBox();
			this.chbPermiteMascotas = new System.Windows.Forms.CheckBox();
			this.chbLimpieza = new System.Windows.Forms.CheckBox();
			this.lbDirec = new System.Windows.Forms.Label();
			this.tbDireccionCasa = new System.Windows.Forms.TextBox();
			this.chbDesayuno = new System.Windows.Forms.CheckBox();
			this.tbApellido = new System.Windows.Forms.TextBox();
			this.lbDNI = new System.Windows.Forms.Label();
			this.nudDNI = new System.Windows.Forms.NumericUpDown();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.nudTel = new System.Windows.Forms.NumericUpDown();
			this.lbApellido = new System.Windows.Forms.Label();
			this.lbNombres = new System.Windows.Forms.Label();
			this.lbTel = new System.Windows.Forms.Label();
			this.lbNum = new System.Windows.Forms.Label();
			this.nudNroPropiedad = new System.Windows.Forms.NumericUpDown();
			this.btnCrear = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAgregarImágen = new System.Windows.Forms.Button();
			this.tlpTipoCasa = new System.Windows.Forms.TableLayoutPanel();
			this.gbMinDías = new System.Windows.Forms.GroupBox();
			this.gbCantCamas = new System.Windows.Forms.GroupBox();
			this.gbServicios = new System.Windows.Forms.GroupBox();
			this.tlpServicios = new System.Windows.Forms.TableLayoutPanel();
			this.gbPropietario = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.gbDatos = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.nudMinDias)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantCamas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDNI)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNroPropiedad)).BeginInit();
			this.tlpTipoCasa.SuspendLayout();
			this.gbMinDías.SuspendLayout();
			this.gbCantCamas.SuspendLayout();
			this.gbServicios.SuspendLayout();
			this.tlpServicios.SuspendLayout();
			this.gbPropietario.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.gbDatos.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// rbCasa
			// 
			this.rbCasa.AutoSize = true;
			this.rbCasa.Checked = true;
			this.rbCasa.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbCasa.Location = new System.Drawing.Point(12, 5);
			this.rbCasa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbCasa.Name = "rbCasa";
			this.rbCasa.Size = new System.Drawing.Size(160, 24);
			this.rbCasa.TabIndex = 0;
			this.rbCasa.TabStop = true;
			this.rbCasa.Text = "Casa";
			this.rbCasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rbCasa.UseVisualStyleBackColor = true;
			this.rbCasa.CheckedChanged += new System.EventHandler(this.RbCasa_CheckedChanged);
			// 
			// rbCasaFinde
			// 
			this.rbCasaFinde.AutoSize = true;
			this.rbCasaFinde.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rbCasaFinde.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbCasaFinde.Location = new System.Drawing.Point(228, 5);
			this.rbCasaFinde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbCasaFinde.Name = "rbCasaFinde";
			this.rbCasaFinde.Size = new System.Drawing.Size(162, 24);
			this.rbCasaFinde.TabIndex = 1;
			this.rbCasaFinde.TabStop = true;
			this.rbCasaFinde.Text = "Casa Finde";
			this.rbCasaFinde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rbCasaFinde.UseVisualStyleBackColor = true;
			this.rbCasaFinde.CheckedChanged += new System.EventHandler(this.RbCasaFinde_CheckedChanged);
			// 
			// nudMinDias
			// 
			this.nudMinDias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudMinDias.Location = new System.Drawing.Point(8, 22);
			this.nudMinDias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudMinDias.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudMinDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudMinDias.Name = "nudMinDias";
			this.nudMinDias.Size = new System.Drawing.Size(177, 27);
			this.nudMinDias.TabIndex = 0;
			this.nudMinDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// nudCantCamas
			// 
			this.nudCantCamas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudCantCamas.Location = new System.Drawing.Point(8, 22);
			this.nudCantCamas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudCantCamas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudCantCamas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudCantCamas.Name = "nudCantCamas";
			this.nudCantCamas.Size = new System.Drawing.Size(177, 27);
			this.nudCantCamas.TabIndex = 0;
			this.nudCantCamas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// chbPileta
			// 
			this.chbPileta.AutoSize = true;
			this.chbPileta.Location = new System.Drawing.Point(4, 2);
			this.chbPileta.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.chbPileta.Name = "chbPileta";
			this.chbPileta.Size = new System.Drawing.Size(65, 23);
			this.chbPileta.TabIndex = 0;
			this.chbPileta.Text = "Pileta";
			this.chbPileta.UseVisualStyleBackColor = true;
			// 
			// chbGarage
			// 
			this.chbGarage.AutoSize = true;
			this.chbGarage.Location = new System.Drawing.Point(4, 29);
			this.chbGarage.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.chbGarage.Name = "chbGarage";
			this.chbGarage.Size = new System.Drawing.Size(76, 23);
			this.chbGarage.TabIndex = 3;
			this.chbGarage.Text = "Garage";
			this.chbGarage.UseVisualStyleBackColor = true;
			// 
			// chbWIFI
			// 
			this.chbWIFI.AutoSize = true;
			this.chbWIFI.Location = new System.Drawing.Point(119, 2);
			this.chbWIFI.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.chbWIFI.Name = "chbWIFI";
			this.chbWIFI.Size = new System.Drawing.Size(57, 23);
			this.chbWIFI.TabIndex = 1;
			this.chbWIFI.Text = "WIFI";
			this.chbWIFI.UseVisualStyleBackColor = true;
			// 
			// chbPermiteMascotas
			// 
			this.chbPermiteMascotas.AutoSize = true;
			this.chbPermiteMascotas.Location = new System.Drawing.Point(119, 29);
			this.chbPermiteMascotas.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.chbPermiteMascotas.Name = "chbPermiteMascotas";
			this.chbPermiteMascotas.Size = new System.Drawing.Size(144, 23);
			this.chbPermiteMascotas.TabIndex = 4;
			this.chbPermiteMascotas.Text = "Permite Mascotas";
			this.chbPermiteMascotas.UseVisualStyleBackColor = true;
			// 
			// chbLimpieza
			// 
			this.chbLimpieza.AutoSize = true;
			this.chbLimpieza.Location = new System.Drawing.Point(273, 2);
			this.chbLimpieza.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.chbLimpieza.Name = "chbLimpieza";
			this.chbLimpieza.Size = new System.Drawing.Size(88, 23);
			this.chbLimpieza.TabIndex = 2;
			this.chbLimpieza.Text = "Limpieza";
			this.chbLimpieza.UseVisualStyleBackColor = true;
			// 
			// lbDirec
			// 
			this.lbDirec.AutoSize = true;
			this.lbDirec.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbDirec.Location = new System.Drawing.Point(4, 8);
			this.lbDirec.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.lbDirec.Name = "lbDirec";
			this.lbDirec.Size = new System.Drawing.Size(72, 20);
			this.lbDirec.TabIndex = 17;
			this.lbDirec.Text = "Direccion";
			// 
			// tbDireccionCasa
			// 
			this.tbDireccionCasa.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbDireccionCasa.Location = new System.Drawing.Point(84, 5);
			this.tbDireccionCasa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbDireccionCasa.Name = "tbDireccionCasa";
			this.tbDireccionCasa.Size = new System.Drawing.Size(188, 27);
			this.tbDireccionCasa.TabIndex = 0;
			// 
			// chbDesayuno
			// 
			this.chbDesayuno.AutoSize = true;
			this.chbDesayuno.Location = new System.Drawing.Point(273, 29);
			this.chbDesayuno.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.chbDesayuno.Name = "chbDesayuno";
			this.chbDesayuno.Size = new System.Drawing.Size(93, 23);
			this.chbDesayuno.TabIndex = 5;
			this.chbDesayuno.Text = "Desayuno";
			this.chbDesayuno.UseVisualStyleBackColor = true;
			// 
			// tbApellido
			// 
			this.tbApellido.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbApellido.Location = new System.Drawing.Point(82, 40);
			this.tbApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbApellido.Name = "tbApellido";
			this.tbApellido.Size = new System.Drawing.Size(306, 27);
			this.tbApellido.TabIndex = 1;
			// 
			// lbDNI
			// 
			this.lbDNI.AutoSize = true;
			this.lbDNI.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbDNI.Location = new System.Drawing.Point(4, 8);
			this.lbDNI.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.lbDNI.Name = "lbDNI";
			this.lbDNI.Size = new System.Drawing.Size(70, 19);
			this.lbDNI.TabIndex = 21;
			this.lbDNI.Text = "DNI";
			// 
			// nudDNI
			// 
			this.nudDNI.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudDNI.Location = new System.Drawing.Point(82, 5);
			this.nudDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudDNI.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
			this.nudDNI.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudDNI.Name = "nudDNI";
			this.nudDNI.Size = new System.Drawing.Size(306, 27);
			this.nudDNI.TabIndex = 0;
			this.nudDNI.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			// 
			// tbNombre
			// 
			this.tbNombre.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbNombre.Location = new System.Drawing.Point(82, 75);
			this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(306, 27);
			this.tbNombre.TabIndex = 2;
			// 
			// nudTel
			// 
			this.nudTel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudTel.Location = new System.Drawing.Point(82, 110);
			this.nudTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudTel.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
			this.nudTel.Name = "nudTel";
			this.nudTel.Size = new System.Drawing.Size(306, 27);
			this.nudTel.TabIndex = 3;
			// 
			// lbApellido
			// 
			this.lbApellido.AutoSize = true;
			this.lbApellido.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbApellido.Location = new System.Drawing.Point(4, 43);
			this.lbApellido.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.lbApellido.Name = "lbApellido";
			this.lbApellido.Size = new System.Drawing.Size(70, 19);
			this.lbApellido.TabIndex = 26;
			this.lbApellido.Text = "Apellido";
			// 
			// lbNombres
			// 
			this.lbNombres.AutoSize = true;
			this.lbNombres.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbNombres.Location = new System.Drawing.Point(4, 78);
			this.lbNombres.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.lbNombres.Name = "lbNombres";
			this.lbNombres.Size = new System.Drawing.Size(70, 19);
			this.lbNombres.TabIndex = 27;
			this.lbNombres.Text = "Nombres";
			// 
			// lbTel
			// 
			this.lbTel.AutoSize = true;
			this.lbTel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbTel.Location = new System.Drawing.Point(4, 113);
			this.lbTel.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.lbTel.Name = "lbTel";
			this.lbTel.Size = new System.Drawing.Size(70, 20);
			this.lbTel.TabIndex = 28;
			this.lbTel.Text = "Telefono";
			// 
			// lbNum
			// 
			this.lbNum.AutoSize = true;
			this.lbNum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbNum.Location = new System.Drawing.Point(280, 8);
			this.lbNum.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.lbNum.Name = "lbNum";
			this.lbNum.Size = new System.Drawing.Size(37, 20);
			this.lbNum.TabIndex = 29;
			this.lbNum.Text = "Nro.";
			// 
			// nudNroPropiedad
			// 
			this.nudNroPropiedad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudNroPropiedad.Location = new System.Drawing.Point(325, 5);
			this.nudNroPropiedad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudNroPropiedad.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
			this.nudNroPropiedad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudNroPropiedad.Name = "nudNroPropiedad";
			this.nudNroPropiedad.Size = new System.Drawing.Size(57, 27);
			this.nudNroPropiedad.TabIndex = 1;
			this.nudNroPropiedad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnCrear
			// 
			this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(70)))));
			this.btnCrear.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnCrear.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCrear.FlatAppearance.BorderSize = 0;
			this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCrear.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnCrear.Location = new System.Drawing.Point(4, 5);
			this.btnCrear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(172, 32);
			this.btnCrear.TabIndex = 0;
			this.btnCrear.Text = "Aceptar";
			this.btnCrear.UseVisualStyleBackColor = false;
			this.btnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnCancelar.Location = new System.Drawing.Point(224, 5);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(174, 32);
			this.btnCancelar.TabIndex = 1;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			// 
			// btnAgregarImágen
			// 
			this.btnAgregarImágen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
			this.btnAgregarImágen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAgregarImágen.FlatAppearance.BorderSize = 0;
			this.btnAgregarImágen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregarImágen.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnAgregarImágen.Location = new System.Drawing.Point(4, 5);
			this.btnAgregarImágen.Margin = new System.Windows.Forms.Padding(0);
			this.btnAgregarImágen.Name = "btnAgregarImágen";
			this.btnAgregarImágen.Size = new System.Drawing.Size(394, 32);
			this.btnAgregarImágen.TabIndex = 0;
			this.btnAgregarImágen.Text = "Elegir Imágenes";
			this.btnAgregarImágen.UseVisualStyleBackColor = false;
			this.btnAgregarImágen.Click += new System.EventHandler(this.BtnAgregarImagen_Click);
			// 
			// tlpTipoCasa
			// 
			this.tlpTipoCasa.AutoSize = true;
			this.tlpTipoCasa.ColumnCount = 3;
			this.tlpTipoCasa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
			this.tlpTipoCasa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tlpTipoCasa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
			this.tlpTipoCasa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tlpTipoCasa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tlpTipoCasa.Controls.Add(this.rbCasa, 0, 0);
			this.tlpTipoCasa.Controls.Add(this.rbCasaFinde, 2, 0);
			this.tlpTipoCasa.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlpTipoCasa.Location = new System.Drawing.Point(16, 81);
			this.tlpTipoCasa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tlpTipoCasa.Name = "tlpTipoCasa";
			this.tlpTipoCasa.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.tlpTipoCasa.RowCount = 1;
			this.tlpTipoCasa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpTipoCasa.Size = new System.Drawing.Size(402, 34);
			this.tlpTipoCasa.TabIndex = 1;
			// 
			// gbMinDías
			// 
			this.gbMinDías.Controls.Add(this.nudMinDias);
			this.gbMinDías.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbMinDías.Location = new System.Drawing.Point(205, 5);
			this.gbMinDías.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbMinDías.Name = "gbMinDías";
			this.gbMinDías.Padding = new System.Windows.Forms.Padding(8, 2, 8, 5);
			this.gbMinDías.Size = new System.Drawing.Size(193, 54);
			this.gbMinDías.TabIndex = 1;
			this.gbMinDías.TabStop = false;
			this.gbMinDías.Text = "Mínimo de Días";
			// 
			// gbCantCamas
			// 
			this.gbCantCamas.Controls.Add(this.nudCantCamas);
			this.gbCantCamas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbCantCamas.Location = new System.Drawing.Point(4, 5);
			this.gbCantCamas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbCantCamas.Name = "gbCantCamas";
			this.gbCantCamas.Padding = new System.Windows.Forms.Padding(8, 2, 8, 5);
			this.gbCantCamas.Size = new System.Drawing.Size(193, 54);
			this.gbCantCamas.TabIndex = 0;
			this.gbCantCamas.TabStop = false;
			this.gbCantCamas.Text = "Cantidad de Camas";
			// 
			// gbServicios
			// 
			this.gbServicios.Controls.Add(this.tlpServicios);
			this.gbServicios.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbServicios.Location = new System.Drawing.Point(16, 347);
			this.gbServicios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbServicios.Name = "gbServicios";
			this.gbServicios.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
			this.gbServicios.Size = new System.Drawing.Size(402, 84);
			this.gbServicios.TabIndex = 4;
			this.gbServicios.TabStop = false;
			this.gbServicios.Text = "Servicios";
			// 
			// tlpServicios
			// 
			this.tlpServicios.ColumnCount = 3;
			this.tlpServicios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tlpServicios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tlpServicios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tlpServicios.Controls.Add(this.chbPileta, 0, 0);
			this.tlpServicios.Controls.Add(this.chbGarage, 0, 1);
			this.tlpServicios.Controls.Add(this.chbWIFI, 1, 0);
			this.tlpServicios.Controls.Add(this.chbPermiteMascotas, 1, 1);
			this.tlpServicios.Controls.Add(this.chbLimpieza, 2, 0);
			this.tlpServicios.Controls.Add(this.chbDesayuno, 2, 1);
			this.tlpServicios.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpServicios.Location = new System.Drawing.Point(8, 25);
			this.tlpServicios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tlpServicios.Name = "tlpServicios";
			this.tlpServicios.RowCount = 2;
			this.tlpServicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpServicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpServicios.Size = new System.Drawing.Size(386, 54);
			this.tlpServicios.TabIndex = 0;
			// 
			// gbPropietario
			// 
			this.gbPropietario.Controls.Add(this.tableLayoutPanel3);
			this.gbPropietario.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbPropietario.Location = new System.Drawing.Point(16, 115);
			this.gbPropietario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbPropietario.Name = "gbPropietario";
			this.gbPropietario.Padding = new System.Windows.Forms.Padding(5, 2, 5, 5);
			this.gbPropietario.Size = new System.Drawing.Size(402, 168);
			this.gbPropietario.TabIndex = 2;
			this.gbPropietario.TabStop = false;
			this.gbPropietario.Text = "Propietario";
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
			this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 22);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 4;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(392, 141);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel1.Controls.Add(this.btnCrear, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 473);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 42);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// gbDatos
			// 
			this.gbDatos.Controls.Add(this.tableLayoutPanel2);
			this.gbDatos.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbDatos.Location = new System.Drawing.Point(16, 18);
			this.gbDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbDatos.Name = "gbDatos";
			this.gbDatos.Padding = new System.Windows.Forms.Padding(8, 2, 8, 5);
			this.gbDatos.Size = new System.Drawing.Size(402, 63);
			this.gbDatos.TabIndex = 0;
			this.gbDatos.TabStop = false;
			this.gbDatos.Text = "Datos de Residencia";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.19084F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.80916F));
			this.tableLayoutPanel2.Controls.Add(this.tbDireccionCasa, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.lbDirec, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.lbNum, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.nudNroPropiedad, 3, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 22);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(386, 36);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnAgregarImágen);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(16, 431);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Size = new System.Drawing.Size(402, 42);
			this.panel1.TabIndex = 4;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.AutoSize = true;
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.Controls.Add(this.gbMinDías, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.gbCantCamas, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(16, 283);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(402, 64);
			this.tableLayoutPanel4.TabIndex = 3;
			// 
			// FAgregarCasa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 533);
			this.Controls.Add(this.gbServicios);
			this.Controls.Add(this.tableLayoutPanel4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.gbPropietario);
			this.Controls.Add(this.tlpTipoCasa);
			this.Controls.Add(this.gbDatos);
			this.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(450, 572);
			this.Name = "FAgregarCasa";
			this.Padding = new System.Windows.Forms.Padding(16, 18, 16, 18);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Agregar Casa";
			((System.ComponentModel.ISupportInitialize)(this.nudMinDias)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantCamas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDNI)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNroPropiedad)).EndInit();
			this.tlpTipoCasa.ResumeLayout(false);
			this.tlpTipoCasa.PerformLayout();
			this.gbMinDías.ResumeLayout(false);
			this.gbCantCamas.ResumeLayout(false);
			this.gbServicios.ResumeLayout(false);
			this.tlpServicios.ResumeLayout(false);
			this.tlpServicios.PerformLayout();
			this.gbPropietario.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.gbDatos.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDirec;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombres;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.NumericUpDown nudMinDias;
        public System.Windows.Forms.NumericUpDown nudCantCamas;
        public System.Windows.Forms.TextBox tbDireccionCasa;
        public System.Windows.Forms.TextBox tbApellido;
        public System.Windows.Forms.NumericUpDown nudDNI;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.NumericUpDown nudTel;
        public System.Windows.Forms.NumericUpDown nudNroPropiedad;
        public System.Windows.Forms.RadioButton rbCasa;
        public System.Windows.Forms.RadioButton rbCasaFinde;
        public System.Windows.Forms.CheckBox chbPileta;
        public System.Windows.Forms.CheckBox chbGarage;
        public System.Windows.Forms.CheckBox chbWIFI;
        public System.Windows.Forms.CheckBox chbPermiteMascotas;
        public System.Windows.Forms.CheckBox chbLimpieza;
        public System.Windows.Forms.CheckBox chbDesayuno;
        private System.Windows.Forms.Button btnAgregarImágen;
		private System.Windows.Forms.TableLayoutPanel tlpTipoCasa;
		private System.Windows.Forms.GroupBox gbMinDías;
		private System.Windows.Forms.GroupBox gbCantCamas;
		private System.Windows.Forms.GroupBox gbServicios;
		private System.Windows.Forms.TableLayoutPanel tlpServicios;
		private System.Windows.Forms.GroupBox gbPropietario;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox gbDatos;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
	}
}