
namespace tp2
{
    partial class FHotel
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
            this.lbSimple = new System.Windows.Forms.Label();
            this.lbDobles = new System.Windows.Forms.Label();
            this.lbTriple = new System.Windows.Forms.Label();
            this.nudSimples = new System.Windows.Forms.NumericUpDown();
            this.nudDobles = new System.Windows.Forms.NumericUpDown();
            this.nudTriples = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarImágen = new System.Windows.Forms.Button();
            this.gbServicios = new System.Windows.Forms.GroupBox();
            this.tlpServicios = new System.Windows.Forms.TableLayoutPanel();
            this.chbPileta = new System.Windows.Forms.CheckBox();
            this.chbGarage = new System.Windows.Forms.CheckBox();
            this.chbWIFI = new System.Windows.Forms.CheckBox();
            this.chbPermiteMascotas = new System.Windows.Forms.CheckBox();
            this.chbLimpieza = new System.Windows.Forms.CheckBox();
            this.chbDesayuno = new System.Windows.Forms.CheckBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.tlpDatosBásicos = new System.Windows.Forms.TableLayoutPanel();
            this.tbDireccionHotel = new System.Windows.Forms.TextBox();
            this.lbDirec = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.Label();
            this.nudNroPropiedad = new System.Windows.Forms.NumericUpDown();
            this.trbEstrellas = new System.Windows.Forms.TrackBar();
            this.lblEstrellasMin = new System.Windows.Forms.Label();
            this.lblEstrellasMax = new System.Windows.Forms.Label();
            this.pnlEstrellas = new System.Windows.Forms.Panel();
            this.gbEstrellas = new System.Windows.Forms.GroupBox();
            this.tlpEstrellas = new System.Windows.Forms.TableLayoutPanel();
            this.tbMuestraEstrellas = new System.Windows.Forms.TextBox();
            this.tlpPlazas = new System.Windows.Forms.TableLayoutPanel();
            this.gbPlazas = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDobles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriples)).BeginInit();
            this.tlpBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbServicios.SuspendLayout();
            this.tlpServicios.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.tlpDatosBásicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroPropiedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEstrellas)).BeginInit();
            this.pnlEstrellas.SuspendLayout();
            this.gbEstrellas.SuspendLayout();
            this.tlpEstrellas.SuspendLayout();
            this.tlpPlazas.SuspendLayout();
            this.gbPlazas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSimple
            // 
            this.lbSimple.AutoSize = true;
            this.lbSimple.Location = new System.Drawing.Point(4, 8);
            this.lbSimple.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.lbSimple.Name = "lbSimple";
            this.lbSimple.Size = new System.Drawing.Size(61, 20);
            this.lbSimple.TabIndex = 2;
            this.lbSimple.Text = "Simples";
            // 
            // lbDobles
            // 
            this.lbDobles.AutoSize = true;
            this.lbDobles.Location = new System.Drawing.Point(4, 45);
            this.lbDobles.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.lbDobles.Name = "lbDobles";
            this.lbDobles.Size = new System.Drawing.Size(56, 20);
            this.lbDobles.TabIndex = 3;
            this.lbDobles.Text = "Dobles";
            // 
            // lbTriple
            // 
            this.lbTriple.AutoSize = true;
            this.lbTriple.Location = new System.Drawing.Point(4, 82);
            this.lbTriple.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.lbTriple.Name = "lbTriple";
            this.lbTriple.Size = new System.Drawing.Size(52, 20);
            this.lbTriple.TabIndex = 4;
            this.lbTriple.Text = "Triples";
            // 
            // nudSimples
            // 
            this.nudSimples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.nudSimples.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudSimples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSimples.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.nudSimples.Location = new System.Drawing.Point(73, 8);
            this.nudSimples.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
            this.nudSimples.Name = "nudSimples";
            this.nudSimples.Size = new System.Drawing.Size(309, 23);
            this.nudSimples.TabIndex = 0;
            this.nudSimples.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
            this.nudSimples.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
            // 
            // nudDobles
            // 
            this.nudDobles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.nudDobles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudDobles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudDobles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.nudDobles.Location = new System.Drawing.Point(73, 45);
            this.nudDobles.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
            this.nudDobles.Name = "nudDobles";
            this.nudDobles.Size = new System.Drawing.Size(309, 23);
            this.nudDobles.TabIndex = 1;
            this.nudDobles.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
            this.nudDobles.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
            // 
            // nudTriples
            // 
            this.nudTriples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.nudTriples.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTriples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTriples.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.nudTriples.Location = new System.Drawing.Point(73, 82);
            this.nudTriples.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
            this.nudTriples.Name = "nudTriples";
            this.nudTriples.Size = new System.Drawing.Size(309, 23);
            this.nudTriples.TabIndex = 2;
            this.nudTriples.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
            this.nudTriples.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnAceptar.Location = new System.Drawing.Point(4, 5);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(172, 32);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 3;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpBotones.Controls.Add(this.btnCancelar, 2, 0);
            this.tlpBotones.Controls.Add(this.btnAceptar, 0, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpBotones.Location = new System.Drawing.Point(16, 441);
            this.tlpBotones.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(402, 42);
            this.tlpBotones.TabIndex = 5;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregarImágen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(16, 399);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Size = new System.Drawing.Size(402, 42);
            this.panel1.TabIndex = 4;
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
            // gbServicios
            // 
            this.gbServicios.Controls.Add(this.tlpServicios);
            this.gbServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.gbServicios.Location = new System.Drawing.Point(16, 315);
            this.gbServicios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbServicios.Name = "gbServicios";
            this.gbServicios.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.gbServicios.Size = new System.Drawing.Size(402, 84);
            this.gbServicios.TabIndex = 3;
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
            this.tlpServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.tlpServicios.Location = new System.Drawing.Point(8, 19);
            this.tlpServicios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpServicios.Name = "tlpServicios";
            this.tlpServicios.RowCount = 2;
            this.tlpServicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpServicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpServicios.Size = new System.Drawing.Size(386, 60);
            this.tlpServicios.TabIndex = 0;
            // 
            // chbPileta
            // 
            this.chbPileta.AutoSize = true;
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
            this.chbLimpieza.Location = new System.Drawing.Point(273, 2);
            this.chbLimpieza.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chbLimpieza.Name = "chbLimpieza";
            this.chbLimpieza.Size = new System.Drawing.Size(88, 24);
            this.chbLimpieza.TabIndex = 2;
            this.chbLimpieza.Text = "Limpieza";
            this.chbLimpieza.UseVisualStyleBackColor = true;
            // 
            // chbDesayuno
            // 
            this.chbDesayuno.AutoSize = true;
            this.chbDesayuno.Location = new System.Drawing.Point(273, 32);
            this.chbDesayuno.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chbDesayuno.Name = "chbDesayuno";
            this.chbDesayuno.Size = new System.Drawing.Size(93, 24);
            this.chbDesayuno.TabIndex = 5;
            this.chbDesayuno.Text = "Desayuno";
            this.chbDesayuno.UseVisualStyleBackColor = true;
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
            this.tlpDatosBásicos.Controls.Add(this.tbDireccionHotel, 1, 0);
            this.tlpDatosBásicos.Controls.Add(this.lbDirec, 0, 0);
            this.tlpDatosBásicos.Controls.Add(this.lbNum, 2, 0);
            this.tlpDatosBásicos.Controls.Add(this.nudNroPropiedad, 3, 0);
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
            // tbDireccionHotel
            // 
            this.tbDireccionHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.tbDireccionHotel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDireccionHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDireccionHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tbDireccionHotel.Location = new System.Drawing.Point(84, 9);
            this.tbDireccionHotel.Margin = new System.Windows.Forms.Padding(4, 9, 4, 5);
            this.tbDireccionHotel.MaxLength = 28;
            this.tbDireccionHotel.Name = "tbDireccionHotel";
            this.tbDireccionHotel.Size = new System.Drawing.Size(188, 20);
            this.tbDireccionHotel.TabIndex = 0;
            this.tbDireccionHotel.Click += new System.EventHandler(this.SeleccionarTextBox);
            this.tbDireccionHotel.Enter += new System.EventHandler(this.SeleccionarTextBox);
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
            // nudNroPropiedad
            // 
            this.nudNroPropiedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.nudNroPropiedad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudNroPropiedad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudNroPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.nudNroPropiedad.Location = new System.Drawing.Point(325, 8);
            this.nudNroPropiedad.Margin = new System.Windows.Forms.Padding(4, 8, 4, 5);
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
            this.nudNroPropiedad.Size = new System.Drawing.Size(57, 23);
            this.nudNroPropiedad.TabIndex = 1;
            this.nudNroPropiedad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNroPropiedad.Click += new System.EventHandler(this.SeleccionarNumericUpDown);
            this.nudNroPropiedad.Enter += new System.EventHandler(this.SeleccionarNumericUpDown);
            // 
            // trbEstrellas
            // 
            this.trbEstrellas.Dock = System.Windows.Forms.DockStyle.Top;
            this.trbEstrellas.LargeChange = 1;
            this.trbEstrellas.Location = new System.Drawing.Point(17, 0);
            this.trbEstrellas.Maximum = 3;
            this.trbEstrellas.Minimum = 2;
            this.trbEstrellas.Name = "trbEstrellas";
            this.trbEstrellas.Size = new System.Drawing.Size(352, 45);
            this.trbEstrellas.TabIndex = 0;
            this.trbEstrellas.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trbEstrellas.Value = 3;
            this.trbEstrellas.ValueChanged += new System.EventHandler(this.TrbEstrellas_ValueChanged);
            // 
            // lblEstrellasMin
            // 
            this.lblEstrellasMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEstrellasMin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEstrellasMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(43)))), ((int)(((byte)(101)))));
            this.lblEstrellasMin.Location = new System.Drawing.Point(0, 0);
            this.lblEstrellasMin.Name = "lblEstrellasMin";
            this.lblEstrellasMin.Size = new System.Drawing.Size(17, 47);
            this.lblEstrellasMin.TabIndex = 0;
            this.lblEstrellasMin.Text = "2";
            this.lblEstrellasMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstrellasMax
            // 
            this.lblEstrellasMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEstrellasMax.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEstrellasMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(43)))), ((int)(((byte)(101)))));
            this.lblEstrellasMax.Location = new System.Drawing.Point(369, 0);
            this.lblEstrellasMax.Name = "lblEstrellasMax";
            this.lblEstrellasMax.Size = new System.Drawing.Size(17, 47);
            this.lblEstrellasMax.TabIndex = 0;
            this.lblEstrellasMax.Text = "3";
            this.lblEstrellasMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEstrellas
            // 
            this.pnlEstrellas.Controls.Add(this.trbEstrellas);
            this.pnlEstrellas.Controls.Add(this.lblEstrellasMin);
            this.pnlEstrellas.Controls.Add(this.lblEstrellasMax);
            this.pnlEstrellas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstrellas.Location = new System.Drawing.Point(8, 16);
            this.pnlEstrellas.Name = "pnlEstrellas";
            this.pnlEstrellas.Size = new System.Drawing.Size(386, 47);
            this.pnlEstrellas.TabIndex = 0;
            // 
            // gbEstrellas
            // 
            this.gbEstrellas.Controls.Add(this.pnlEstrellas);
            this.gbEstrellas.Controls.Add(this.tlpEstrellas);
            this.gbEstrellas.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEstrellas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbEstrellas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.gbEstrellas.Location = new System.Drawing.Point(16, 81);
            this.gbEstrellas.Margin = new System.Windows.Forms.Padding(4, 2, 4, 5);
            this.gbEstrellas.Name = "gbEstrellas";
            this.gbEstrellas.Padding = new System.Windows.Forms.Padding(8, 2, 8, 5);
            this.gbEstrellas.Size = new System.Drawing.Size(402, 101);
            this.gbEstrellas.TabIndex = 1;
            this.gbEstrellas.TabStop = false;
            this.gbEstrellas.Text = "ESTRELLAS";
            // 
            // tlpEstrellas
            // 
            this.tlpEstrellas.ColumnCount = 3;
            this.tlpEstrellas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEstrellas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpEstrellas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEstrellas.Controls.Add(this.tbMuestraEstrellas, 1, 0);
            this.tlpEstrellas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpEstrellas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tlpEstrellas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.tlpEstrellas.Location = new System.Drawing.Point(8, 63);
            this.tlpEstrellas.Name = "tlpEstrellas";
            this.tlpEstrellas.RowCount = 1;
            this.tlpEstrellas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEstrellas.Size = new System.Drawing.Size(386, 33);
            this.tlpEstrellas.TabIndex = 1;
            // 
            // tbMuestraEstrellas
            // 
            this.tbMuestraEstrellas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(17)))));
            this.tbMuestraEstrellas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMuestraEstrellas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbMuestraEstrellas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.tbMuestraEstrellas.Location = new System.Drawing.Point(166, 6);
            this.tbMuestraEstrellas.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.tbMuestraEstrellas.Name = "tbMuestraEstrellas";
            this.tbMuestraEstrellas.ReadOnly = true;
            this.tbMuestraEstrellas.Size = new System.Drawing.Size(54, 20);
            this.tbMuestraEstrellas.TabIndex = 1;
            this.tbMuestraEstrellas.TabStop = false;
            this.tbMuestraEstrellas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpPlazas
            // 
            this.tlpPlazas.ColumnCount = 2;
            this.tlpPlazas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPlazas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlazas.Controls.Add(this.lbDobles, 0, 1);
            this.tlpPlazas.Controls.Add(this.lbTriple, 0, 2);
            this.tlpPlazas.Controls.Add(this.lbSimple, 0, 0);
            this.tlpPlazas.Controls.Add(this.nudSimples, 1, 0);
            this.tlpPlazas.Controls.Add(this.nudDobles, 1, 1);
            this.tlpPlazas.Controls.Add(this.nudTriples, 1, 2);
            this.tlpPlazas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlazas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tlpPlazas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.tlpPlazas.Location = new System.Drawing.Point(8, 16);
            this.tlpPlazas.Name = "tlpPlazas";
            this.tlpPlazas.RowCount = 3;
            this.tlpPlazas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPlazas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPlazas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPlazas.Size = new System.Drawing.Size(386, 112);
            this.tlpPlazas.TabIndex = 0;
            // 
            // gbPlazas
            // 
            this.gbPlazas.Controls.Add(this.tlpPlazas);
            this.gbPlazas.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPlazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbPlazas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.gbPlazas.Location = new System.Drawing.Point(16, 182);
            this.gbPlazas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPlazas.Name = "gbPlazas";
            this.gbPlazas.Padding = new System.Windows.Forms.Padding(8, 2, 8, 5);
            this.gbPlazas.Size = new System.Drawing.Size(402, 133);
            this.gbPlazas.TabIndex = 2;
            this.gbPlazas.TabStop = false;
            this.gbPlazas.Text = "CANTIDAD DE PLAZAS";
            // 
            // FHotel
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(434, 501);
            this.Controls.Add(this.gbServicios);
            this.Controls.Add(this.gbPlazas);
            this.Controls.Add(this.gbEstrellas);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlpBotones);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(450, 532);
            this.Name = "FHotel";
            this.Padding = new System.Windows.Forms.Padding(16, 18, 16, 18);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.FAgregarHotel_Load);
            this.Shown += new System.EventHandler(this.FAgregarHotel_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudSimples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDobles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriples)).EndInit();
            this.tlpBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbServicios.ResumeLayout(false);
            this.tlpServicios.ResumeLayout(false);
            this.tlpServicios.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.tlpDatosBásicos.ResumeLayout(false);
            this.tlpDatosBásicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroPropiedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEstrellas)).EndInit();
            this.pnlEstrellas.ResumeLayout(false);
            this.pnlEstrellas.PerformLayout();
            this.gbEstrellas.ResumeLayout(false);
            this.tlpEstrellas.ResumeLayout(false);
            this.tlpEstrellas.PerformLayout();
            this.tlpPlazas.ResumeLayout(false);
            this.tlpPlazas.PerformLayout();
            this.gbPlazas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbSimple;
        private System.Windows.Forms.Label lbDobles;
        private System.Windows.Forms.Label lbTriple;
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.NumericUpDown nudSimples;
        public System.Windows.Forms.NumericUpDown nudDobles;
        public System.Windows.Forms.NumericUpDown nudTriples;
		private System.Windows.Forms.TableLayoutPanel tlpBotones;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAgregarImágen;
		private System.Windows.Forms.GroupBox gbServicios;
		private System.Windows.Forms.TableLayoutPanel tlpServicios;
		public System.Windows.Forms.CheckBox chbPileta;
		public System.Windows.Forms.CheckBox chbGarage;
		public System.Windows.Forms.CheckBox chbWIFI;
		public System.Windows.Forms.CheckBox chbPermiteMascotas;
		public System.Windows.Forms.CheckBox chbLimpieza;
		public System.Windows.Forms.CheckBox chbDesayuno;
		private System.Windows.Forms.GroupBox gbDatos;
		private System.Windows.Forms.TableLayoutPanel tlpDatosBásicos;
		public System.Windows.Forms.TextBox tbDireccionHotel;
		private System.Windows.Forms.Label lbDirec;
		private System.Windows.Forms.Label lbNum;
		public System.Windows.Forms.NumericUpDown nudNroPropiedad;
		public System.Windows.Forms.TrackBar trbEstrellas;
		private System.Windows.Forms.Label lblEstrellasMin;
		private System.Windows.Forms.Label lblEstrellasMax;
		private System.Windows.Forms.Panel pnlEstrellas;
		private System.Windows.Forms.GroupBox gbEstrellas;
		private System.Windows.Forms.TableLayoutPanel tlpEstrellas;
		private System.Windows.Forms.TextBox tbMuestraEstrellas;
		private System.Windows.Forms.TableLayoutPanel tlpPlazas;
		private System.Windows.Forms.GroupBox gbPlazas;
	}
}