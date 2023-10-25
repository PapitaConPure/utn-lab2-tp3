
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
            this.lbMinDias = new System.Windows.Forms.Label();
            this.lbCantCamas = new System.Windows.Forms.Label();
            this.nudCantCamas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chbPileta = new System.Windows.Forms.CheckBox();
            this.chbGarage = new System.Windows.Forms.CheckBox();
            this.chbWIFI = new System.Windows.Forms.CheckBox();
            this.chbPermiteMascotas = new System.Windows.Forms.CheckBox();
            this.chbLimpieza = new System.Windows.Forms.CheckBox();
            this.lbDirec = new System.Windows.Forms.Label();
            this.tbDireccionCasa = new System.Windows.Forms.TextBox();
            this.chbDesayuno = new System.Windows.Forms.CheckBox();
            this.lbPropietario = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbDNI = new System.Windows.Forms.Label();
            this.nudDNI = new System.Windows.Forms.NumericUpDown();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.nudTel = new System.Windows.Forms.NumericUpDown();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombres = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.Label();
            this.nudNroPropiedad = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantCamas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroPropiedad)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCasa
            // 
            this.rbCasa.AutoSize = true;
            this.rbCasa.Checked = true;
            this.rbCasa.Location = new System.Drawing.Point(52, 31);
            this.rbCasa.Name = "rbCasa";
            this.rbCasa.Size = new System.Drawing.Size(49, 17);
            this.rbCasa.TabIndex = 0;
            this.rbCasa.TabStop = true;
            this.rbCasa.Text = "Casa";
            this.rbCasa.UseVisualStyleBackColor = true;
            this.rbCasa.CheckedChanged += new System.EventHandler(this.rbCasa_CheckedChanged);
            // 
            // rbCasaFinde
            // 
            this.rbCasaFinde.AutoSize = true;
            this.rbCasaFinde.Location = new System.Drawing.Point(221, 31);
            this.rbCasaFinde.Name = "rbCasaFinde";
            this.rbCasaFinde.Size = new System.Drawing.Size(78, 17);
            this.rbCasaFinde.TabIndex = 1;
            this.rbCasaFinde.TabStop = true;
            this.rbCasaFinde.Text = "Casa Finde";
            this.rbCasaFinde.UseVisualStyleBackColor = true;
            this.rbCasaFinde.CheckedChanged += new System.EventHandler(this.rbCasaFinde_CheckedChanged);
            // 
            // nudMinDias
            // 
            this.nudMinDias.Location = new System.Drawing.Point(179, 76);
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
            this.nudMinDias.Size = new System.Drawing.Size(120, 20);
            this.nudMinDias.TabIndex = 2;
            this.nudMinDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbMinDias
            // 
            this.lbMinDias.AutoSize = true;
            this.lbMinDias.Location = new System.Drawing.Point(49, 78);
            this.lbMinDias.Name = "lbMinDias";
            this.lbMinDias.Size = new System.Drawing.Size(115, 13);
            this.lbMinDias.TabIndex = 3;
            this.lbMinDias.Text = "Minimo de Dias (Casa):";
            // 
            // lbCantCamas
            // 
            this.lbCantCamas.AutoSize = true;
            this.lbCantCamas.Location = new System.Drawing.Point(49, 108);
            this.lbCantCamas.Name = "lbCantCamas";
            this.lbCantCamas.Size = new System.Drawing.Size(67, 13);
            this.lbCantCamas.TabIndex = 7;
            this.lbCantCamas.Text = "Cant Camas:";
            // 
            // nudCantCamas
            // 
            this.nudCantCamas.Location = new System.Drawing.Point(179, 106);
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
            this.nudCantCamas.Size = new System.Drawing.Size(120, 20);
            this.nudCantCamas.TabIndex = 6;
            this.nudCantCamas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Servicios:";
            // 
            // chbPileta
            // 
            this.chbPileta.AutoSize = true;
            this.chbPileta.Location = new System.Drawing.Point(122, 177);
            this.chbPileta.Name = "chbPileta";
            this.chbPileta.Size = new System.Drawing.Size(52, 17);
            this.chbPileta.TabIndex = 12;
            this.chbPileta.Text = "Pileta";
            this.chbPileta.UseVisualStyleBackColor = true;
            // 
            // chbGarage
            // 
            this.chbGarage.AutoSize = true;
            this.chbGarage.Location = new System.Drawing.Point(122, 200);
            this.chbGarage.Name = "chbGarage";
            this.chbGarage.Size = new System.Drawing.Size(61, 17);
            this.chbGarage.TabIndex = 13;
            this.chbGarage.Text = "Garage";
            this.chbGarage.UseVisualStyleBackColor = true;
            // 
            // chbWIFI
            // 
            this.chbWIFI.AutoSize = true;
            this.chbWIFI.Location = new System.Drawing.Point(122, 224);
            this.chbWIFI.Name = "chbWIFI";
            this.chbWIFI.Size = new System.Drawing.Size(49, 17);
            this.chbWIFI.TabIndex = 14;
            this.chbWIFI.Text = "WIFI";
            this.chbWIFI.UseVisualStyleBackColor = true;
            // 
            // chbPermiteMascotas
            // 
            this.chbPermiteMascotas.AutoSize = true;
            this.chbPermiteMascotas.Location = new System.Drawing.Point(206, 177);
            this.chbPermiteMascotas.Name = "chbPermiteMascotas";
            this.chbPermiteMascotas.Size = new System.Drawing.Size(110, 17);
            this.chbPermiteMascotas.TabIndex = 15;
            this.chbPermiteMascotas.Text = "Permite Mascotas";
            this.chbPermiteMascotas.UseVisualStyleBackColor = true;
            // 
            // chbLimpieza
            // 
            this.chbLimpieza.AutoSize = true;
            this.chbLimpieza.Location = new System.Drawing.Point(206, 200);
            this.chbLimpieza.Name = "chbLimpieza";
            this.chbLimpieza.Size = new System.Drawing.Size(67, 17);
            this.chbLimpieza.TabIndex = 16;
            this.chbLimpieza.Text = "Limpieza";
            this.chbLimpieza.UseVisualStyleBackColor = true;
            // 
            // lbDirec
            // 
            this.lbDirec.AutoSize = true;
            this.lbDirec.Location = new System.Drawing.Point(49, 266);
            this.lbDirec.Name = "lbDirec";
            this.lbDirec.Size = new System.Drawing.Size(55, 13);
            this.lbDirec.TabIndex = 17;
            this.lbDirec.Text = "Direccion:";
            // 
            // tbDireccionCasa
            // 
            this.tbDireccionCasa.Location = new System.Drawing.Point(122, 263);
            this.tbDireccionCasa.Name = "tbDireccionCasa";
            this.tbDireccionCasa.Size = new System.Drawing.Size(100, 20);
            this.tbDireccionCasa.TabIndex = 18;
            // 
            // chbDesayuno
            // 
            this.chbDesayuno.AutoSize = true;
            this.chbDesayuno.Location = new System.Drawing.Point(206, 223);
            this.chbDesayuno.Name = "chbDesayuno";
            this.chbDesayuno.Size = new System.Drawing.Size(74, 17);
            this.chbDesayuno.TabIndex = 19;
            this.chbDesayuno.Text = "Desayuno";
            this.chbDesayuno.UseVisualStyleBackColor = true;
            // 
            // lbPropietario
            // 
            this.lbPropietario.AutoSize = true;
            this.lbPropietario.Location = new System.Drawing.Point(3, 323);
            this.lbPropietario.Name = "lbPropietario";
            this.lbPropietario.Size = new System.Drawing.Size(57, 13);
            this.lbPropietario.TabIndex = 20;
            this.lbPropietario.Text = "Propietario";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(122, 392);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 22;
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(49, 355);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(26, 13);
            this.lbDNI.TabIndex = 21;
            this.lbDNI.Text = "DNI";
            // 
            // nudDNI
            // 
            this.nudDNI.Location = new System.Drawing.Point(122, 353);
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
            this.nudDNI.Size = new System.Drawing.Size(120, 20);
            this.nudDNI.TabIndex = 23;
            this.nudDNI.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(122, 430);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(100, 20);
            this.tbApellido.TabIndex = 24;
            // 
            // nudTel
            // 
            this.nudTel.Location = new System.Drawing.Point(122, 471);
            this.nudTel.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudTel.Name = "nudTel";
            this.nudTel.Size = new System.Drawing.Size(120, 20);
            this.nudTel.TabIndex = 25;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(49, 395);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 26;
            this.lbApellido.Text = "Apellido";
            // 
            // lbNombres
            // 
            this.lbNombres.AutoSize = true;
            this.lbNombres.Location = new System.Drawing.Point(49, 437);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(49, 13);
            this.lbNombres.TabIndex = 27;
            this.lbNombres.Text = "Nombres";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(49, 478);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(49, 13);
            this.lbTel.TabIndex = 28;
            this.lbTel.Text = "Telefono";
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(49, 291);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(27, 13);
            this.lbNum.TabIndex = 29;
            this.lbNum.Text = "Nro:";
            // 
            // nudNroPropiedad
            // 
            this.nudNroPropiedad.Location = new System.Drawing.Point(122, 291);
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
            this.nudNroPropiedad.Size = new System.Drawing.Size(120, 20);
            this.nudNroPropiedad.TabIndex = 30;
            this.nudNroPropiedad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCrear
            // 
            this.btnCrear.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCrear.Location = new System.Drawing.Point(27, 526);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 31;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(241, 526);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FAgregarCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 561);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.nudNroPropiedad);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.lbNombres);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.nudTel);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.nudDNI);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.lbPropietario);
            this.Controls.Add(this.chbDesayuno);
            this.Controls.Add(this.tbDireccionCasa);
            this.Controls.Add(this.lbDirec);
            this.Controls.Add(this.chbLimpieza);
            this.Controls.Add(this.chbPermiteMascotas);
            this.Controls.Add(this.chbWIFI);
            this.Controls.Add(this.chbGarage);
            this.Controls.Add(this.chbPileta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCantCamas);
            this.Controls.Add(this.nudCantCamas);
            this.Controls.Add(this.lbMinDias);
            this.Controls.Add(this.nudMinDias);
            this.Controls.Add(this.rbCasaFinde);
            this.Controls.Add(this.rbCasa);
            this.Name = "FAgregarCasa";
            this.Text = "FAgregarCasa";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantCamas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroPropiedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMinDias;
        private System.Windows.Forms.Label lbCantCamas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDirec;
        private System.Windows.Forms.Label lbPropietario;
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
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.NumericUpDown nudDNI;
        public System.Windows.Forms.TextBox tbApellido;
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
    }
}