
namespace tp2
{
    partial class FAgregarHotel
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
            this.lbEstrellas = new System.Windows.Forms.Label();
            this.nudEstrellas = new System.Windows.Forms.NumericUpDown();
            this.lbSimple = new System.Windows.Forms.Label();
            this.lbDobles = new System.Windows.Forms.Label();
            this.lbTriple = new System.Windows.Forms.Label();
            this.nudSimples = new System.Windows.Forms.NumericUpDown();
            this.nudDobles = new System.Windows.Forms.NumericUpDown();
            this.nudTriples = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nudNroPropiedad = new System.Windows.Forms.NumericUpDown();
            this.lbNum = new System.Windows.Forms.Label();
            this.tbDireccionHotel = new System.Windows.Forms.TextBox();
            this.lbDirec = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chbDesayuno = new System.Windows.Forms.CheckBox();
            this.chbLimpieza = new System.Windows.Forms.CheckBox();
            this.chbPermiteMascotas = new System.Windows.Forms.CheckBox();
            this.chbWIFI = new System.Windows.Forms.CheckBox();
            this.chbGarage = new System.Windows.Forms.CheckBox();
            this.chbPileta = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstrellas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDobles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroPropiedad)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEstrellas
            // 
            this.lbEstrellas.AutoSize = true;
            this.lbEstrellas.Location = new System.Drawing.Point(45, 29);
            this.lbEstrellas.Name = "lbEstrellas";
            this.lbEstrellas.Size = new System.Drawing.Size(46, 13);
            this.lbEstrellas.TabIndex = 0;
            this.lbEstrellas.Text = "Estrellas";
            // 
            // nudEstrellas
            // 
            this.nudEstrellas.Location = new System.Drawing.Point(119, 29);
            this.nudEstrellas.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudEstrellas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudEstrellas.Name = "nudEstrellas";
            this.nudEstrellas.Size = new System.Drawing.Size(34, 20);
            this.nudEstrellas.TabIndex = 1;
            this.nudEstrellas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lbSimple
            // 
            this.lbSimple.AutoSize = true;
            this.lbSimple.Location = new System.Drawing.Point(45, 70);
            this.lbSimple.Name = "lbSimple";
            this.lbSimple.Size = new System.Drawing.Size(68, 13);
            this.lbSimple.TabIndex = 2;
            this.lbSimple.Text = "Cant Simples";
            // 
            // lbDobles
            // 
            this.lbDobles.AutoSize = true;
            this.lbDobles.Location = new System.Drawing.Point(45, 104);
            this.lbDobles.Name = "lbDobles";
            this.lbDobles.Size = new System.Drawing.Size(65, 13);
            this.lbDobles.TabIndex = 3;
            this.lbDobles.Text = "Cant Dobles";
            // 
            // lbTriple
            // 
            this.lbTriple.AutoSize = true;
            this.lbTriple.Location = new System.Drawing.Point(45, 136);
            this.lbTriple.Name = "lbTriple";
            this.lbTriple.Size = new System.Drawing.Size(63, 13);
            this.lbTriple.TabIndex = 4;
            this.lbTriple.Text = "Cant Triples";
            // 
            // nudSimples
            // 
            this.nudSimples.Location = new System.Drawing.Point(139, 70);
            this.nudSimples.Name = "nudSimples";
            this.nudSimples.Size = new System.Drawing.Size(120, 20);
            this.nudSimples.TabIndex = 5;
            // 
            // nudDobles
            // 
            this.nudDobles.Location = new System.Drawing.Point(139, 104);
            this.nudDobles.Name = "nudDobles";
            this.nudDobles.Size = new System.Drawing.Size(120, 20);
            this.nudDobles.TabIndex = 6;
            // 
            // nudTriples
            // 
            this.nudTriples.Location = new System.Drawing.Point(139, 136);
            this.nudTriples.Name = "nudTriples";
            this.nudTriples.Size = new System.Drawing.Size(120, 20);
            this.nudTriples.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(353, 458);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // nudNroPropiedad
            // 
            this.nudNroPropiedad.Location = new System.Drawing.Point(119, 216);
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
            this.nudNroPropiedad.TabIndex = 36;
            this.nudNroPropiedad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(46, 216);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(27, 13);
            this.lbNum.TabIndex = 35;
            this.lbNum.Text = "Nro:";
            // 
            // tbDireccionHotel
            // 
            this.tbDireccionHotel.Location = new System.Drawing.Point(119, 188);
            this.tbDireccionHotel.Name = "tbDireccionHotel";
            this.tbDireccionHotel.Size = new System.Drawing.Size(100, 20);
            this.tbDireccionHotel.TabIndex = 34;
            // 
            // lbDirec
            // 
            this.lbDirec.AutoSize = true;
            this.lbDirec.Location = new System.Drawing.Point(45, 191);
            this.lbDirec.Name = "lbDirec";
            this.lbDirec.Size = new System.Drawing.Size(55, 13);
            this.lbDirec.TabIndex = 33;
            this.lbDirec.Text = "Direccion:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(109, 458);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 38;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // chbDesayuno
            // 
            this.chbDesayuno.AutoSize = true;
            this.chbDesayuno.Location = new System.Drawing.Point(200, 312);
            this.chbDesayuno.Name = "chbDesayuno";
            this.chbDesayuno.Size = new System.Drawing.Size(74, 17);
            this.chbDesayuno.TabIndex = 45;
            this.chbDesayuno.Text = "Desayuno";
            this.chbDesayuno.UseVisualStyleBackColor = true;
            // 
            // chbLimpieza
            // 
            this.chbLimpieza.AutoSize = true;
            this.chbLimpieza.Location = new System.Drawing.Point(200, 289);
            this.chbLimpieza.Name = "chbLimpieza";
            this.chbLimpieza.Size = new System.Drawing.Size(67, 17);
            this.chbLimpieza.TabIndex = 44;
            this.chbLimpieza.Text = "Limpieza";
            this.chbLimpieza.UseVisualStyleBackColor = true;
            // 
            // chbPermiteMascotas
            // 
            this.chbPermiteMascotas.AutoSize = true;
            this.chbPermiteMascotas.Location = new System.Drawing.Point(200, 266);
            this.chbPermiteMascotas.Name = "chbPermiteMascotas";
            this.chbPermiteMascotas.Size = new System.Drawing.Size(110, 17);
            this.chbPermiteMascotas.TabIndex = 43;
            this.chbPermiteMascotas.Text = "Permite Mascotas";
            this.chbPermiteMascotas.UseVisualStyleBackColor = true;
            // 
            // chbWIFI
            // 
            this.chbWIFI.AutoSize = true;
            this.chbWIFI.Location = new System.Drawing.Point(116, 313);
            this.chbWIFI.Name = "chbWIFI";
            this.chbWIFI.Size = new System.Drawing.Size(49, 17);
            this.chbWIFI.TabIndex = 42;
            this.chbWIFI.Text = "WIFI";
            this.chbWIFI.UseVisualStyleBackColor = true;
            // 
            // chbGarage
            // 
            this.chbGarage.AutoSize = true;
            this.chbGarage.Location = new System.Drawing.Point(116, 289);
            this.chbGarage.Name = "chbGarage";
            this.chbGarage.Size = new System.Drawing.Size(61, 17);
            this.chbGarage.TabIndex = 41;
            this.chbGarage.Text = "Garage";
            this.chbGarage.UseVisualStyleBackColor = true;
            // 
            // chbPileta
            // 
            this.chbPileta.AutoSize = true;
            this.chbPileta.Location = new System.Drawing.Point(116, 266);
            this.chbPileta.Name = "chbPileta";
            this.chbPileta.Size = new System.Drawing.Size(52, 17);
            this.chbPileta.TabIndex = 40;
            this.chbPileta.Text = "Pileta";
            this.chbPileta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Servicios:";
            // 
            // FAgregarHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 536);
            this.Controls.Add(this.chbDesayuno);
            this.Controls.Add(this.chbLimpieza);
            this.Controls.Add(this.chbPermiteMascotas);
            this.Controls.Add(this.chbWIFI);
            this.Controls.Add(this.chbGarage);
            this.Controls.Add(this.chbPileta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.nudNroPropiedad);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.tbDireccionHotel);
            this.Controls.Add(this.lbDirec);
            this.Controls.Add(this.nudTriples);
            this.Controls.Add(this.nudDobles);
            this.Controls.Add(this.nudSimples);
            this.Controls.Add(this.lbTriple);
            this.Controls.Add(this.lbDobles);
            this.Controls.Add(this.lbSimple);
            this.Controls.Add(this.nudEstrellas);
            this.Controls.Add(this.lbEstrellas);
            this.Name = "FAgregarHotel";
            this.Text = "FAgregarHotel";
            ((System.ComponentModel.ISupportInitialize)(this.nudEstrellas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDobles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroPropiedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEstrellas;
        private System.Windows.Forms.Label lbSimple;
        private System.Windows.Forms.Label lbDobles;
        private System.Windows.Forms.Label lbTriple;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.NumericUpDown nudNroPropiedad;
        private System.Windows.Forms.Label lbNum;
        public System.Windows.Forms.TextBox tbDireccionHotel;
        private System.Windows.Forms.Label lbDirec;
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.CheckBox chbDesayuno;
        public System.Windows.Forms.CheckBox chbLimpieza;
        public System.Windows.Forms.CheckBox chbPermiteMascotas;
        public System.Windows.Forms.CheckBox chbWIFI;
        public System.Windows.Forms.CheckBox chbGarage;
        public System.Windows.Forms.CheckBox chbPileta;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown nudEstrellas;
        public System.Windows.Forms.NumericUpDown nudSimples;
        public System.Windows.Forms.NumericUpDown nudDobles;
        public System.Windows.Forms.NumericUpDown nudTriples;
    }
}