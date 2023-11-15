
namespace tp2
{
    partial class FCasa
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
			this.tbDirección = new System.Windows.Forms.TextBox();
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
			this.nudNroResidencia = new System.Windows.Forms.NumericUpDown();
			this.btnCrear = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAgregarImágen = new System.Windows.Forms.Button();
			this.tlpTipoCasa = new System.Windows.Forms.TableLayoutPanel();
			this.gbMinDías = new System.Windows.Forms.GroupBox();
			this.gbCantCamas = new System.Windows.Forms.GroupBox();
			this.gbServicios = new System.Windows.Forms.GroupBox();
			this.tlpServicios = new System.Windows.Forms.TableLayoutPanel();
			this.gbPropietario = new System.Windows.Forms.GroupBox();
			this.tlpPropietario = new System.Windows.Forms.TableLayoutPanel();
			this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
			this.gbDatos = new System.Windows.Forms.GroupBox();
			this.tlpDatosBásicos = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tlpCamasDías = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.nudMinDias)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantCamas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDNI)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNroResidencia)).BeginInit();
			this.tlpTipoCasa.SuspendLayout();
			this.gbMinDías.SuspendLayout();
			this.gbCantCamas.SuspendLayout();
			this.gbServicios.SuspendLayout();
			this.tlpServicios.SuspendLayout();
			this.gbPropietario.SuspendLayout();
			this.tlpPropietario.SuspendLayout();
			this.tlpBotones.SuspendLayout();
			this.gbDatos.SuspendLayout();
			this.tlpDatosBásicos.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tlpCamasDías.SuspendLayout();
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
			this.nudMinDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.nudMinDias.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudMinDias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudMinDias.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.nudMinDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.nudMinDias.Location = new System.Drawing.Point(8, 20);
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
			this.nudMinDias.Size = new System.Drawing.Size(177, 23);
			this.nudMinDias.TabIndex = 0;
			this.nudMinDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudMinDias.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
			this.nudMinDias.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
			// 
			// nudCantCamas
			// 
			this.nudCantCamas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.nudCantCamas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudCantCamas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudCantCamas.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.nudCantCamas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.nudCantCamas.Location = new System.Drawing.Point(8, 20);
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
			this.nudCantCamas.Size = new System.Drawing.Size(177, 23);
			this.nudCantCamas.TabIndex = 0;
			this.nudCantCamas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudCantCamas.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
			this.nudCantCamas.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
			// 
			// chbPileta
			// 
			this.chbPileta.AutoSize = true;
			this.chbPileta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.chbPileta.Location = new System.Drawing.Point(4, 2);
			this.chbPileta.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.chbPileta.Name = "chbPileta";
			this.chbPileta.Size = new System.Drawing.Size(65, 24);
			this.chbPileta.TabIndex = 0;
			this.chbPileta.Text = "Pileta";
			this.chbPileta.UseVisualStyleBackColor = true;
			// 
			// chbGarage
			// 
			this.chbGarage.AutoSize = true;
			this.chbGarage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.chbGarage.Location = new System.Drawing.Point(4, 32);
			this.chbGarage.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.chbGarage.Name = "chbGarage";
			this.chbGarage.Size = new System.Drawing.Size(76, 24);
			this.chbGarage.TabIndex = 3;
			this.chbGarage.Text = "Garage";
			this.chbGarage.UseVisualStyleBackColor = true;
			// 
			// chbWIFI
			// 
			this.chbWIFI.AutoSize = true;
			this.chbWIFI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.chbWIFI.Location = new System.Drawing.Point(119, 2);
			this.chbWIFI.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.chbWIFI.Name = "chbWIFI";
			this.chbWIFI.Size = new System.Drawing.Size(57, 24);
			this.chbWIFI.TabIndex = 1;
			this.chbWIFI.Text = "WIFI";
			this.chbWIFI.UseVisualStyleBackColor = true;
			// 
			// chbPermiteMascotas
			// 
			this.chbPermiteMascotas.AutoSize = true;
			this.chbPermiteMascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.chbPermiteMascotas.Location = new System.Drawing.Point(119, 32);
			this.chbPermiteMascotas.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.chbPermiteMascotas.Name = "chbPermiteMascotas";
			this.chbPermiteMascotas.Size = new System.Drawing.Size(144, 24);
			this.chbPermiteMascotas.TabIndex = 4;
			this.chbPermiteMascotas.Text = "Permite Mascotas";
			this.chbPermiteMascotas.UseVisualStyleBackColor = true;
			// 
			// chbLimpieza
			// 
			this.chbLimpieza.AutoSize = true;
			this.chbLimpieza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.chbLimpieza.Location = new System.Drawing.Point(273, 2);
			this.chbLimpieza.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.chbLimpieza.Name = "chbLimpieza";
			this.chbLimpieza.Size = new System.Drawing.Size(88, 24);
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
			this.lbDirec.Size = new System.Drawing.Size(72, 26);
			this.lbDirec.TabIndex = 17;
			this.lbDirec.Text = "Direccion";
			// 
			// tbDirección
			// 
			this.tbDirección.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.tbDirección.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbDirección.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbDirección.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.tbDirección.Location = new System.Drawing.Point(84, 9);
			this.tbDirección.Margin = new System.Windows.Forms.Padding(4, 9, 4, 5);
			this.tbDirección.MaxLength = 28;
			this.tbDirección.Name = "tbDirección";
			this.tbDirección.Size = new System.Drawing.Size(188, 20);
			this.tbDirección.TabIndex = 0;
			this.tbDirección.Click += new System.EventHandler(this.SeleccionarTextBox);
			this.tbDirección.Enter += new System.EventHandler(this.SeleccionarTextBox);
			// 
			// chbDesayuno
			// 
			this.chbDesayuno.AutoSize = true;
			this.chbDesayuno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.chbDesayuno.Location = new System.Drawing.Point(273, 32);
			this.chbDesayuno.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.chbDesayuno.Name = "chbDesayuno";
			this.chbDesayuno.Size = new System.Drawing.Size(93, 24);
			this.chbDesayuno.TabIndex = 5;
			this.chbDesayuno.Text = "Desayuno";
			this.chbDesayuno.UseVisualStyleBackColor = true;
			// 
			// tbApellido
			// 
			this.tbApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.tbApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbApellido.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.tbApellido.Location = new System.Drawing.Point(82, 45);
			this.tbApellido.Margin = new System.Windows.Forms.Padding(4, 9, 4, 5);
			this.tbApellido.MaxLength = 16;
			this.tbApellido.Name = "tbApellido";
			this.tbApellido.Size = new System.Drawing.Size(306, 20);
			this.tbApellido.TabIndex = 1;
			this.tbApellido.Click += new System.EventHandler(this.SeleccionarTextBox);
			this.tbApellido.Enter += new System.EventHandler(this.SeleccionarTextBox);
			// 
			// lbDNI
			// 
			this.lbDNI.AutoSize = true;
			this.lbDNI.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.lbDNI.Location = new System.Drawing.Point(4, 8);
			this.lbDNI.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.lbDNI.Name = "lbDNI";
			this.lbDNI.Size = new System.Drawing.Size(70, 20);
			this.lbDNI.TabIndex = 21;
			this.lbDNI.Text = "DNI";
			// 
			// nudDNI
			// 
			this.nudDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.nudDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudDNI.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.nudDNI.Location = new System.Drawing.Point(82, 8);
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
			this.nudDNI.Size = new System.Drawing.Size(306, 23);
			this.nudDNI.TabIndex = 0;
			this.nudDNI.ThousandsSeparator = true;
			this.nudDNI.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.nudDNI.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
			this.nudDNI.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
			// 
			// tbNombre
			// 
			this.tbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbNombre.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.tbNombre.Location = new System.Drawing.Point(82, 81);
			this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 9, 4, 5);
			this.tbNombre.MaxLength = 16;
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(306, 20);
			this.tbNombre.TabIndex = 2;
			this.tbNombre.Click += new System.EventHandler(this.SeleccionarTextBox);
			this.tbNombre.Enter += new System.EventHandler(this.SeleccionarTextBox);
			// 
			// nudTel
			// 
			this.nudTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.nudTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudTel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.nudTel.Location = new System.Drawing.Point(82, 116);
			this.nudTel.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
			this.nudTel.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
			this.nudTel.Name = "nudTel";
			this.nudTel.Size = new System.Drawing.Size(306, 23);
			this.nudTel.TabIndex = 3;
			this.nudTel.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
			this.nudTel.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
			// 
			// lbApellido
			// 
			this.lbApellido.AutoSize = true;
			this.lbApellido.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.lbApellido.Location = new System.Drawing.Point(4, 44);
			this.lbApellido.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.lbApellido.Name = "lbApellido";
			this.lbApellido.Size = new System.Drawing.Size(70, 20);
			this.lbApellido.TabIndex = 26;
			this.lbApellido.Text = "Apellido";
			// 
			// lbNombres
			// 
			this.lbNombres.AutoSize = true;
			this.lbNombres.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.lbNombres.Location = new System.Drawing.Point(4, 80);
			this.lbNombres.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.lbNombres.Name = "lbNombres";
			this.lbNombres.Size = new System.Drawing.Size(70, 20);
			this.lbNombres.TabIndex = 27;
			this.lbNombres.Text = "Nombres";
			// 
			// lbTel
			// 
			this.lbTel.AutoSize = true;
			this.lbTel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.lbTel.Location = new System.Drawing.Point(4, 116);
			this.lbTel.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.lbTel.Name = "lbTel";
			this.lbTel.Size = new System.Drawing.Size(70, 23);
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
			this.lbNum.Size = new System.Drawing.Size(37, 26);
			this.lbNum.TabIndex = 29;
			this.lbNum.Text = "Nro.";
			// 
			// nudNroResidencia
			// 
			this.nudNroResidencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
			this.nudNroResidencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nudNroResidencia.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudNroResidencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.nudNroResidencia.Location = new System.Drawing.Point(325, 8);
			this.nudNroResidencia.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
			this.nudNroResidencia.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
			this.nudNroResidencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudNroResidencia.Name = "nudNroResidencia";
			this.nudNroResidencia.Size = new System.Drawing.Size(57, 23);
			this.nudNroResidencia.TabIndex = 1;
			this.nudNroResidencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudNroResidencia.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
			this.nudNroResidencia.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
			// 
			// btnCrear
			// 
			this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
			this.btnCrear.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnCrear.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCrear.FlatAppearance.BorderSize = 0;
			this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCrear.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
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
			this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
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
			this.btnAgregarImágen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(72)))));
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
			this.gbMinDías.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.gbMinDías.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
			this.gbMinDías.Location = new System.Drawing.Point(205, 5);
			this.gbMinDías.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbMinDías.Name = "gbMinDías";
			this.gbMinDías.Padding = new System.Windows.Forms.Padding(8, 6, 8, 5);
			this.gbMinDías.Size = new System.Drawing.Size(193, 54);
			this.gbMinDías.TabIndex = 1;
			this.gbMinDías.TabStop = false;
			this.gbMinDías.Text = "MÍNIMO DE DÍAS";
			// 
			// gbCantCamas
			// 
			this.gbCantCamas.Controls.Add(this.nudCantCamas);
			this.gbCantCamas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbCantCamas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.gbCantCamas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
			this.gbCantCamas.Location = new System.Drawing.Point(4, 5);
			this.gbCantCamas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbCantCamas.Name = "gbCantCamas";
			this.gbCantCamas.Padding = new System.Windows.Forms.Padding(8, 6, 8, 5);
			this.gbCantCamas.Size = new System.Drawing.Size(193, 54);
			this.gbCantCamas.TabIndex = 0;
			this.gbCantCamas.TabStop = false;
			this.gbCantCamas.Text = "CAMAS";
			// 
			// gbServicios
			// 
			this.gbServicios.Controls.Add(this.tlpServicios);
			this.gbServicios.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.gbServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
			this.gbServicios.Location = new System.Drawing.Point(16, 347);
			this.gbServicios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbServicios.Name = "gbServicios";
			this.gbServicios.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
			this.gbServicios.Size = new System.Drawing.Size(402, 84);
			this.gbServicios.TabIndex = 4;
			this.gbServicios.TabStop = false;
			this.gbServicios.Text = "SERVICIOS";
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
			this.tlpServicios.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tlpServicios.Location = new System.Drawing.Point(8, 19);
			this.tlpServicios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tlpServicios.Name = "tlpServicios";
			this.tlpServicios.RowCount = 2;
			this.tlpServicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpServicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpServicios.Size = new System.Drawing.Size(386, 60);
			this.tlpServicios.TabIndex = 0;
			// 
			// gbPropietario
			// 
			this.gbPropietario.Controls.Add(this.tlpPropietario);
			this.gbPropietario.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.gbPropietario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
			this.gbPropietario.Location = new System.Drawing.Point(16, 115);
			this.gbPropietario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbPropietario.Name = "gbPropietario";
			this.gbPropietario.Padding = new System.Windows.Forms.Padding(5, 2, 5, 5);
			this.gbPropietario.Size = new System.Drawing.Size(402, 168);
			this.gbPropietario.TabIndex = 2;
			this.gbPropietario.TabStop = false;
			this.gbPropietario.Text = "PROPIETARIO";
			// 
			// tlpPropietario
			// 
			this.tlpPropietario.ColumnCount = 2;
			this.tlpPropietario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpPropietario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpPropietario.Controls.Add(this.lbDNI, 0, 0);
			this.tlpPropietario.Controls.Add(this.nudTel, 1, 3);
			this.tlpPropietario.Controls.Add(this.tbNombre, 1, 2);
			this.tlpPropietario.Controls.Add(this.lbTel, 0, 3);
			this.tlpPropietario.Controls.Add(this.tbApellido, 1, 1);
			this.tlpPropietario.Controls.Add(this.nudDNI, 1, 0);
			this.tlpPropietario.Controls.Add(this.lbNombres, 0, 2);
			this.tlpPropietario.Controls.Add(this.lbApellido, 0, 1);
			this.tlpPropietario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpPropietario.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tlpPropietario.Location = new System.Drawing.Point(5, 16);
			this.tlpPropietario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tlpPropietario.Name = "tlpPropietario";
			this.tlpPropietario.RowCount = 4;
			this.tlpPropietario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpPropietario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpPropietario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpPropietario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpPropietario.Size = new System.Drawing.Size(392, 147);
			this.tlpPropietario.TabIndex = 0;
			// 
			// tlpBotones
			// 
			this.tlpBotones.ColumnCount = 3;
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tlpBotones.Controls.Add(this.btnCrear, 0, 0);
			this.tlpBotones.Controls.Add(this.btnCancelar, 2, 0);
			this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tlpBotones.Location = new System.Drawing.Point(16, 473);
			this.tlpBotones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tlpBotones.Name = "tlpBotones";
			this.tlpBotones.RowCount = 1;
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpBotones.Size = new System.Drawing.Size(402, 42);
			this.tlpBotones.TabIndex = 5;
			// 
			// gbDatos
			// 
			this.gbDatos.Controls.Add(this.tlpDatosBásicos);
			this.gbDatos.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.gbDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
			this.gbDatos.Location = new System.Drawing.Point(16, 18);
			this.gbDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbDatos.Name = "gbDatos";
			this.gbDatos.Padding = new System.Windows.Forms.Padding(8, 2, 8, 5);
			this.gbDatos.Size = new System.Drawing.Size(402, 63);
			this.gbDatos.TabIndex = 0;
			this.gbDatos.TabStop = false;
			this.gbDatos.Text = "DATOS BÁSICOS";
			// 
			// tlpDatosBásicos
			// 
			this.tlpDatosBásicos.ColumnCount = 4;
			this.tlpDatosBásicos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpDatosBásicos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.19084F));
			this.tlpDatosBásicos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpDatosBásicos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.80916F));
			this.tlpDatosBásicos.Controls.Add(this.tbDirección, 1, 0);
			this.tlpDatosBásicos.Controls.Add(this.lbDirec, 0, 0);
			this.tlpDatosBásicos.Controls.Add(this.lbNum, 2, 0);
			this.tlpDatosBásicos.Controls.Add(this.nudNroResidencia, 3, 0);
			this.tlpDatosBásicos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpDatosBásicos.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tlpDatosBásicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.tlpDatosBásicos.Location = new System.Drawing.Point(8, 16);
			this.tlpDatosBásicos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tlpDatosBásicos.Name = "tlpDatosBásicos";
			this.tlpDatosBásicos.RowCount = 1;
			this.tlpDatosBásicos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpDatosBásicos.Size = new System.Drawing.Size(386, 42);
			this.tlpDatosBásicos.TabIndex = 0;
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
			// tlpCamasDías
			// 
			this.tlpCamasDías.AutoSize = true;
			this.tlpCamasDías.ColumnCount = 2;
			this.tlpCamasDías.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCamasDías.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCamasDías.Controls.Add(this.gbMinDías, 1, 0);
			this.tlpCamasDías.Controls.Add(this.gbCantCamas, 0, 0);
			this.tlpCamasDías.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlpCamasDías.Location = new System.Drawing.Point(16, 283);
			this.tlpCamasDías.Name = "tlpCamasDías";
			this.tlpCamasDías.RowCount = 1;
			this.tlpCamasDías.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCamasDías.Size = new System.Drawing.Size(402, 64);
			this.tlpCamasDías.TabIndex = 3;
			// 
			// FCasa
			// 
			this.AcceptButton = this.btnCrear;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
			this.CancelButton = this.btnCancelar;
			this.ClientSize = new System.Drawing.Size(434, 533);
			this.Controls.Add(this.gbServicios);
			this.Controls.Add(this.tlpCamasDías);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tlpBotones);
			this.Controls.Add(this.gbPropietario);
			this.Controls.Add(this.tlpTipoCasa);
			this.Controls.Add(this.gbDatos);
			this.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(450, 572);
			this.Name = "FCasa";
			this.Padding = new System.Windows.Forms.Padding(16, 18, 16, 18);
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Casa";
			this.Load += new System.EventHandler(this.FAgregarCasa_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudMinDias)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantCamas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDNI)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNroResidencia)).EndInit();
			this.tlpTipoCasa.ResumeLayout(false);
			this.tlpTipoCasa.PerformLayout();
			this.gbMinDías.ResumeLayout(false);
			this.gbCantCamas.ResumeLayout(false);
			this.gbServicios.ResumeLayout(false);
			this.tlpServicios.ResumeLayout(false);
			this.tlpServicios.PerformLayout();
			this.gbPropietario.ResumeLayout(false);
			this.tlpPropietario.ResumeLayout(false);
			this.tlpPropietario.PerformLayout();
			this.tlpBotones.ResumeLayout(false);
			this.gbDatos.ResumeLayout(false);
			this.tlpDatosBásicos.ResumeLayout(false);
			this.tlpDatosBásicos.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.tlpCamasDías.ResumeLayout(false);
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
        public System.Windows.Forms.TextBox tbDirección;
        public System.Windows.Forms.TextBox tbApellido;
        public System.Windows.Forms.NumericUpDown nudDNI;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.NumericUpDown nudTel;
        public System.Windows.Forms.NumericUpDown nudNroResidencia;
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
		private System.Windows.Forms.TableLayoutPanel tlpBotones;
		private System.Windows.Forms.GroupBox gbDatos;
		private System.Windows.Forms.TableLayoutPanel tlpDatosBásicos;
		private System.Windows.Forms.TableLayoutPanel tlpPropietario;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tlpCamasDías;
	}
}